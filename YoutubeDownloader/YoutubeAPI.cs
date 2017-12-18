using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using System.Threading;

namespace YoutubeDownloader
{
    class YoutubeAPI
    {
        private static YouTubeService ytService = Auth();

        private static YouTubeService Auth()
        {
            UserCredential creds;

            using (var stream = new FileStream(Environment.CurrentDirectory + "/" + "youtube_client_secret.json", FileMode.Open, FileAccess.Read))
            {
                creds = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        new[] { YouTubeService.Scope.YoutubeReadonly },
                        "user",
                        CancellationToken.None,
                        new FileDataStore("YoutubeAPI")
                        ).Result;
            }

            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = creds,
                ApplicationName = "YoutubeAPI"
            });

            return service;
        }

        public static void GetVideoInfo(YoutubeVideo video)
        {
            var videoRequest = ytService.Videos.List("snippet");
            videoRequest.Id = video.id;


            var response = videoRequest.Execute();
            if (response.Items.Count > 0)
            {
                video.title = response.Items[0].Snippet.Title;
                video.description = response.Items[0].Snippet.Description;
                video.publishedDate = response.Items[0].Snippet.PublishedAt.Value;
            }
            else
            {
                video.title = "No video with this ID.";
                video.description = "-";
            }
        }

        internal static YoutubeVideo[] searchByName(string keyword)
        {
            var searchListRequest = ytService.Search.List("snippet");
            searchListRequest.Q = keyword;
            searchListRequest.MaxResults = 10;

            var searchListResponse = searchListRequest.Execute();

            LinkedList<YoutubeVideo> videos = new LinkedList<YoutubeVideo>();
            LinkedList<YoutubeVideo> channels = new LinkedList<YoutubeVideo>();
            LinkedList<YoutubeVideo> playlists = new LinkedList<YoutubeVideo>();

            foreach (var item in searchListResponse.Items)
            {
                switch (item.Id.Kind)
                {
                    case "youtube#video":
                        if (item.Id.VideoId != null)
                            videos.AddLast(new YoutubeVideo(String.Format(item.Id.VideoId)));
                        break;
                    case "youtube#channel":
                        break;
                    case "youtube#playlist":
                        break;
                }
            }


            return videos.ToArray<YoutubeVideo>();
        }
    }
}
