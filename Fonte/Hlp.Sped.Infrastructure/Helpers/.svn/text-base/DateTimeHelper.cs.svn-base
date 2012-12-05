using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Infrastructure.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime GetFirstDayOfTheMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime GetLastDayOfTheMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1).
                AddMonths(1).AddDays(-1);
        }
    }
}
