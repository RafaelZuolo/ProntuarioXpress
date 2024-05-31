using UI.ViewItems;

namespace UI;

public interface IMainForm
{
    EventHandler? CreatePacientEvent { get; set; }
    EventHandler<string>? RetrievePacientEvent { get; set; }
    EventHandler<string>? DeletePacientEvent { get; set; }
    EventHandler? MainFormLoadEvent { get; set; }

    void LoadPacientList(ICollection<PacientListItemViewItem> pacients);
    void SetEnabled(bool enabled);
}