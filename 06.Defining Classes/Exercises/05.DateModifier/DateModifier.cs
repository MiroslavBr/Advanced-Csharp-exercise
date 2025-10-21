using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public static class DateModifier
    {
        //public DateModifier(string date1, string date2)
        //{
        //    Date1 = date1;
        //    Date2 = date2;
        //}
        //public string Date1 { get; set; }
        //public string Date2 { get; set; }

        public static double GetDiference(string date1, string date2)
        {
            DateTime dateOne = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime dateTwo= DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);


            TimeSpan difference = dateOne - dateTwo;
            double totalDays = Math.Abs(difference.TotalDays);
            return totalDays;

        }
    }
}
