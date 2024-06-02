namespace Core.Utils;

public static class DateTimeExtensions
{
    private const double NumberOfDaysInYear = 365.2425;
    private const double NumberOfDaysInMonth = 30.4167;

    public static int GetYearsFromToday(this DateTime birthDay) =>
        (int)(DateTime.Today.Subtract(birthDay).TotalDays / NumberOfDaysInYear);

    public static int GetMonthsFromToday(this DateTime birthDay) =>
        (int)(DateTime.Today.Subtract(birthDay).TotalDays / NumberOfDaysInMonth);
}