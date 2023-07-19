namespace Optimal;
public class Hotel
{
    internal readonly Chambre[] _chambres;
	internal readonly Random _random;
	public Hotel(int NombreDeChambres, Random random)
	{
		_random = random;
		_chambres = Enumerable.Range(0, NombreDeChambres).Select(i => new Chambre() { Numero = i }).ToArray();
	}
	public bool OccuperChambre(int numeroDeChambre) => !_chambres[numeroDeChambre].EstOccupee && (_chambres[numeroDeChambre].EstOccupee = true);
	public List<Chambre> DonnerLaListeDesChambresLibres() => _chambres.Where(chambre => !chambre.EstOccupee).ToList();
    public void OccuperAleatoirementLesChambres() => _chambres.ToList().ForEach(chambre => chambre.EstOccupee = _random.Next(101) >= 50);
}