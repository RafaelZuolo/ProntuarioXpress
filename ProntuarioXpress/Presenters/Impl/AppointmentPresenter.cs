using Application;
using Core.Model;
using UI.ViewItems;

namespace UI.Presenters;

public class AppointmentPresenter : IAppointmentPresenter
{
    private IAppointmentForm form;
    private readonly IAppointmentService appointmentService;
    private AppointmentViewItem appointment = new();
    private string pacientId = string.Empty;

    public AppointmentPresenter(IAppointmentForm form, IAppointmentService appointmentService)
    {
        this.form = form;
        this.appointmentService = appointmentService;
        form.CloseEvent += CloseEvent;
        form.SaveEvent += SaveEvent;
        form.OpenBillingEvent += OpenBillingEvent;
        form.OpenExtraInfoEvent += OpenBillingEvent;
    }

    public void InitWith(Appointment appointment, string pacientId)
    {
        this.appointment = AppointmentViewItem.FromModel(appointment);
        this.pacientId = pacientId;
        form.AppointmentViewItemBindingSource.DataSource = this.appointment;
    }

    public void Show()
    {
        form.ShowForm();
    }
    public void SaveEvent(object? sender, AppointmentViewItem appointment)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(appointment.Id))
            {
                var createdAppointment = appointmentService.Create(appointment.ToModel(), pacientId) ?? throw new Exception("Appointment save error");
                var createdPacientViewItem = AppointmentViewItem.FromModel(createdAppointment);
                form.InitWith(createdPacientViewItem);
                this.appointment = createdPacientViewItem;
                form.SetStatusStripLabel("Atendimento criado com sucesso");
            }
            else
            {
                appointmentService.Update(appointment.ToModel());
                form.SetStatusStripLabel("Atendimento atualizado com sucesso");
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(
                text: e.Message,
                caption: "Erro ao salvar",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error);
        }
    }

    public void CloseEvent(object? sender, FormClosingEventArgs e)
    {
        var message = $"Deseja salvar antes de fechar esse atendimento?";
        var caption = "Fechar atendimento";
        var result = MessageBox.Show(
            message,
            caption,
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);

        if (result == DialogResult.Cancel)
        {
            e.Cancel = true;
            return;
        }
        if (result == DialogResult.Yes)
        {
            SaveEvent(this, appointment);
        }
    }

    public void OpenExtraInfoEvent(object? sender, EventArgs e)
    {

    }

    public void OpenBillingEvent(object? sender, EventArgs e)
    {
        
    }
}
