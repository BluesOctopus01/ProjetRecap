using System;
using System.IO.Compression;

namespace MetroVille.Class;

public class Ligne
{
    private int numeroLigne;
    private Arret[] arrets = [];
    private Vehicule[] vehicules = [];
    public Ligne(int numeroLigne, Arret[] arrets,Vehicule[] vehicules)
    {
        this.numeroLigne = numeroLigne;
        this.arrets = arrets;
        this.vehicules = vehicules;
    }
    public void LancerService()
    {
        foreach ( Vehicule v in vehicules)
        {
            v.Demarrer();
        }
    }
    public void SimulerTour()
    {
        foreach (Vehicule v in vehicules)
        {
            foreach(Arret a in arrets)
            {
                a.FaireMonter(5);
                
                v.AfficherEtat();
            }
        }
    }
}
