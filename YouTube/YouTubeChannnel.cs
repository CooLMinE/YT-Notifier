using System.Collections.Generic;
using System.Linq;

namespace YTNotifier.Youtube
{
    class YouTubeChannnel
    {
        public string ChannelName { get; private set; }
        readonly List<YouTubeVideo> _videos = new List<YouTubeVideo>();

        public YouTubeChannnel(string name, List<YouTubeVideo> videos)
        {
            this.ChannelName = name;
            _videos = videos;
        }

        public YouTubeVideo GetLatestVideo()
        {
            return _videos.FirstOrDefault();
        }

        public IEnumerable<YouTubeVideo> GetVideos()
        {
            foreach (YouTubeVideo video in _videos)
            {
                yield return video;
            }
        }

        public IEnumerable<YouTubeVideo> GetVideos(int numberOfVideos)
        {
            int i = 0;
            foreach (YouTubeVideo video in _videos)
            {
                if (i < numberOfVideos)
                {
                    i++;
                    yield return video;
                }
                else
                    break;
            }
        }

        public int GetNumberOfVideosAvailable()
        {
            return _videos.Count;
        }
    }
}
