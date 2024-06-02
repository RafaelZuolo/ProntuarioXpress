using Core.Model;
using Core.Utils;

namespace UI.ViewItems;

public class PacientListItemViewItem()
{
    public string Id { get; init; }
    public string Name { get; init; }
    public string Cpf { get; init; }
    public int Age { get; init; }
    public int AgeMonths { get; init; }

    public override string? ToString()
    {
        return $"{Name} --- {Age} anos e {AgeMonths} meses";
    }

    public static PacientListItemViewItem FromPacient(Pacient pacient)
    {
        return new PacientListItemViewItem
        {
            Id = pacient.Id,
            Name = pacient.FullName,
            Cpf = pacient.Cpf,
            Age = pacient.BirthDate.GetYearsFromToday(),
            AgeMonths = pacient.BirthDate.GetMonthsFromToday() % 12,
        };
    }
}
