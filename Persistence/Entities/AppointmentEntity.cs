using Core.Model;

namespace Persistence.Entities;

internal class AppointmentEntity
{
    public string Id { get; init; } = string.Empty;

    public string PacientId { get; init; } = string.Empty;

    public DateTime Date { get; init; }

    public decimal? AmmountDue { get; set; }

    public bool WasPaid { get; set; }

    public DateTime? PayDay { get; set; }

    public string ExtraInfos { get; set; } = string.Empty;

    public string Occurrences { get; set; } = string.Empty;

    internal Appointment ToModel()
    {
        return new Appointment(Date)
        {
            Id = Id,
            ExtraInfos = ExtraInfos,
            Occurrences = Occurrences,
            Billing = AmmountDue is null
                ? null
                : new Billing(AmmountDue.Value)
                {
                    PayDay = PayDay,
                    WasPaid = WasPaid,
                },
        };
    }

    internal static AppointmentEntity FromModel(Appointment appointment, string pacientId = ""/*EmptyValue*/)
    {
        return new AppointmentEntity
        {
            Id = appointment.Id,
            PacientId = pacientId,
            Date = appointment.Date,
            ExtraInfos = appointment.ExtraInfos,
            Occurrences = appointment.Occurrences,
            AmmountDue = appointment.Billing?.AmmountDue,
            PayDay = appointment.Billing?.PayDay,
            WasPaid = appointment.Billing?.WasPaid ?? false,
        };
    }
}
