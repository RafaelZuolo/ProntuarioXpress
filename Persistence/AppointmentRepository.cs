using Application.API;
using Core.Model;
using Persistence.Entities;

namespace Persistence;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly IDictionary<string, AppointmentEntity> appointmentById
        = new Dictionary<string, AppointmentEntity>();

    public Appointment? Create(Appointment appointment, string pacientId)
    {
        appointmentById.Add(appointment.Id, AppointmentEntity.FromModel(appointment, pacientId));

        return Get(appointment.Id);
    }

    public Appointment? Get(string id) => AppointmentEntity.ToModel(appointmentById[id]);

    public IList<Appointment> GetFromPacient(string pacientId) => appointmentById.Values
        .Where(a => a.PacientId == pacientId)
        .Select(AppointmentEntity.ToModel)
        .ToList();

    public bool Remove(string id) => appointmentById.Remove(id);

    public bool RemoveFromPacient(string pacientId)
    {
        var appointmentIdsToRemove = appointmentById.Values
            .Where(a => a.PacientId == pacientId)
            .Select(a => a.Id);

        var removedAll = true;
        foreach (var id in appointmentIdsToRemove)
        {
            removedAll = removedAll && appointmentById.Remove(id);
        }

        return removedAll;
    }

    public Appointment? Update(Appointment appointment)
    {
        var pacientId = appointmentById[appointment.Id].PacientId;
        appointmentById[appointment.Id] = AppointmentEntity.FromModel(appointment, pacientId);

        return Get(appointment.Id);
    }
}
