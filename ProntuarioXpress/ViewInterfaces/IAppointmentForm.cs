using UI.ViewItems;

namespace UI;

public interface IAppointmentForm
{
    EventHandler<AppointmentViewItem>? SaveEvent { get; set; }
    FormClosingEventHandler? CloseEvent { get; set; }
    EventHandler? OpenExtraInfoEvent { get; set; }
    EventHandler? OpenBillingEvent { get; set; }
    BindingSource AppointmentViewItemBindingSource { get; }

    void ShowForm();

    void InitWith(AppointmentViewItem viewItem);
    void SetStatusStripLabel(string v);
}
