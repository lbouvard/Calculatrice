using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Projet Calculatrice
/// </summary>
namespace Calculatrice
{
    /// <summary>
    /// Classe de gestion d'une opération simple.
    /// Le résultat est passé sous forme de chaîne
    /// </summary>
    public class Operation
    {
        public Operande Operande1 { get; set; }
        public Operande Operande2 { get; set; }

        public Operation Suivante { get; set; }
        public Operation Precedente { get; set; }

        public Operateur Operateur { get; set; }

        public String Resultat { get; set; }

        /// <summary>
        /// Permet de calculer une opération simple (opérande 1 opérateur opérande 2)
        /// </summary>
        /// <returns>Valeur de retour en chaîne de caractères</returns>
        public Operande recupererResultat()
        {
            Operande total = new Operande();

            total = Operateur.calculer(Operande1, Operande2);
            Resultat = total.Valeur;

            return total;
        }

    }
    
}
