namespace Core.Model;

public class Billing(decimal ammountDue)
{
    public decimal AmmountDue { get; set; } = ammountDue;

    public bool WasPaid { get; set; }

    public DateTime? PayDay { get; set; }
}