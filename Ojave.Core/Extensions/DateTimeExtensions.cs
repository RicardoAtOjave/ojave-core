using Ojave.Core.System;
using System.Globalization;

namespace Ojave.Core.Extensions;

public static class DateTimeExtensions
{
    public static (DateTime startDate, DateTime endDate) BetweenPeriod(this DateTime date, TimePeriod timePeriod = TimePeriod.Day)
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
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddTicks(-1);
                return (firstDayOfMonth, lastDayOfMonth);
            case TimePeriod.Year:
                var yearStart = new DateTime(date.Year, 1, 1);
                var yearEnd = new DateTime(date.Year, 12, 31);
                return (yearStart, yearEnd);
            default:
                return (date, date);
        }
    }

    public static DateTime ExtractDateOfBirth(this string idNumber)
    {
        if (string.IsNullOrWhiteSpace(idNumber)) return DateTime.Parse("1990-01-01");

        try
        {
            DateTime.TryParseExact(idNumber[..6], "yyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateOfBirth);

            if (dateOfBirth == DateTime.MinValue) return DateTime.Parse("1990-01-01");

            return dateOfBirth;
        }
        catch (Exception)
        {
            return DateTime.Parse("1990-01-01");
        }
    }
}
