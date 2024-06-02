using Application.API;
using Core.Model;

namespace Application;

public class PacientService(IPacientRepository repository) : IPacientService
{
    public Pacient CreatePacient(string name, string cpf, DateTime birthDate)
    {
        return repository.Upsert(new Pacient(name, cpf, birthDate));
    }

    public Pacient UpdatePacient(Pacient pacient)
    {
        if (string.IsNullOrWhiteSpace(pacient.Id)) throw new Exception($"Id cannot be null when updating {nameof(Pacient)}");

        return repository.Upsert(pacient);
    }

    public Pacient GetPacient(string id)
    {
        return repository.Get(id);
    }

    public bool DeletePacient(string id)
    {
        return repository.Remove(id);
    }

    public IList<Pacient> GetAllPacients()
    {
        return repository.GetAll();
    }
}
