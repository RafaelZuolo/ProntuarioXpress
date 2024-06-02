using UI.ViewItems;

namespace UI;

public partial class AppointmentForm : Form, IAppointmentForm
{
    public EventHandler<AppointmentViewItem>? SaveEvent { get; set; }
    public FormClosingEventHandler? CloseEvent { get; set; }
    public EventHandler? OpenExtraInfoEvent { get; set; }
    public EventHandler? OpenBillingEvent { get; set; }

    public AppointmentForm()
    {
        InitializeComponent();
    }

    public void ShowForm()
    {
        Show();
    }

    private void AppointmentForm_Load(object sender, EventArgs e)
    {

    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        CloseEvent?.Invoke(sender, new FormClosingEventArgs(CloseReason.UserClosing, cancel: false));
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        var appointment = appointmentViewItemBindingSource.DataSource as AppointmentViewItem
            ?? throw new Exception("Got null appointmentViewItem");
        SaveEvent?.Invoke(sender, appointment);
    }

    private void appointmentExtraInfoButton_Click(object sender, EventArgs e)
    {
        OpenExtraInfoEvent?.Invoke(sender, e);
    }

    private void billingButton_Click(object sender, EventArgs e)
    {
        OpenBillingEvent?.Invoke(sender, e);
    }
}
