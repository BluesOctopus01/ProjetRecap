using System;
using MetroVille.Interface;

namespace MetroVille.Class;

public class Bus : Vehicule, ILocalisable
{
    private bool estEnZonePayante;
    private double latitude;
    private double longitude;
    public double Latitude { get{return latitude;}}
    public double Longitude { get{return longitude;}}
    public Bus(int numero, int capaciteMax, int puissanceMoteur, bool zoneTarifaire) : base(numero, capaciteMax, puissanceMoteur)
    {
        estEnZonePayante = zoneTarifaire;
    }

    public override void Demarrer()
    {
        DemarrerMoteur();
        string zone = estEnZonePayante ? "payante" : "gratuit";
        Console.WriteLine($"Bus{Numero} prêt - zone {zone}");
    }

    public override string GetTypeVehicule()
    {
        return "Bus";
    }
    public void ActualiserPosition(double lat, double lon)
    {
        latitude = lat;
        longitude = lon;
    }
}
