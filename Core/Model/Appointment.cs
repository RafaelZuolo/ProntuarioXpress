namespace Core.Model;

public class Appointment(DateTime date)
{
    public DateTime Date { get; } = date;

    public Billing? Billing { get; set; }

    public string ExtraInfos { get; set; } = string.Empty;
}