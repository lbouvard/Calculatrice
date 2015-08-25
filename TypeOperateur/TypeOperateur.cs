using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOperateur
{
    public class TypeOperateur
    {
        public String Operateur { get; private set; }

        public String Fonction { get; private set; }

        public TypeOperateur(String pOperateur, String pFonction)
        {
            Operateur = pOperateur;
            Fonction = pFonction;
        }


    }
}
