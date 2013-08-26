using System;

namespace YTNotifier.Helper_Classes
{
   static class CustomMillisecondConversion
   {
       public static int ConvertToMilliseconds(string value)
       {
           int result = 0;
           string[] values = value.Split(' ');
           values[1] = values[1].ToLower().Replace("minutes", "60000").Replace("minute", "60000").Replace("hours", "3600000").Replace("hour", "3600000");
           result = int.Parse(values[0]) * int.Parse(values[1]);

           return result;
       }

       public static string ConvertFromMilliseconds(int value)
       {
           string result = string.Empty;
           TimeSpan time = TimeSpan.FromMilliseconds(value);

           if (time.Hours > 0)
           {
               result += time.Hours.ToString() + " ";
               result += time.Hours == 1 ? "Hour" : "Hours";
           }
           else
           {
               result += time.Minutes.ToString() + " ";
               result += time.Minutes == 1 ? "Minute" : "Minutes";
           }

           return result;
       }
    }
}
