using System;

namespace Timezone
{
    public class Parser : IParser
    {
        private readonly TimeZoneInfoMapper mapper;
        
        public Parser()
        {
            mapper = new TimeZoneInfoMapper();
        }

        public void DisplayTime(string time, string timeZone)
        {
            DateTime localTime;
            TimeZoneInfo remoteTimeZone;

            //Deal with any possible data or system issues.
            if (!DateTime.TryParse(time, out localTime))
            {
                Console.WriteLine(String.Format("Issue with Timezone.txt - DateTime {0} is not a valid value for time for Time Zone {1}.", time, timeZone));
                return;
            }

            if (!mapper.HasMapping(timeZone, out remoteTimeZone))
            {
                Console.WriteLine(String.Format("Issue with TimeZone - Time zone mapping could not be completed for {0}", timeZone));
                return;
            }

            //Calculate the remote time, without dealing with daylight saving time.
            var remoteTime = localTime.Add(remoteTimeZone.GetUtcOffset(localTime));

            Console.WriteLine(
                String.Format("The time in the UK is {0} and the time in {1} is {2} - UTC Offset is {3}.", localTime.ToString("HH:mm"), timeZone, remoteTime.ToString("HH:mm"), remoteTimeZone.GetUtcOffset(remoteTime)));

        }
    }
}
