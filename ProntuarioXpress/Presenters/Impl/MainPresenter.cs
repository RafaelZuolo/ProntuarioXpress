using Application;
using Core.Model;
using UI.ViewItems;

namespace UI.Presenters;

public class MainPresenter : IMainPresenter
{
    private readonly IMainForm mainForm;
    private readonly IPacientService pacientService;
    public IMainForm Form => mainForm;

    public MainPresenter(IMainForm mainForm, IPacientService pacientService)
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
        var pacientForm = Program.ServiceProvider.GetService(typeof(IPacientForm)) as IPacientForm
            ?? throw new Exception("form was null");
        var pacientPresenter = new PacientPresenter(pacientForm, pacientService);
        pacientPresenter.OnClose += MainFormLoadEvent;
        pacientPresenter.InitWith(new Pacient(string.Empty, string.Empty, DateTime.Today));
        pacientPresenter.Show();
        mainForm.SetEnabled(false);
    }

    private void RetrievePacientEvent(object? sender, string id)
    {
        var pacientForm = new PacientForm();
        var pacientPresenter = new PacientPresenter(pacientForm, pacientService);
        pacientPresenter.OnClose += MainFormLoadEvent;

        var pacient = pacientService.GetPacient(id);
        pacientPresenter.InitWith(pacient);
        pacientPresenter.Show();
        mainForm.SetEnabled(false);
    }

    private void DeletePacientEvent(object? sender, string id)
    {
        pacientService.DeletePacient(id);
        MainFormLoadEvent(this, EventArgs.Empty);
    }

    private void MainFormLoadEvent(object? sender, EventArgs e)
    {
        mainForm.LoadPacientList(pacientService
            .GetAllPacients()
            .Select(PacientListItemViewItem.FromPacient)
            .ToList());
        mainForm.SetEnabled(true);
    }
}
