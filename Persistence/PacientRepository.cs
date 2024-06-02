using Application.API;
using Core.Model;

namespace Persistence;

public class PacientRepository : IPacientRepository
{
    private readonly IDictionary<string, Pacient> pacientById = new Dictionary<string, Pacient>();

    private readonly IAppointmentRepository appointmentRepository;

    public PacientRepository(IAppointmentRepository appointmentRepository)
    {
        this.appointmentRepository = appointmentRepository;
    }

    public Pacient Get(string id)
    {
        var pacient = pacientById[id] ?? throw new Exception("Pacient Not found");
        var appointments = appointmentRepository.GetFromPacient(id);

        return pacient with { Appointments = appointments};
    }

    public IList<Pacient> GetAll() // missleading because we do not enrich it
    {
        return pacientById.Values.ToList();
    }

    public bool Remove(string id)
    {
        var removedAllAppointments = appointmentRepository.RemoveFromPacient(id);
        var removedPacient = pacientById.Remove(id);

        return removedPacient && removedAllAppointments;
    }

    public Pacient Upsert(Pacient pacient)
    {
        var id = pacient.Id;
        if (pacientById.ContainsKey(id))
        {
            pacientById[pacient.Id] = pacient with { };
        }
        else
        {
            id = Guid.NewGuid().ToString();
            pacientById.Add(id, pacient with { Id = id });
        }

        return Get(id);
    }
}
