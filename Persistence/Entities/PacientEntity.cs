using Core.Model;

namespace Persistence.Entities;

internal class PacientEntity
{
    public string Id { get; init; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public string Cpf { get; set; } = string.Empty;

    public DateTime BirthDate { get; set; }

    public string Address { get; set; } = string.Empty;

    public string ComplementaryInfos { get; set; } = string.Empty;

    public string Anamnese { get; set; } = string.Empty;

    public IList<AppointmentEntity> Appointments { get; init; } = [];

    public static Pacient ToModel(PacientEntity entity) => new(
        entity.FullName,
        entity.Cpf,
        entity.BirthDate)
    {
        Id = entity.Id,
        Address = entity.Address,
        Anamnese = entity.Anamnese,
        ComplementaryInfos = entity.ComplementaryInfos,
        Appointments = entity.Appointments.Select(AppointmentEntity.ToModel).ToList(),
    };

    public static PacientEntity FromModel(Pacient pacient) => new()
    {
        Id = pacient.Id,
        FullName = pacient.FullName,
        Cpf = pacient.Cpf,
        BirthDate = pacient.BirthDate,
        Address = pacient.Address,
        Anamnese = pacient.Anamnese,
        ComplementaryInfos = pacient.ComplementaryInfos,
        Appointments = pacient.Appointments.Select(a => AppointmentEntity.FromModel(a, pacient.Id)).ToList(),
    };

}
