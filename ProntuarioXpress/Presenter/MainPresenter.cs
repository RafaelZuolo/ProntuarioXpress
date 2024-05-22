using Application;

namespace UI.Presenter;

public class MainPresenter
{
    private MainForm mainForm;
    private readonly IPacientService pacientService;

    public MainPresenter(MainForm mainForm, IPacientService pacientService)
    {
        this.mainForm = mainForm;
        this.pacientService = pacientService;
    }

    private void createPacientButton_Click(object? sender, EventArgs e)
    {

    }

    private void retrievePacientButton_Click(object? sender, EventArgs e)
    {

    }

    private void deletePacientButton_Click(object? sender, EventArgs e)
    {

    }
}
