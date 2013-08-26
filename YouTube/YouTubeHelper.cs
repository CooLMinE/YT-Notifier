using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using YTNotifier.Helper_Classes;

namespace YTNotifier.Youtube
{
    class YouTubeHelper
    {
        public static YouTubeChannnel GetYoutubeChannel(string channelName)
        {
            //string _channelURL = string.Format(SSecure.Unprotect("aHR0cDovL2dkYXRhLnlvdXR1YmUuY29tL2ZlZWRzL2Jhc2UvdXNlcnMvezB9L3VwbG9hZHM/b3JkZXJieT11cGRhdGVkJmFsdD1yc3MmY2xpZW50PXl0YXBpLXlvdXR1YmUtcnNzLXJlZGlyZWN0JnY9MiZtYXgtcmVzdWx0cz01MA=="), channelName);
            string _channelURL = string.Format(SSecure.Unprotect("aHR0cDovL2dkYXRhLnlvdXR1YmUuY29tL2ZlZWRzL2Jhc2UvdXNlcnMvezB9L3VwbG9hZHM/YWx0PXJzcyZjbGllbnQ9eXRhcGkteW91dHViZS1yc3MtcmVkaXJlY3Qmdj0yJm1heC1yZXN1bHRzPTUw"), channelName);

            WebRequest request = WebRequest.Create(_channelURL);
            request.Timeout = 15000;

            using (WebResponse response = request.GetResponse())
            {
                using (XmlReader reader = XmlReader.Create(response.GetResponseStream()))
                {
                    SyndicationFeed feed = SyndicationFeed.Load(reader);

                    List<YouTubeVideo> videoList = new List<YouTubeVideo>();
                    foreach (var item in feed.Items)
                    {
                        string title = item.Title.Text;
                        string url = Regex.Match(item.Summary.Text, @"<a href=""(.+)&", RegexOptions.Multiline).Groups[1].Value;
                        string id = Regex.Match(url, @"watch\?v=([\w-]+)").Groups[1].Value;
                        string date = item.PublishDate.DateTime.ToString();
                        string views = Regex.Match(item.Summary.Text, @"Views:<\/span>\n(\d+)").Groups[1].Value;
                        string duration = Regex.Match(item.Summary.Text, @"Time:<\/span>\n.+?>([\d:]+)<").Groups[1].Value;

                        videoList.Add(new YouTubeVideo(title, channelName, url, id, date, views, duration));
                    }

                    return new YouTubeChannnel(channelName, videoList);
                }
            }
        }
    }
}
