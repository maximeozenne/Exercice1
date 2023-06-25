namespace Exercice;
public class Hotel
{
    internal readonly Chambre[] _chambres;

	// Le random n'est pas obligé d'être stocké dans la classe,
	// Mais on le fait ici pour pouvoir contrôler ses valeurs et pouvoir écrire des tests unitaires.
	internal readonly Random _random;

	// Le Constructeur de l'Hotel prend en paramètre un nombre de chambres.
	// Il prend aussi un random, pour pouvoir tester la classe. À ignorer.
	public Hotel(int NombreDeChambres, Random random)
	{
		_random = random;
        _chambres = new Chambre[NombreDeChambres];

		for (int i = 0; i < _chambres.Length; i++)
		{
            // On crée une nouvelle chambre avec le Numéro "i", qu'on ajoute directement au tableau de Chambres
            // Les chambres ont le booléen "EstOccupee" à false par défaut. Pas besoin de le préciser ici.
            _chambres[i] = new Chambre()
			{
				Numero = i
			};
		}
	}

	/// <summary>
	/// Cette méthode permet d'occuper une chambre, seulement si elle est libre.
	/// </summary>
	/// <param name="numeroDeChambre">Numéro de la chambre que l'on souhaite occuper.</param>
	/// <returns>true si la chambre était libre et qu'on a pu l'occuper, sinon retourne false.</returns>
	public bool OccuperChambre(int numeroDeChambre)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	/// Cette méthode nous donne la liste complète des chambres libres.
	/// </summary>
	/// <returns>La liste des chambres libres. Si aucune chambre est libre, on renvoie une liste vide.</returns>
	public List<Chambre> DonnerLaListeDesChambresLibres()
	{
        throw new NotImplementedException();
    }

	/// <summary>
	/// Cette méthode occupe aléatoirement les chambres.
	/// Chaque chambre a 50% de chance d'être occupée.
	/// </summary>
	public void OccuperAleatoirementLesChambres()
	{
        throw new NotImplementedException();
    }
}
