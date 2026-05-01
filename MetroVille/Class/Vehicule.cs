using System;

namespace MetroVille.Class;

public abstract class Vehicule
{
    private int numero;
    private int vitesse;
    private int capaciteMax;
    private Moteur moteur;

    public int Vitesse
    {
        get { return vitesse; }
        set 
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentOutOfRangeException(nameof(value),"La vitesse doit être entre 0 et 120");
            }
            vitesse = value;
        }
    }
    public int Numero { get{return numero;} }
    public Vehicule(int numero, int capaciteMax,int puissanceMoteur)
    {
        this.numero = numero;
        this.capaciteMax = capaciteMax;
        moteur = new Moteur(puissanceMoteur);
    }
    public void Accelerer(int increment)
    {
        Vitesse += increment;
    }
    public void Freiner(int decrement)
    {
        Vitesse -= decrement;
    }
    public abstract void Demarrer();
    public abstract string GetTypeVehicule();
    public void AfficherEtat()
    {
        Console.WriteLine($"Numéro : {numero}");
        Console.WriteLine($"Type : {GetTypeVehicule()}");
        Console.WriteLine($"Vitesse : {Vitesse}");
        Console.WriteLine($"Moteur allumé : {moteur.EstAllume()}");
    }
}
