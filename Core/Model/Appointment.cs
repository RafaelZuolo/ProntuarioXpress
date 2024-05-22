namespace Core.Model;

public record Appointment(DateTime date)
{
    public string Id { get; init; } = string.Empty;

    public DateTime Date { get; } = date;

    public Billing? Billing { get; set; }

    public string ExtraInfos { get; set; } = string.Empty;

    public bool WasBilled { get => Billing is not null; }

    public bool WasPaid { get => Billing?.WasPaid ?? false; }
}