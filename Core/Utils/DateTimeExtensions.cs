namespace Core.Utils;

public static class DateTimeExtensions
{
    private const double NumberOfDaysInYear = 365.2425;

    public static int GetYearsFromToday(this DateTime birthDay) =>
        (int)(DateTime.Today.Subtract(birthDay).TotalDays / NumberOfDaysInYear);

    public static int GetMonthsFromToday(this DateTime birthDay) =>
        (int)(DateTime.Today.Subtract(birthDay).TotalDays / NumberOfDaysInYear);
}
