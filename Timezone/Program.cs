using System;
using System.Collections.Generic;


namespace Timezone
{
    class Program
    {        
        static void Main(string[] args)
        {
            try
            {
                Parser timeZoneParser = new Parser();

                string timeZoneInfoId = string.Empty;
                using (Reader fileReader = new Reader())
                {
                    List<Tuple<string, string>> lTimes = fileReader.Read();
                    foreach (var t in lTimes)
                    {
                        timeZoneParser.DisplayTime(t.Item1, t.Item2);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("An exception has occured causing this program to fail.\n\n Exceptions message - {0}", e.Message));
            }
            finally {
                Console.WriteLine("\n\nThe programme has completed, press any key to finish");
                Console.ReadLine();
            }
        }
    }
}
