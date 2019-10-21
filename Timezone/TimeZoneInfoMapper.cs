using System;

namespace Timezone
{
    public class TimeZoneInfoMapper
    {
        public bool HasMapping(string timeZoneReference, out TimeZoneInfo timeZoneInfo)
        {
            var result = false;
            timeZoneInfo = TimeZoneInfo.Local;

            foreach (var tzi in TimeZoneInfo.GetSystemTimeZones())
            {
                if (tzi.DisplayName.Contains(timeZoneReference))
                {
                    timeZoneInfo = tzi;
                    return true;
                }
            }

            return result;
        }
    }
}
