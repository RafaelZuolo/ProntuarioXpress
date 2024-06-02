using Core.Model;

namespace Application.API;

public interface IAppointmentRepository
{
    Appointment? Get(string id);
    ICollection<Appointment> GetFromPacient(string pacientId);
    Appointment? Create(Appointment appointment, string pacientId);
    Appointment? Update(Appointment appointment);
    bool Remove(string id);
}
