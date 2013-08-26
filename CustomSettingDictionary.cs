using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace YTNotifier
{
    class CustomSettingDictionary
    {
        public static bool ContainsKey(string key)
        {
            bool result = false;

            foreach (string pair in Properties.Settings.Default.ChannelInformation)
            {
                if (pair.Split(',')[0] == key)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public static void AddEntry(string key, string url, string date)
        {
            string encodedURL = HttpUtility.UrlEncode(url);
            Properties.Settings.Default.ChannelInformation.Add(key + "," + encodedURL + "," + date);
            Properties.Settings.Default.Save();
        }

        public static void TryAddEntry(string key, string url, string date)
        {
            if (!ContainsKey(key))
                AddEntry(key, url, date);
            else
                SetValue(key, url, date);
        }

        public static void RemoveEntry(string key)
        {
            StringCollection collection = new StringCollection();
            collection.AddRange(Properties.Settings.Default.ChannelInformation.OfType<string>().ToArray());

            foreach (string entry in Properties.Settings.Default.ChannelInformation)
            {
                string[] pairValues = entry.Split(',');

                if (pairValues[0] == key)
                    collection.Remove(entry);
            }

            Properties.Settings.Default.ChannelInformation = collection;
            Properties.Settings.Default.Save();
        }

        public static string GetKeyURL(string key)
        {
            string result = string.Empty;

            foreach (string pair in Properties.Settings.Default.ChannelInformation)
            {
                string[] pairValues = pair.Split(',');
                if (pairValues[0] == key)
                {
                    result = HttpUtility.UrlDecode(pairValues[1]);
                    break;
                }
            }

            return result;
        }


        public static string GetKeyDate(string key)
        {
            string result = string.Empty;

            foreach (string pair in Properties.Settings.Default.ChannelInformation)
            {
                string[] pairValues = pair.Split(',');

                if (pairValues[0] == key)
                {
                    if (pairValues.Length == 3)
                    {
                        result = pairValues[2];
                        break;
                    }
                }
            }

            return result;
        }

        public static void SetValue(string key, string newURL, string newDate)
        {
            StringCollection list = new StringCollection();
            string encodedURL = HttpUtility.UrlEncode(newURL);

            foreach (string pair in Properties.Settings.Default.ChannelInformation)
            {
                string[] pairValues = pair.Split(',');

                if (pairValues[0] == key)
                {
                    list.Remove(pair);
                    list.Add(pairValues[0] + "," + encodedURL + "," + newDate);
                }
                else
                    list.Add(pair);
            }
            Properties.Settings.Default.ChannelInformation = list;
            Properties.Settings.Default.Save();
        }
    }
}
