using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operande
{
    public class Operande
    {
        public Operande()
        {
            Valeur = 0;
        }

        public Operande(Decimal pValeur)
        {
            Valeur = pValeur;
        }

        void rendreNegatif()
        {
            this.Valeur *= -1;
        }

        void rendrePositif()
        {
            this.Valeur *= 1;
        }

        public Decimal Valeur { get; private set; }

    }
}
