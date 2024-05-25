using Core.Model;

namespace UI.ViewItem;

public class AppointmentViewItem
{
    public string Id { get; init; } = string.Empty;

    public DateTime Date { get; set; }

    public decimal? AmmountDue { get; set; }

    public DateTime? PayDay { get; set; }

    public bool WasBilled { get; set; }

    public bool WasPaid { get; set; }

    public override string? ToString()
    {
        return $"{Date} {Date.DayOfWeek}";
    }

    public static AppointmentViewItem FromModel(Appointment appointment)
    {
        return new AppointmentViewItem
        {
            Id = appointment.Id,
            Date = appointment.Date,
            AmmountDue = appointment.Billing?.AmmountDue,
            PayDay = appointment.Billing?.PayDay,
            WasBilled = appointment.WasBilled,
            WasPaid = appointment.WasPaid,
        };
    }
}
