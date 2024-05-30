using UI.ViewItems;

namespace UI;

public partial class PacientForm : Form
{
    private PacientViewItem pacientViewItem => pacientViewItemBindingSource.DataSource as PacientViewItem 
        ?? throw new Exception("viewItem was null");

    public EventHandler<PacientViewItem>? SaveEvent;
    public EventHandler? ShowExtraInfoEvent;
    public EventHandler<AppointmentViewItem>? OpenAppointmentEvent;
    public EventHandler? NewAppointmentEvent;
    public FormClosingEventHandler? CloseEvent;

    public BindingSource PacientViewItemBindingSource => pacientViewItemBindingSource;

    public PacientForm()
    {
        InitializeComponent();
        pacientViewItemBindingSource.DataSource = new();
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
        Close();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        SaveEvent?.Invoke(sender, pacientViewItem);
    }

    internal void InitWith(PacientViewItem pacient)
    {
        pacientViewItemBindingSource.DataSource = pacient;
        appointmentsListBox.DataSource = pacient.Appointments;
        openAppointMentButton.Enabled = false;
        newAppointmentButton.Enabled = !string.IsNullOrWhiteSpace(pacient.Id);

        saveButton.Text = string.IsNullOrEmpty(pacient.Id) ? "Criar" : "Atualizar";
    }

    private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        openAppointMentButton.Enabled = appointmentsListBox.SelectedItem != null;
    }

    private void PacientForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        //UpdatePacientInfo();
        CloseEvent?.Invoke(sender, e);
    }

    private void appointmentsListBox_DoubleClick(object sender, EventArgs e)
    {
        if (appointmentsListBox.SelectedIndex < 0) return;
        OpenAppointmentEvent?.Invoke(sender, pacientViewItem.Appointments[appointmentsListBox.SelectedIndex]);
    }

    public void SetStatusStripLabel(string text)
    {
        toolStripStatusLabel.Text = text;
    }

    private void newAppointmentBtton_Click(object sender, EventArgs e)
    {
        NewAppointmentEvent?.Invoke(sender, e);
    }
}
