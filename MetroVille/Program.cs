using MetroVille.Class;

Bus bus1 = new Bus(1,60,300,true);
Bus bus2 = new Bus(2,60,300,false);
Tram tram3= new Tram(3,120,450,2);
MetroAutomatique metroA4 = new MetroAutomatique(4,200,500);

Arret arret1 = new Arret("Gare centrale");
Arret arret2 = new Arret("Université");
Arret arret3 = new Arret("Marché");

arret1.AjouterPassagers(10);
arret2.AjouterPassagers(6);
arret3.AjouterPassagers(8);

Arret[] arrets = [arret1,arret2,arret3];
Vehicule[] vehicules = [bus1,bus2,tram3, metroA4];
Ligne ligne42 = new Ligne(42,arrets,vehicules);

Console.WriteLine(Moteur.GetPuissanceMax());

ligne42.LancerService();

ligne42.SimulerTour();

bus1.Accelerer(40);

try
{
    bus1.Accelerer(-50);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erreur : {ex.Message}");
}
bus1.ActualiserPosition(50.85,4.35);
Console.WriteLine($"Latitude : {bus1.Latitude}\nLongitutde : {bus1.Longitude}");

foreach (Vehicule v in vehicules)
{
    Console.WriteLine(v.GetTypeVehicule());
}

foreach (Vehicule v in vehicules)
{
    if (v is MetroAutomatique metro)
    {
        metro.SignalerIncident("Porte bloquée");
    }
}