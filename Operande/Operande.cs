using System;

/// <summary>
/// Projet calculatrice
/// </summary>
namespace Calculatrice
{
    /// <summary>
    /// Définie une opérande (sous forme de chaîne de caractères).
    /// </summary>
    public class Operande
    {

        public String Valeur { get; set; }

        public Operande()
        {
            Valeur = "";
        }

        public Operande(String pValeur)
        {
            this.Valeur = pValeur;
        }

    }
}
