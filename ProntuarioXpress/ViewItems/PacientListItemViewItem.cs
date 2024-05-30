using Core.Model;
using Core.Utils;

namespace UI.ViewItems;

public class PacientListItemViewItem(string id, string name, string cpf, int age)
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string Cpf { get; } = cpf;
    public int Age { get; } = age;

    public override string? ToString()
    {
        return $"{Name} --- {Age} anos";
    }

    public static PacientListItemViewItem FromPacient(Pacient pacient)
    {
        return new PacientListItemViewItem(pacient.Id, pacient.FullName, pacient.CPF, pacient.BirthDate.GetYearsFromToday());
    }
}
