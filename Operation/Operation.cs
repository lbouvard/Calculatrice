using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    public class Operation
    {
        public Operande.Operande Operande1 { get; set; }
        public Operande.Operande Operande2 { get; set; }

        public Operation RefOperation { get; set; }

        public Operateur.Operateur Operateur { get; set; }

        public Decimal recupererResultat()
        {
            Decimal total = 0;

            return total;
        }

        public void insererOperation(Operation op)
        {
            this.RefOperation = op;
        }
    }
    
}
