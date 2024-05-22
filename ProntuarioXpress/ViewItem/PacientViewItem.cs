using Core.Model;

namespace UI.ViewItem;

public class PacientViewItem
{
    public string FullName { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;

    public DateTime BirthDate { get; set; } = new();

    public string Id { get; init; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string ComplementaryInfos { get; set; } = string.Empty;

    public string Anamnese { get; set; } = string.Empty;

    public IList<AppointmentViewItem> Appointments { get; } = [];

    public static PacientViewItem FromModel(Pacient pacient)
    {
        return new PacientViewItem
        {
            FullName = pacient.FullName,
            CPF = pacient.CPF,
            BirthDate = pacient.BirthDate,
            Id = pacient.Id,
            Address = pacient.Address,
            Anamnese = pacient.Anamnese,
            ComplementaryInfos = pacient.ComplementaryInfos,
        };
    }
}
