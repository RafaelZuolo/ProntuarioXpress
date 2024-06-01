using Core.Model;

namespace Application.API;

public interface IPacientRepository
{
    Pacient Upsert(Pacient pacient);
    bool Remove(string id);
    Pacient Get(string id);
    IList<Pacient> GetAll();
}
