using Core.Model;

namespace Application
{
    public interface IPacientService
    {
        Pacient CreatePacient(string name, string cpf, DateTime birthDate);
        void DeletePacient(string cpf);
        Pacient GetPacient(string cpf);
        IList<Pacient> SearchPacient();
        void UpdatePacient(string id, Pacient pacient);
    }
}