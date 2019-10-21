using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timezone
{
    class Program
    {        
        static void Main(string[] args)
        {
            Parser timeZoneParser = new Parser();
            TimeZoneInfoMapper mapper = new TimeZoneInfoMapper();
            TimeZoneInfo tzInfo = TimeZoneInfo.Local;
            using (Reader fileReader = new Reader())
            {
                List<Tuple<string, string>> lTimes = fileReader.Read();
                foreach (var t in lTimes) {
                    if (mapper.HasMapping(t.Item2, ref tzInfo))
                    {
                        Console.WriteLine(tzInfo.Id);
                    }
                    else {
                        Console.WriteLine("Error: TimeZone mapping is unavailable for " + t.Item2);
                    }
                }

            }
        }
    }
}
