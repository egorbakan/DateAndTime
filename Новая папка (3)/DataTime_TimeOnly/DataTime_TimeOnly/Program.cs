using System;
using System.Globalization;

namespace DataTime_TimeOnly
{
    class Program
    {
        static void Main(string[] args)
        {


            //Метод Parse

            /*string[] strDate = new string[]
            {
                "10/05/2012 10:15:09",
                "15/05/2010",
                "7/2009",
                "9/15",
                "05:20:10",
                "6 PM",
                "2020-06-18T07:15:12.0000000Z",
                "2015-04-18T07:20:10.0000000-07:00",
                "Sat, 05 Sep 2014 10:12:09 GMT",
                "10/11/2020 08:10:10 -3:00"
            };
            foreach (string str in strDate)
            {
                DateTime dt = DateTime.Parse(str, CultureInfo.GetCultureInfo("en-US"));
                Console.WriteLine($"{dt}");
            }*/

            //Метод ParseExact

            /*string date = "15101990";
            DateTime dt = DateTime.ParseExact(date, "ddMMyyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dt);*/

            //Метод TryParse и TryParseExact

           /* string[] strDate = new string[]
            {
               "10/05/2012 10:15:09",
                "15/05/2010",
                "7/2009",
                "9/15",
                "05:20:10",
                "6 PM",
                "2020-06-18T07:15:12.0000000Z",
                "2015-04-18T07:20:10.0000000-07:00",
                "Sat, 05 Sep 2014 10:12:09 GMT",
                "10/11/2020 08:10:10 -3:00"
            };

            foreach (string str in strDate)
            {
                DateTime dt;
                if (DateTime.TryParse(str, out dt))
                {
                    Console.WriteLine($"{dt}");
                }
                else
                    Console.WriteLine("Parsing Error");
            }
           */
        }
    }
}
