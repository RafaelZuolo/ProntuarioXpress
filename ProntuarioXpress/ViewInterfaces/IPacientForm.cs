using UI.ViewItems;

namespace UI;

public interface IPacientForm
{
    FormClosingEventHandler? CloseEvent { get; set; }
    EventHandler? NewAppointmentEvent { get; set; }
    EventHandler<AppointmentViewItem>? OpenAppointmentEvent { get; set; }
    EventHandler<PacientViewItem>? SaveEvent { get; set; }
    EventHandler? ShowExtraInfoEvent { get; set; }
    EventHandler? ExportAppointmentsEvent { get; set; }

    void InitWith(PacientViewItem pacient);
    void SetStatusStripLabel(string text);
    void ShowForm();
}