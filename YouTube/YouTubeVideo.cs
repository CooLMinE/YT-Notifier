using System;
using System.Globalization;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using YTNotifier.Helper_Classes;

namespace YTNotifier.Youtube
{
    public class YouTubeVideo
    {
        string _title;
        string _channel;
        string _url;
        string _id;
        string _date;
        string _views;
        string _duration;

        public YouTubeVideo(string title, string channel, string url, string id, string date, string views, string duration)
        {
            _title = title;
            _channel = channel;
            _url = url;
            _id = id;
            _date = date;
            _views = views;
            _duration = duration;
        }

        public string Title
        {
            get { return _title; }
        }
        public string ChannelName
        {
            get { return _channel;}
        }
        public string URL
        {
            get { return _url;}
        }
        public string ID
        {
           get {  return _id;}
        }
        public string Date
        {
           get {  return _date;}
        }
        public string Views
        {
          get {   return _views;}
        }
        public string Duration
        {
           get {  return _duration;}
        }
    }
}
