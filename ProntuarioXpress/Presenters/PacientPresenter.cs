using Application;
using Core.Model;
using UI.ViewItems;

namespace UI.Presenters;

public class PacientPresenter
{
    private PacientForm form;
    private PacientViewItem pacient = new();
    private readonly IPacientService pacientService;
    public EventHandler? OnClose;

    public PacientPresenter(PacientForm form, IPacientService pacientService)
    {
        this.form = form;
        this.pacientService = pacientService;
        this.form.SaveEvent += SaveEvent;
        this.form.CloseEvent += CloseEvent;
        this.form.OpenAppointmentEvent += OpenAppointmentEvent;
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
                MessageBox.Show(
                    text: "Paciente criado com sucesso",
                    caption: "Salvar",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);
            }
            else
            {
                pacientService.UpdatePacient(pacient.Id, pacient.ToModel());
                MessageBox.Show(
                    text: "Paciente atualizado com sucesso",
                    caption: "Salvar",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);
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

    }

    public void ShowExtraInfoEvent(object? sender, EventArgs e)
    {
    }

    internal void Show()
    {
        form.Show();
    }
}
