using Application.API;
using Core.Model;

namespace Persistence;

public class PacientRepository : IPacientRepository
{
    private readonly IDictionary<string, Pacient> pacientById = new Dictionary<string, Pacient>();

    public Pacient Get(string id)
    {
        return pacientById[id]; 
    }

    public IList<Pacient> GetAll()
    {
        return pacientById.Values.ToList();
    }

    public bool Remove(string id)
    {
        return pacientById.Remove(id);
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
