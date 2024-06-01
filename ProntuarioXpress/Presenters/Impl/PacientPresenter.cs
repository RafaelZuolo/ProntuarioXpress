using Application;
using Core.Model;
using UI.ViewItems;

namespace UI.Presenters;

public class PacientPresenter : IPacientPresenter
{
    private readonly IPacientForm form;
    private PacientViewItem pacient = new();
    private readonly IPacientService pacientService;
    public EventHandler? OnClose;

    public PacientPresenter(IPacientForm form, IPacientService pacientService)
    {
        this.form = form;
        this.pacientService = pacientService;
        this.form.SaveEvent += SaveEvent;
        this.form.CloseEvent += CloseEvent;
        this.form.OpenAppointmentEvent += OpenAppointmentEvent;
        this.form.NewAppointmentEvent += NewAppointmentEvent;
        this.form.ShowExtraInfoEvent += ShowExtraInfoEvent;
    }

    public void InitWith(Pacient pacient)
    {
        this.pacient = PacientViewItem.FromModel(pacient);
        form.InitWith(this.pacient);
    }

    public void SaveEvent(object? sender, PacientViewItem pacient)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(pacient.Id))
            {
                var createdPacient = pacientService.CreatePacient(pacient.FullName, pacient.CPF, pacient.BirthDate);
                var createdPacientViewItem = PacientViewItem.FromModel(createdPacient);
                form.InitWith(createdPacientViewItem);
                this.pacient = createdPacientViewItem;
                form.SetStatusStripLabel("Paciente criado com sucesso");
            }
            else
            {
                pacientService.UpdatePacient(pacient.ToModel());
                form.SetStatusStripLabel("Paciente atualizado com sucesso");
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
        var message = $"Deseja salvar antes de fechar esse paciente?";
        var caption = "Fechar paciente";
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
            SaveEvent(this, pacient);
        }
        OnClose?.Invoke(sender, e);
    }

    public void OpenAppointmentEvent(object? sender, AppointmentViewItem appointment)
    {
        var appointmentPresenter = new AppointmentPresenter(new AppointmentForm());
        appointmentPresenter.Show();
    }

    public void NewAppointmentEvent(object? sender, EventArgs e)
    {
        var appointmentPresenter = new AppointmentPresenter(new AppointmentForm());
        appointmentPresenter.Show();
    }

    public void ShowExtraInfoEvent(object? sender, EventArgs e)
    {
    }

    internal void Show()
    {
        form.ShowForm();
    }
}
