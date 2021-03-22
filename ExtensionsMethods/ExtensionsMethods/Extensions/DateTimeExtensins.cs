﻿using System.Globalization;

namespace System
{
    public static class DateTimeExtensins
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
