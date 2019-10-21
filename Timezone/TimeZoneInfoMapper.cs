using System;
using System.Collections.Generic;


namespace Timezone
{
    public class TimeZoneInfoMapper
    {
        private Dictionary<string, TimeZoneInfo> timeZoneMapping;
        public TimeZoneInfoMapper()
        {
            timeZoneMapping = new Dictionary<string, TimeZoneInfo>();

            timeZoneMapping.Add("Amsterdam", TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"));
            timeZoneMapping.Add("Minsk", TimeZoneInfo.FindSystemTimeZoneById("Belarus Standard Time"));
            timeZoneMapping.Add("Samoa", TimeZoneInfo.FindSystemTimeZoneById("Samoa Standard Time"));
            timeZoneMapping.Add("London", TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
            timeZoneMapping.Add("Dublin", TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
            timeZoneMapping.Add("Hawaii", TimeZoneInfo.FindSystemTimeZoneById("Hawaiian Standard Time"));
            timeZoneMapping.Add("Alaska", TimeZoneInfo.FindSystemTimeZoneById("Samoa Standard Time"));
            timeZoneMapping.Add("Arizona", TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time"));

        }


        public bool HasMapping(string timeZoneReference, ref TimeZoneInfo timeZoneInfo) {
            var result = false;

            if (timeZoneMapping.ContainsKey(timeZoneReference))
            {
                timeZoneInfo = timeZoneMapping[timeZoneReference];
                result = true;
            }

            return result;
        }
    }
}
