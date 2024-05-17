using Core.Model;

namespace Application;

public class PacientRecordService
{
    private readonly ICollection<PacientRecord> pacientRecords;

    public PacientRecordService(ICollection<PacientRecord> pacientRecords)
    {
        this.pacientRecords = pacientRecords;
    }

    public PacientRecord CreatePacient(string name, string cpf, DateTime birthDate)
    {
        var pacient = new PacientRecord(name, cpf, birthDate)
        {
            Id = Guid.NewGuid().ToString(),
        };
        pacientRecords.Add(pacient);

        return pacient;
    }

    public void UpdatePacient(string id, PacientRecord pacient)
    {
        var oldPacient = pacientRecords.FirstOrDefault(p => p.Id == id) ?? throw new Exception("Not found");
        pacientRecords.Remove(oldPacient);
        pacientRecords.Add(pacient with { Id = id});
    }

    public PacientRecord GetPacient(string cpf)
    {
        return pacientRecords.FirstOrDefault(p => p.CPF == cpf) ?? throw new Exception("Not found");
    }

    public void DeletePacient(string cpf)
    {
        var pacient = pacientRecords.FirstOrDefault(p => p.CPF == cpf);
        if (pacient is not default(PacientRecord))
        {
            pacientRecords.Remove(pacient);
        }
    }
}
