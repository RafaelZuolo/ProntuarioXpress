using Core.Utils;
using UI.ViewItems;

namespace UI;

public partial class PacientForm : Form
{
    private PacientViewItem pacientViewItem;

    public EventHandler<PacientViewItem>? SaveEvent;
    public EventHandler? ShowExtraInfoEvent;
    public EventHandler<AppointmentViewItem>? OpenAppointmentEvent;
    public EventHandler? NewAppointmentEvent;
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
        UpdatePacientInfo();
        SaveEvent?.Invoke(sender, pacientViewItem);
    }

    internal void InitWith(PacientViewItem pacient)
    {
        pacientViewItem = pacient;
        nameTextBox.Text = pacient.FullName;
        birthdayDateTimePicker.Value = pacient.BirthDate;
        cpfTextBox.Text = pacient.CPF;
        ageTextBox.Text = pacient.BirthDate.GetAge().ToString();
        appointmentsListBox.BeginUpdate();
        appointmentsListBox.Items.Clear();
        foreach (var appointment in pacient.Appointments.OrderByDescending(a => a.Date))
        {
            appointmentsListBox.Items.Add(appointment);
        }
        appointmentsListBox.EndUpdate();
        openAppointMentButton.Enabled = false;
        newAppointmentButton.Enabled = !string.IsNullOrWhiteSpace(pacient.Id);

        saveButton.Text = string.IsNullOrEmpty(pacient.Id) ? "Criar" : "Atualizar";
    }

    private void UpdatePacientInfo()
    {
        pacientViewItem.FullName = nameTextBox.Text;
        pacientViewItem.BirthDate = birthdayDateTimePicker.Value;
        pacientViewItem.CPF = cpfTextBox.Text;
    }

    private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        openAppointMentButton.Enabled = appointmentsListBox.SelectedItem != null;
    }

    private void PacientForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        UpdatePacientInfo();
        CloseEvent?.Invoke(sender, e);
    }

    private void birthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
    {
        ageTextBox.Text = birthdayDateTimePicker.Value.GetAge().ToString();
    }

    private void appointmentsListBox_DoubleClick(object sender, EventArgs e)
    {
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
