namespace Core.Model;

public record Appointment(DateTime Date)
{
    public string Id { get; init; } = string.Empty;

    public Billing? Billing { get; set; }

    public string ExtraInfos { get; set; } = string.Empty;

    public bool WasBilled { get => Billing is not null; }

    public bool WasPaid { get => Billing?.WasPaid ?? false; }
}