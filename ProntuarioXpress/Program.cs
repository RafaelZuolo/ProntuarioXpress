using Application;
using Application.API;
using Application.Impl;
using Core.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence;
using UI.Presenters;

namespace UI;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        HostApplicationBuilder builder = Host.CreateApplicationBuilder();

        builder.Services.AddTransient<IMainForm, MainForm>();
        builder.Services.AddTransient<IPacientForm, PacientForm>();
        builder.Services.AddTransient<IAppointmentForm, AppointmentForm>();
        builder.Services.AddSingleton<IPacientService, PacientService>();
        builder.Services.AddSingleton<IAppointmentService, AppointmentService>();
        builder.Services.AddSingleton<IPacientRepository, PacientRepository>();
        builder.Services.AddSingleton<IAppointmentRepository, AppointmentRepository>();

        using IHost host = builder.Build();

        ServiceProvider = host.Services;

        //var appointmentSeeded = new List<Appointment>
        //{
        //    new(DateTime.Now),
        //    new(DateTime.Now.AddDays(-5)),
        //    new(DateTime.Now.AddHours(-2)),
        //};

        //var pacientSeeded = new HashSet<Pacient>
        //{
        //    new("Fulano de Tal", "01234", DateTime.Today.AddYears(-20))
        //    {
        //        Address = "rua de fulano, 500",
        //        Id = Guid.NewGuid().ToString(),
        //        Appointments = appointmentSeeded.ToArray(),
        //    },
        //    new("Beltrano Beltroso", "54321", DateTime.Today.AddYears(-80))
        //    {
        //        Address = "rua de Beltrano, 600",
        //        Id = Guid.NewGuid().ToString(),
        //        Appointments = appointmentSeeded.ToArray(),
        //    },
        //    new("Ciclano Ciclado", "0001", DateTime.Today.AddYears(-5))
        //    {
        //        Address = "av Ciclano, 8",
        //        Id = Guid.NewGuid().ToString(),
        //        Appointments = appointmentSeeded.ToArray(),
        //    },
        //};

        //var repo = new PacientRepository();
        //foreach (var p in pacientSeeded)
        //{
        //    repo.Upsert(p);
        //}

        var mainPresenter = new MainPresenter(
            ServiceProvider.GetRequiredService<IMainForm>(),
            ServiceProvider.GetRequiredService<IPacientService>());
        System.Windows.Forms.Application.Run((Form)mainPresenter.Form);
    }
}