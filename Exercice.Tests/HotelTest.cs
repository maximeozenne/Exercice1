using NFluent;
using NSubstitute;
using Xunit;

namespace Exercice.Tests;

public class HotelTest
{
    private readonly int _nombreDeChambre = 10;
    private readonly Random _random;
    private readonly Hotel _sut;

    public HotelTest()
    {
        _random = Substitute.For<Random>();

        _sut = new Hotel(_nombreDeChambre, _random);
    }

    [Fact]
    public void OccuperChambre_WhenAskingForAFreeRoom_ThenReturnTrue()
    {
        var chambresLibres = _sut.DonnerLaListeDesChambresLibres();

        var result = _sut.OccuperChambre(chambresLibres.First().Numero);

        Check.That(result).IsTrue();
    }

    [Fact]
    public void OccuperChambre_WhenAskingForANotFreeRoom_ThenReturnFalse()
    {
        var chambresLibres = _sut.DonnerLaListeDesChambresLibres();

        var wantedRoom = chambresLibres.First().Numero;
        _sut.OccuperChambre(wantedRoom);

        var result = _sut.OccuperChambre(wantedRoom);

        Check.That(result).IsFalse();
    }

    [Fact]
    public void DonnerLaListeDesChambresLibres_WhenAskingForFreeRooms_ThenReturnOnlyFreeRooms()
    {
        var wantedRoom = _sut._chambres.First();
        var otherRoom = _sut._chambres.Last();

        _sut.OccuperChambre(wantedRoom.Numero);

        var chambresLibres = _sut.DonnerLaListeDesChambresLibres();

        Check.That(chambresLibres.Count).IsEqualTo(_sut._chambres.Length - 1);
        Check.That(chambresLibres.Contains(otherRoom)).IsTrue();
        Check.That(chambresLibres.Contains(wantedRoom)).IsFalse();
    }

    [Fact]
    public void OccuperAleatoirementLesChambres_WhenRandomReturnsMoreThan50PerCent_ThenAllRoomsShouldGetOccupied()
    {
        _random.Next(101).ReturnsForAnyArgs(51);
        _random.Next(0, 101).ReturnsForAnyArgs(51);
        _random.NextDouble().ReturnsForAnyArgs(0.51);

        _sut.OccuperAleatoirementLesChambres();

        var chambresLibres = _sut.DonnerLaListeDesChambresLibres();

        Check.That(chambresLibres.Count).IsEqualTo(0);
    }

    [Fact]
    public void OccuperAleatoirementLesChambres_WhenRandomReturnsLessThan50PerCent_ThenNoRoomsShouldGetOccupied()
    {
        _random.Next(101).ReturnsForAnyArgs(1);
        _random.Next(0, 101).ReturnsForAnyArgs(1);
        _random.NextDouble().ReturnsForAnyArgs(0.1);

        _sut.OccuperAleatoirementLesChambres();

        var chambresLibres = _sut.DonnerLaListeDesChambresLibres();

        Check.That(chambresLibres.Count).IsEqualTo(_sut._chambres.Length);
    }
}
