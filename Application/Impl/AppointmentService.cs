using Application.API;
using Core.Model;

namespace Application.Impl;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository repository;

    public AppointmentService(IAppointmentRepository repository)
    {
        this.repository = repository;
    }

    public Appointment Create(Appointment appointment, string pacientId)
    {
        return repository.Create(appointment, pacientId) ?? throw new Exception("Appointment creation failed");
    }

    public Appointment Get(string id)
    {
        return repository.Get(id) ?? throw new Exception("Appointment not found"); ;
    }

    public ICollection<Appointment> GetFromPacient(string pacientId)
    {
        return repository.GetFromPacient(pacientId);
    }

    public bool Remove(string id)
    {
        return repository.Remove(id);
    }

    public Appointment Update(Appointment appointment)
    {
        if (string.IsNullOrWhiteSpace(appointment.Id))
        {
            throw new Exception($"Id cannot be empty when updating [{nameof(Appointment)}]");
        }

        return repository.Update(appointment) ?? throw new Exception("Appointment update failed");
    }
}
