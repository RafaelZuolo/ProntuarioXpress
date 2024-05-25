namespace Core.Utils;

public static class DateTimeExtensions
{
    private const double NumberOfDaysInYear = 365.2425;

    public static int GetAge(this DateTime birthDay) =>
        (int)(DateTime.Today.Subtract(birthDay).TotalDays / NumberOfDaysInYear);
}
