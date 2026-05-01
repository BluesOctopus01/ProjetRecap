using MetroVille.Class;
Console.WriteLine("\n\n1) Créer les véhicules\n");
Bus bus1 = new Bus(1,60,300,true);
Bus bus2 = new Bus(2,60,300,false);
Tram tram3= new Tram(3,120,450,2);
MetroAutomatique metroA4 = new MetroAutomatique(4,200,500);

Console.WriteLine("\n\n2) Créer 3 arrêts\n");
Arret arret1 = new Arret("Gare centrale");
Arret arret2 = new Arret("Université");
Arret arret3 = new Arret("Marché");
arret1.AjouterPassagers(10);
arret2.AjouterPassagers(6);
arret3.AjouterPassagers(8);

Console.WriteLine("\n\n3) Création de la ligne 42\n");
Arret[] arrets = [arret1,arret2,arret3];
Vehicule[] vehicules = [bus1,bus2,tram3, metroA4];
Ligne ligne42 = new Ligne(42,arrets,vehicules);

Console.WriteLine("\n\n4) Affichage de la puissance maximale autorisée\n");
Console.WriteLine(Moteur.GetPuissanceMax());

Console.WriteLine("\n\n5) Lancer le service\n");
ligne42.LancerService();

Console.WriteLine("\n\n6) Simuler un tour complet\n");
ligne42.SimulerTour();

Console.WriteLine("\n\n7) Accélerer\n");
bus1.Accelerer(40);
try
{
    bus1.Accelerer(-50);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erreur : {ex.Message}");
}

Console.WriteLine("\n\n8) Mettre à jour la position GPS\n");
bus1.ActualiserPosition(50.85,4.35);
Console.WriteLine($"Latitude : {bus1.Latitude}\nLongitude : {bus1.Longitude}");

Console.WriteLine("\n\n9) Parcourir la flotte\n");
foreach (Vehicule v in vehicules)
{
    Console.WriteLine(v.GetTypeVehicule());
}


Console.WriteLine("\n\n10) Détecter le métro automatique\n");
foreach (Vehicule v in vehicules)
{
    if (v is MetroAutomatique metro)
    {
        metro.SignalerIncident("Porte bloquée");
    }
}