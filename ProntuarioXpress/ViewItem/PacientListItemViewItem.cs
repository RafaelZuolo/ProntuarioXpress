using Core.Model;

namespace UI.ViewItem;

public class PacientListItemViewItem(string id, string name, string cpf)
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string Cpf { get; } = cpf;

    public override string? ToString()
    {
        return $"{Name}, cpf: {Cpf}";
    }

    public static PacientListItemViewItem FromPacient(Pacient pacient)
    {
        return new PacientListItemViewItem(pacient.Id, pacient.FullName, pacient.CPF);
    }
}
