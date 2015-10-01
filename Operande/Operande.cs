using System;

namespace Calculatrice
{
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

        void rendreNegatif()
        {
            this.Valeur = "-" + this.Valeur;
        }

        void rendrePositif()
        {
            this.Valeur = this.Valeur.Replace("-", "");
        }



    }
}
