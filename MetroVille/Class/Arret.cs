using System;

namespace MetroVille.Class;

public class Arret
{
    private int passagersEnAttente;
    public string Nom { get; }
    public Arret(string nom)
    {
        Nom = nom;
        passagersEnAttente = 0;
    }
    public void AjouterPassagers(int nb)
    {
        if (nb < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(nb), "nb ne peut pas être négatif");
        }
        passagersEnAttente += nb;
    }
    public int FaireMonter(int nb)
    {
        if (nb < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(nb), "nb ne peut pas être négatif");
        }
        int nbQuiMontent = Math.Min(nb, passagersEnAttente);
        passagersEnAttente -= nbQuiMontent;
        return nbQuiMontent;
    }
    public int GetPassagersEnAttente()
    {
        return passagersEnAttente;
    }
}