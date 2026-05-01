using System;

namespace MetroVille.Class;

public class MetroAutomatique : Vehicule
{
    private bool modeAutnome = true;
    public MetroAutomatique(int numero, int capaciteMax, int puissanceMoteur) : base(numero, capaciteMax, puissanceMoteur)
    {
    }

    public override void Demarrer()
    {
        Console.WriteLine($"Metro {Numero} - activation du pilote automatique");
    }

    public override string GetTypeVehicule()
    {
        return "Metro Automatique";
    }
    public void SignalerIncident(string description)
    {
        Console.WriteLine($"Incident Metro {Numero} : {description}");
    }
}
