namespace Core.Model;

public record PacientRecord(string FullName, string CPF, DateTime BirthDate)
{
    public string Id { get; init; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string ComplementaryInfos { get; set; } = string.Empty;

    public string Anamnese { get; set; } = string.Empty;

    public IList<Appointment> Appointment { get; } = [];
}
