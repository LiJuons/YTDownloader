using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using System.Threading;
using System.Diagnostics;

namespace YoutubeDownloader
{
    public partial class Form : System.Windows.Forms.Form
    {
        LinkedList<YoutubeVideo> vidList = new LinkedList<YoutubeVideo>();
        string[] vidID = new string[10];

        public Form()
        {
            Cursor.Current = Cursors.AppStarting;
            InitializeComponent();
            lblVidTitle.Hide();
            lblVidLink.Hide();
            labelInfo.Hide();
            labelReso.Hide();
            comboReso.Hide();
            Cursor.Current = Cursors.Default;
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string videoURL = txtUrl.Text;
            string YtURL1 = "https://www.youtube.com/";
            string YtURL2 = "youtu.be";
            string fileName = textFName.Text;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            if (progressBar1.Value == 100)
                progressBar1.Value = 0;


            StringComparison comp = StringComparison.OrdinalIgnoreCase;

            if (videoURL.Contains(YtURL1) || videoURL.Contains(YtURL2))
            {
                if (radioMP3.Checked || radioMP4.Checked)
                {
                    if (fileName.ContainsSpecialChar() || "" == fileName) labelStatus.Text = "File Name is invalid.";
                    else
                    {
                        using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
                        {
                            if (fbd.ShowDialog() == DialogResult.OK)
                            {
                                IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(videoURL);
                                Cursor.Current = Cursors.Default;

                                if (radioMP3.Checked)
                                {
                                    try
                                    {
                                        Cursor.Current = Cursors.WaitCursor;
                                        VideoInfo video = videos
                                            .Where(info => info.AudioBitrate > 0 && info.AdaptiveType == AdaptiveType.Audio)
                                            .OrderByDescending(info => info.AudioBitrate).First();

                                        if (video.RequiresDecryption)
                                        {
                                            DownloadUrlResolver.DecryptDownloadUrl(video);
                                        }

                                        VideoDownloader downloader = new VideoDownloader(video, Path.Combine(fbd.SelectedPath + "/" + fileName + ".mp3"));

                                        downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
                                        
                                        Cursor.Current = Cursors.Default;

                                        Thread thread = new Thread(() =>
                                        {
                                            try
                                            {
                                                downloader.Execute();
                                            }
                                            catch (System.Net.WebException ex)
                                            {
                                                MessageBox.Show("Sorry, this video is not downloadable.");
                                            }
                                        })
                                        { IsBackground = true };
                                        thread.Start();
                                    }
                                    catch (System.InvalidOperationException ex)
                                    {
                                        MessageBox.Show("Sorry, this video is not convertable.");
                                    }
                                }

                                else if (radioMP4.Checked)
                                {
                                    Cursor.Current = Cursors.WaitCursor;
                                    bool validReso = false;
                                    foreach (var vid in videos)
                                    {
                                        if (Convert.ToInt32(comboReso.Text) == vid.Resolution) validReso = true;
                                    }
                                    if (validReso)
                                    {
                                        try
                                        {
                                            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(comboReso.Text));

                                            if (video.RequiresDecryption)
                                                DownloadUrlResolver.DecryptDownloadUrl(video);

                                            VideoDownloader downloader = new VideoDownloader(video, Path.Combine(fbd.SelectedPath + "/" + fileName + ".mp4"));

                                            downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;

                                            Cursor.Current = Cursors.Default;

                                            Thread thread = new Thread(() =>
                                            {
                                                try
                                                {
                                                    downloader.Execute();
                                                }
                                                catch (System.Net.WebException ex)
                                                {
                                                    MessageBox.Show("Sorry, this video is not downloadable.");
                                                }
                                            })
                                            { IsBackground = true };
                                            thread.Start();
                                        }
                                        catch (System.InvalidOperationException ex)
                                        {
                                            MessageBox.Show("Sorry, this video is not downloadable.");
                                        }
                                    }
                                    else labelStatus.Text = "Choose another resolution.";
                                    Cursor.Current = Cursors.Default;
                                }
                            }
                        }
                    }
                }
                else labelStatus.Text = "You must select format first.";
            }
            else if (videoURL == "") labelStatus.Text = "You must enter video URL.";
            else labelStatus.Text = "Video URL is invalid.";
        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Value = (int)e.ProgressPercentage;
                labelPercent.Text = $"{string.Format("{0:0.##}", e.ProgressPercentage)}%";
                progressBar1.Update();
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboReso.SelectedIndex = 2;
        }
        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            labelInfo.Show();
            lblVidTitle.Hide();
            lblVidLink.Hide();

            Cursor.Current = Cursors.WaitCursor;

            videosList.Items.Clear();

            string keyword = txtVidName.Text;
            YoutubeVideo[] videos = YoutubeAPI.searchByName(keyword);

            int index = 0;


            foreach (var video in videos)
            {
                vidID[index] = String.Format(video.id);
                vidList.AddLast(new YoutubeVideo(String.Format(video.id)));
                videosList.Items.Add(video.title);
                index++;
            }
            labelInfo.Hide();
            Cursor.Current = Cursors.Default;
        }

        private void videosList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblVidTitle.Show();
            lblVidLink.Show();
            lblVidTitle.Text = videosList.SelectedItem.ToString();
            lblVidLink.Text = "https://www.youtube.com/watch?v=" + vidID[videosList.SelectedIndex].ToString();
            lblVidLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lblVidLink_LinkClicked);
        }

        private void lblVidLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = lblVidLink.Text;

            if (null != target)
            {
                Clipboard.SetText(target);
                tabControl.SelectedIndex = 1;
                txtUrl.Text = target;
            }
        }

        private void videosList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (videosList.SelectedItem != null)
            {
                tabControl.SelectedIndex = 1;
                txtUrl.Text = lblVidLink.Text;
            }
        }

        private void radioMP4_Click(object sender, EventArgs e)
        {
            if (radioMP4.Checked)
            {
                labelReso.Show();
                comboReso.Show();
            }
        }

        private void radioMP3_Click(object sender, EventArgs e)
        {
            if (radioMP3.Checked)
            {
                labelReso.Hide();
                comboReso.Hide();
            }
        }

        private void txtUrl_Enter(object sender, EventArgs e)
        {
            labelStatus.Text = "Status.";
        }

        private void textFName_Enter(object sender, EventArgs e)
        {
            labelStatus.Text = "Status.";
        }

        private void resetListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videosList.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FINDER \n\n" +
                "  •  Enter video name. \n" +
                "  •  Click 'Search' button. \n" +
                "  •  Wait a few seconds. \n" +
                "  •  Select a video. \n" +
                "  •  Click on it's link or Double click item. \n\n\n" +
                "DOWNLOADER \n\n" +
                "  •  Insert, if not inserted, video URL. \n" +
                "  •  Select file format. \n" +
                "  •  If MP4, select file resolution. \n" +
                "  •  Enter file name. \n" +
                "  •  Click download and choose the path. \n\n\n", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nThis Windows .NET Application is made by \n\n\n" +
                "     Linas Jonas Žilinskas \n\n" +
                "     VU MIF IT 3 2017", "About", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
