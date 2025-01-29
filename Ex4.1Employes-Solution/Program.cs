using Ex4._1Employes_Solution;

List<Employe> employes = new List<Employe>
        {
            new Employe("1234567", "Dupont", "Jean", new DateTime(1980, 5, 15), 50000.50, new DateTime(2005, 6, 1)),
            new Employe("7654321", "Martin", "Sophie", new DateTime(1995, 8, 20), 42000.75, new DateTime(2018, 9, 10)),
            new Employe("1112223", "Lavoie", "Pierre", new DateTime(1970, 3, 10), 65000.25, new DateTime(2000, 1, 1))
        };

foreach (var employe in employes)
{
    Console.WriteLine(employe);
    Console.WriteLine("----------------------");
}