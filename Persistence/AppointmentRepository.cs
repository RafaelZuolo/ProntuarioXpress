using Application.API;
using Core.Model;
using Persistence.Entities;

namespace Persistence;
internal class AppointmentRepository : IAppointmentRepository
{
    private readonly IDictionary<string, AppointmentEntity> appointmentById
        = new Dictionary<string, AppointmentEntity>();

    public Appointment? Create(Appointment appointment, string pacientId)
    {
        appointmentById.Add(appointment.Id, AppointmentEntity.FromModel(appointment, pacientId));

        return Get(appointment.Id);
    }

    public Appointment? Get(string id)
    {
        return appointmentById[id]?.ToModel();
    }

    public ICollection<Appointment> GetFromPacient(string pacientId)
    {
        return appointmentById.Values
            .Where(a => a.PacientId == pacientId)
            .Select(a => a.ToModel())
            .ToList();
    }

    public bool Remove(string id)
    {
        return appointmentById.Remove(id);
    }

    public Appointment? Update(Appointment appointment)
    {
        var pacientId = appointmentById[appointment.Id].PacientId;
        appointmentById[appointment.Id] = AppointmentEntity.FromModel(appointment, pacientId);

        return Get(appointment.Id);
    }
}
