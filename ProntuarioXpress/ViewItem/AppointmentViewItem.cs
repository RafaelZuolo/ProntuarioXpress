namespace UI.ViewItem;

public class AppointmentViewItem
{
    public string Id { get; init; } = string.Empty;

    public DateTime Date { get; set; }

    public decimal? AmmountDue { get; set; }

    public DateTime? PayDay { get; set; }

    public bool WasBilled { get; set; }

    public bool WasPaid { get; set; }
}
