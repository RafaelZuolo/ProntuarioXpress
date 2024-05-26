using Application;
using Core.Model;
using UI.Presenters;

namespace UI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var appointmentSeeded = new List<Appointment>
        {
            new(DateTime.Now),
            new(DateTime.Now.AddDays(-5)),
            new(DateTime.Now.AddHours(-2)),
        };

        var pacientSeeded = new HashSet<Pacient>
        {
            new("Fulano de Tal", "01234", DateTime.Today.AddYears(-20))
            {
                Address = "rua de fulano, 500",
                Id = Guid.NewGuid().ToString(),
                Appointments = appointmentSeeded.ToArray(),
            },
            new("Beltrano Beltroso", "54321", DateTime.Today.AddYears(-80))
            {
                Address = "rua de Beltrano, 600",
                Id = Guid.NewGuid().ToString(),
                Appointments = appointmentSeeded.ToArray(),
            },
            new("Ciclano Ciclado", "0001", DateTime.Today.AddYears(-5))
            {
                Address = "av Ciclano, 8",
                Id = Guid.NewGuid().ToString(),
                Appointments = appointmentSeeded.ToArray(),
            },
        };
        var mainForm = new MainForm();
        var mainPresenter = new MainPresenter(mainForm, new PacientService(pacientSeeded));
        System.Windows.Forms.Application.Run(mainPresenter.Form);
    }
}