using Core.Utils;
using UI.ViewItem;

namespace UI;

public partial class PacientForm : Form
{
    private PacientViewItem pacientViewItem;

    public EventHandler<PacientViewItem>? SaveEvent;
    public EventHandler? ShowExtraInfoEvent;
    public EventHandler<AppointmentViewItem>? OpenAppointmentEvent;
    public FormClosingEventHandler? CloseEvent;

    public PacientForm()
    {
        InitializeComponent();
        pacientViewItem = new();
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
        pacientViewItem = pacient;
        nameTextBox.Text = pacient.FullName;
        birthDaydateTimePicker.Value = pacient.BirthDate;
        cpfTextBox.Text = pacient.CPF;
        ageTextBox.Text = pacient.BirthDate.GetAge().ToString();
        appointmentsListBox.BeginUpdate();
        appointmentsListBox.Items.Clear();
        foreach (var appointment in pacient.Appointments)
        {
            appointmentsListBox.Items.Add(appointment);
        }
        appointmentsListBox.EndUpdate();
        openAppointMentButton.Enabled = false;
    }

    private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        openAppointMentButton.Enabled = appointmentsListBox.SelectedItem != null;
    }

    private void PacientForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        CloseEvent?.Invoke(sender, e);
    }
}
