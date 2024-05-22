using UI.ViewItem;

namespace UI;

public partial class PacientForm : Form
{
    private PacientViewItem? pacientViewItem { get; set; }

    public EventHandler<PacientViewItem>? SaveEvent;
    public EventHandler? ShowExtraInfoEvent;
    public EventHandler<AppointmentViewItem>? OpenAppointmentEvent;
    public EventHandler? CloseEvent;

    public PacientForm(PacientViewItem pacientViewItem)
    {
        InitializeComponent();
    }

    private void openAppointmentButton_Click(object sender, EventArgs e)
    {
        OpenAppointmentEvent?.Invoke(sender, pacientViewItem.Appointments[appointmentsListBox.SelectedIndex]);
    }

    private void pacientExtraInfoButton_Click(object sender, EventArgs e)
    {
        ShowExtraInfoEvent?.Invoke(sender, EventArgs.Empty);
    }

    private void closelButton_Click(object sender, EventArgs e)
    {
        CloseEvent?.Invoke(sender, EventArgs.Empty);
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        SaveEvent?.Invoke(sender, pacientViewItem);
    }

    internal void Load(PacientViewItem pacient)
    {
        throw new NotImplementedException();
    }
}
