using Core.Model;

namespace Application;

public interface IAppointmentService
{
    Appointment Get(string id);
    ICollection<Appointment> GetFromPacient(string pacientId);
    Appointment Create(Appointment appointment, string pacientId);
    Appointment Update(Appointment appointment);
    bool Remove(string id);
}
