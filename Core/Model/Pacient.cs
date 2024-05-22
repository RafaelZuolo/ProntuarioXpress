namespace Core.Model;

public record Pacient(string FullName, string CPF, DateTime BirthDate)
{
    public string Id { get; init; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string ComplementaryInfos { get; set; } = string.Empty;

    public string Anamnese { get; set; } = string.Empty;

    public IList<Appointment> Appointments { get; } = [];

    public override string? ToString()
    {
        return FullName;
    }

    public void AddAppointment(Appointment appointment)
    {
        Appointments.Add(appointment);
    }

    public void DeleteAppointment(Appointment appointment)
    {
        Appointments.Remove(appointment);
    }
}
