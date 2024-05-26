using Application;
using Core.Model;
using UI.ViewItems;

namespace UI.Presenters;

public class MainPresenter
{
    private readonly MainForm mainForm;
    private readonly IPacientService pacientService;
    public Form Form => mainForm;

    public MainPresenter(MainForm mainForm, IPacientService pacientService)
    {
        this.mainForm = mainForm;
        this.pacientService = pacientService;
        this.mainForm.CreatePacientEvent += CreatePacientEvent;
        this.mainForm.RetrievePacientEvent += RetrievePacientEvent;
        this.mainForm.DeletePacientEvent += DeletePacientEvent;
        this.mainForm.MainFormLoadEvent += MainFormLoadEvent;
    }

    private void CreatePacientEvent(object? sender, EventArgs e)
    {
        var pacientForm = new PacientForm();
        var pacientPresenter = new PacientPresenter(pacientForm, pacientService);
        pacientPresenter.OnClose += MainFormLoadEvent;
        pacientPresenter.InitWith(new Pacient(string.Empty, string.Empty, DateTime.Today));
        pacientPresenter.Show();
    }

    private void RetrievePacientEvent(object? sender, string id)
    {
        var pacientForm = new PacientForm();
        var pacientPresenter = new PacientPresenter(pacientForm, pacientService);
        pacientPresenter.OnClose += MainFormLoadEvent;

        var pacient = pacientService.GetPacient(id);
        pacientPresenter.InitWith(pacient);
        pacientPresenter.Show();
    }

    private void DeletePacientEvent(object? sender, string id)
    {

    }

    private void MainFormLoadEvent(object? sender, EventArgs e)
    {
        mainForm.LoadPacientList(pacientService
            .SearchPacients()
            .Select(PacientListItemViewItem.FromPacient)
            .ToList());
    }
}
