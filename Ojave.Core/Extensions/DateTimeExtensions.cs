using Ojave.Core.System;

namespace Ojave.Core.Extensions;
public static class DateTimeExtensions
{
    public static (DateTime, DateTime) BetweenPeriod(this DateTime date, TimePeriod timePeriod = TimePeriod.Day)
    {
        switch (timePeriod)
        {
            case TimePeriod.Day:
                return (date.Date, date.Date.AddDays(1).AddTicks(-1));
            case TimePeriod.Week:
                int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
                var mondayDate = date.AddDays(-1 * diff).Date;
                var sundayDate = mondayDate.AddDays(7);
                return (mondayDate, sundayDate);
            case TimePeriod.Month:
                var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                var lasyDayOfMonth = firstDayOfMonth.AddMonths(1).AddTicks(-1);
                return (firstDayOfMonth, lasyDayOfMonth);
            case TimePeriod.Year:
                var yearStart = new DateTime(date.Year, 1, 1);
                var yearEnd = new DateTime(date.Year, 12, 31);
                return (yearStart, yearEnd);
            default:
                return (date, date);
        }
    }
}
