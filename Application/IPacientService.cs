using Core.Model;

namespace Application;

public interface IPacientService
{
    Pacient CreatePacient(string name, string cpf, DateTime birthDate);
    bool DeletePacient(string cpf);
    Pacient GetPacient(string cpf);
    IList<Pacient> GetAllPacients();
    Pacient UpdatePacient(Pacient pacient);
}