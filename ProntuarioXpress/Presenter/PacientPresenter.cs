using Core.Model;
using UI.ViewItem;

namespace UI.Presenter;

public class PacientPresenter
{
    private PacientForm form;
    private PacientViewItem pacient;

    public PacientPresenter(PacientForm form)
    {
        this.form = form;
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

        if (result == DialogResult.Yes)
        {
            SaveEvent(this, pacient);
        }
        else if (result == DialogResult.Cancel)
        {
            e.Cancel = true;
            return;
        }
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
