namespace Exercice;

internal class Program
{
    static void Main(string[] args)
    {
        // Initialisation

        // On crée l'hotel de 10 chambres, et on occupe les chambres aléatoirement.
        int nombreDeChambres = 10;
        Random random = new Random();
        Hotel hotel = new Hotel(nombreDeChambres, random);
        hotel.OccuperAleatoirementLesChambres();
        

        // Début du dialogue
        ReceptionnisteDit("Bonjour ! Comment puis-je vous aider aujourd'hui ?");
        ClientDit("Bonjour, je souhaiterais prendre une chambre chez vous. En avez-vous de disponible ?");

        // On transforme la liste des chambres libres en string
        List<Chambre> chambresLibres = hotel.DonnerLaListeDesChambresLibres();
        string listeDesChambresLibres = "";

        foreach (var chambreLibre in chambresLibres)
        {
            listeDesChambresLibres += $"{chambreLibre.Numero}, ";
        }
        // On retire la dernière virgule par soucis du détail
        listeDesChambresLibres = listeDesChambresLibres.Substring(0, listeDesChambresLibres.Length - 2);

        if (chambresLibres.Count > 0)
        {
            ReceptionnisteDit($"Bien sûr, voici la liste des chambres disponibles : {listeDesChambresLibres}");

            int chambreVoulue = -1; 
            bool estDisponible = false;

            while (!estDisponible)
            {
                // On simule le fait que le client est relou, et est capable de demander une chambre déjà occupée.
                // Le client prend donc une chambre aléatoire dans toutes celles de l'hotel, sans prendre en compte
                // Que le réceptionniste lui a déjà donné la liste des chambres disponibles.
                chambreVoulue = random.Next(nombreDeChambres);

                ClientDit($"Je souhaiterais la chambre {chambreVoulue} s'il vous plaît.");

                estDisponible = hotel.OccuperChambre(chambreVoulue);

                if (!estDisponible)
                {
                    ReceptionnisteDit($"Je suis désolé, la chambre {chambreVoulue} n'est pas disponible.");
                }
            }

            ReceptionnisteDit($"Très bien, je vous réserve la chambre {chambreVoulue} !");
        }
        else
        {
            ReceptionnisteDit("Je suis désolé, aucune chambre n'est disponible pour le moment. N'hésitez pas à repasser plus tard !");
        }

        // Fin du dialogue
        ClientDit("Merci, excellente journée à vous.");
        ReceptionnisteDit("Merci, à vous également !");

    }

    // Les méthodes suivantes permettent de faciliter les intéractions avec la Console.
    // Elles rendent l'écrire du dialogue plus fluide et plus lisible.
    static void ReceptionnisteDit(string dire)
    {
        Dire("Réceptionniste", dire);
    }

    static void ClientDit(string dire)
    {
        Dire("Client", dire);
    }

    static void Dire(string orateur, string dire)
    {
        Console.WriteLine($"{orateur} : {dire}");
    }
}
