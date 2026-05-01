using System;

namespace MetroVille.Class;

public class Bus : Vehicule
{
    private bool estEnZonePayante;
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
}
