using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Operation
    {
        public Operande Operande1 { get; set; }
        public Operande Operande2 { get; set; }

        public Operation Suivante { get; set; }
        public Operation Precedente { get; set; }

        public Operateur Operateur { get; set; }

        public String Resultat { get; set; }

        public Operande recupererResultat()
        {
            Operande total = new Operande();

            total = Operateur.calculer(Operande1, Operande2);
            Resultat = total.Valeur;

            return total;
        }

    }
    
}
