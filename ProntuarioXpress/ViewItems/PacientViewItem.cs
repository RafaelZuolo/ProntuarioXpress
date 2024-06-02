using Core.Model;
using Core.Utils;
using System.ComponentModel;

namespace UI.ViewItems;

public class PacientViewItem : INotifyPropertyChanged
{
    private DateTime birthDate = DateTime.Today;

    public string FullName { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;

    public DateTime BirthDate
    {
        get => birthDate;
        set
        {
            birthDate = value;
            OnPropertyChanged(nameof(BirthDate));
            OnPropertyChanged(nameof(LongAge));
        }
    }

    public string LongAge => $"{BirthDate.GetYearsFromToday()} anos e {BirthDate.GetMonthsFromToday() % 12} meses";

    public string Id { get; init; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string ComplementaryInfos { get; set; } = string.Empty;

    public string Anamnese { get; set; } = string.Empty;

    public IList<AppointmentViewItem> Appointments { get; init; } = [];

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string property)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }

    public static PacientViewItem FromModel(Pacient pacient)
    {
        return new PacientViewItem
        {
            FullName = pacient.FullName,
            CPF = pacient.Cpf,
            BirthDate = pacient.BirthDate,
            Id = pacient.Id,
            Address = pacient.Address,
            Anamnese = pacient.Anamnese,
            ComplementaryInfos = pacient.ComplementaryInfos,
            Appointments = pacient.Appointments.Select(AppointmentViewItem.FromModel).ToList(),
        };
    }

    internal Pacient ToModel()
    {
        return new Pacient(FullName, CPF, BirthDate)
        {
            Id = Id,
            Address = Address,
            Anamnese = Anamnese,
            ComplementaryInfos = ComplementaryInfos,
            Appointments = Appointments.Select(a => a.ToModel()).ToList(),
        };
    }
}
