using System;

namespace YoutubeDownloader
{
    public class YoutubeVideo
    {
        public string id, title, description;
        public DateTime publishedDate;

        public YoutubeVideo(string id)
        {
            this.id = id;
            YoutubeAPI.GetVideoInfo(this);
        }
    }
}