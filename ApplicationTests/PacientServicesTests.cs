using Application;
using Application.API;
using AutoFixture;
using Core.Model;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace ApplicationTests;

public class PacientServicesTests
{
    private readonly IFixture fixture;

    public PacientServicesTests()
    {
        fixture = new Fixture();
    }

    [Theory]
#pragma warning disable xUnit1012 // Null should only be used for nullable parameters
    [InlineData(null)]
#pragma warning restore xUnit1012 // Null should only be used for nullable parameters
    [InlineData("")]
    [InlineData("\t")]
    public void UpdatePacient_WithNullOrWhiteSpaceId_ShouldThrowException(string id)
    {
        fixture.Register(() => Substitute.For<IPacientRepository>());
        var pacient = fixture.Build<Pacient>()
            .With(p => p.Id, () => id)
            .Create();
        var service = fixture.Create<PacientService>();

        var action = () => service.UpdatePacient(pacient);

        action.Should().Throw<Exception>()
            .WithMessage($"Id cannot be null when updating {nameof(Pacient)}");
    }
}
