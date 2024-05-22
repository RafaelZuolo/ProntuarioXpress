﻿using Core.Model;

namespace Application;

public class PacientService(ICollection<Pacient> pacientRecords) : IPacientService
{
    private readonly ICollection<Pacient> pacientRecords = pacientRecords;

    public Pacient CreatePacient(string name, string cpf, DateTime birthDate)
    {
        var pacient = new Pacient(name, cpf, birthDate)
        {
            Id = Guid.NewGuid().ToString(),
        };
        pacientRecords.Add(pacient);

        return pacient;
    }

    public void UpdatePacient(string id, Pacient pacient)
    {
        var oldPacient = pacientRecords.FirstOrDefault(p => p.Id == id) ?? throw new Exception("Not found");
        pacientRecords.Remove(oldPacient);
        pacientRecords.Add(pacient with { Id = id });
    }

    public Pacient GetPacient(string cpf)
    {
        return pacientRecords.FirstOrDefault(p => p.CPF == cpf) ?? throw new Exception("Not found");
    }

    public void DeletePacient(string cpf)
    {
        var pacient = pacientRecords.FirstOrDefault(p => p.CPF == cpf);
        if (pacient is not default(Pacient))
        {
            pacientRecords.Remove(pacient);
        }
    }

    public IList<Pacient> SearchPacient()
    {
        return pacientRecords.ToList();
    }
}