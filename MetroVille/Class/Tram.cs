using System;

namespace MetroVille.Class;

public class Tram : Vehicule
{
    private int numeroRail;
    public Tram(int numero, int capaciteMax, int puissanceMoteur, int numeroRail) : base(numero, capaciteMax, puissanceMoteur)
    {
        this.numeroRail = numeroRail;
    }

    public override void Demarrer()
    {
        DemarrerMoteur();
        Console.WriteLine($"Tram {Numero} sur rail {numeroRail} - prêt");
    }

    public override string GetTypeVehicule()
    {
        return "Tram";
    }
}
