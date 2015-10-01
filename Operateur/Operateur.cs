using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public abstract class Operateur
    {
        public int Priorite { get; set; }

        abstract public Operande calculer(Operande op1, Operande op2);
    }

    public class Addition : Operateur
    {
        public Addition()
        {
            this.Priorite = 0;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2)
        {
            Operande lRetour = null;
            Double lResultat = 0;

            lResultat = Double.Parse(pOp1.Valeur) + Double.Parse(pOp2.Valeur);

            lRetour = new Operande(lResultat.ToString("G17"));

            return lRetour;
        }
    }

    public class Soustraction : Operateur
    {
        public Soustraction()
        {
            this.Priorite = 0;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2)
        {
            Operande lRetour = null;
            Double lResultat = 0;

            lResultat = Double.Parse(pOp1.Valeur) - Double.Parse(pOp2.Valeur);

            lRetour = new Operande(lResultat.ToString("G17"));

            return lRetour;
        }
    }

    public class Multiplication : Operateur
    {
        public Multiplication()
        {
            this.Priorite = 1;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2)
        {
            Operande lRetour = null;
            Double lResultat = 0;

            lResultat = Double.Parse(pOp1.Valeur) * Double.Parse(pOp2.Valeur);

            lRetour = new Operande(lResultat.ToString("G17"));

            return lRetour;
        }

    }

    public class Division : Operateur
    {
        public Division()
        {
            this.Priorite = 1;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2)
        {
            Operande lRetour = null;
            Double lResultat = 0;

            try
            {
                lResultat = Double.Parse(pOp1.Valeur) / Double.Parse(pOp2.Valeur);
                lRetour = new Operande(lResultat.ToString("G17"));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Division par zéro impossible");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                lRetour = null;
            }

            return lRetour;
        }

    }

    public class Puissance : Operateur
    {
        //par défaut, le carré
        int mDegre = 0;

        public Puissance(int pDegre = 2)
        {
            this.Priorite = 1;
            this.mDegre = pDegre;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2 = null)
        {
            Operande lRetour = null;
            Double lResultat = 0;

            try
            {
                if (pOp2 != null)
                {
                    lResultat = (Double)Math.Pow(Double.Parse(pOp1.Valeur), (double)Double.Parse(pOp2.Valeur));
                }
                else
                {
                    lResultat = (Double)Math.Pow(Double.Parse(pOp1.Valeur), mDegre);
                }
                 
                lRetour = new Operande(lResultat.ToString("G17"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lRetour = null;
            }

            return lRetour;
        }
    }

    public class Cosinus : Operateur
    {
        String mUnite;

        public Cosinus(String unite)
        {
            this.Priorite = 0;
            this.mUnite = unite;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2 = null)
        {
            Operande lRetour = null;
            Double lResultat = 0;
            Double lOperande = 0;

            try
            {
                if( mUnite == "Deg")
                {
                    lOperande = Double.Parse(pOp1.Valeur) * (Math.PI / 180);
                }
                else
                {
                    lOperande = Double.Parse(pOp1.Valeur);
                }

                lResultat = Math.Cos(lOperande);

                lRetour = new Operande(lResultat.ToString("G17"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lRetour = null;
            }

            return lRetour;
        }

    }

    public class Sinus : Operateur
    {
        String mUnite;

        public Sinus(String unite)
        {
            this.Priorite = 0;
            this.mUnite = unite;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2 = null)
        {
            Operande lRetour = null;
            Double lResultat = 0;
            Double lOperande = 0;

            try
            {
                if (mUnite == "Deg")
                {
                    lOperande = Double.Parse(pOp1.Valeur) * (Math.PI / 180);
                }
                else
                {
                    lOperande = Double.Parse(pOp1.Valeur);
                }

                lResultat = Math.Sin(lOperande);

                lRetour = new Operande(lResultat.ToString("G17"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lRetour = null;
            }

            return lRetour;
        }

    }

    public class Tangente : Operateur
    {
        String mUnite;

        public Tangente(String unite)
        {
            this.Priorite = 0;
            this.mUnite = unite;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2 = null)
        {
            Operande lRetour = null;
            Double lResultat = 0;
            Double lOperande = 0;

            try
            {
                if (mUnite == "Deg")
                {
                    lOperande = Double.Parse(pOp1.Valeur) * (Math.PI / 180);
                }
                else
                {
                    lOperande = Double.Parse(pOp1.Valeur);
                }

                lResultat = Math.Tan(lOperande);

                lRetour = new Operande(lResultat.ToString("G17"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lRetour = null;
            }

            return lRetour;
        }

    }

    public class Log : Operateur
    {
        private String mDegre;

        public Log(String pDegre)
        {
            this.mDegre = pDegre;
            this.Priorite = 0;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2 = null)
        {
            Operande lRetour = null;
            Double lResultat = 0;

            try
            {
                if( mDegre == "e")
                {
                    lResultat = Math.Log(Double.Parse(pOp1.Valeur));
                }
                else if( mDegre == "10")
                {
                    lResultat = Math.Log10(Double.Parse(pOp1.Valeur));
                }
                
                lRetour = new Operande(lResultat.ToString("G17"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lRetour = null;
            }

            return lRetour;
        }
    }

    public class Racine : Operateur
    {
        public Racine()
        {
            this.Priorite = 0;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2 = null)
        {
            Operande lRetour = null;
            Double lResultat = 0;

            try
            {
                lResultat = Math.Sqrt(Double.Parse(pOp1.Valeur)); 
                lRetour = new Operande(lResultat.ToString("G17"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lRetour = null;
            }

            return lRetour;
        }
    }

    public class Exp : Operateur
    {
        public Exp()
        {
            this.Priorite = 0;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2 = null)
        {
            Operande lRetour = null;
            Double lResultat = 0;

            try
            {
                lResultat = Math.Pow(Math.E, Double.Parse(pOp1.Valeur));
                lRetour = new Operande(lResultat.ToString("G17"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lRetour = null;
            }

            return lRetour;
        }
    }

    public class Factorielle : Operateur
    {
        public Factorielle()
        {
            this.Priorite = 0;
        }

        public override Operande calculer(Operande pOp1, Operande pOp2 = null)
        {
            Operande lRetour = null;
            Double lResultat = 0;

            try
            {
                lResultat = calculFactorielle(Double.Parse(pOp1.Valeur));
                lRetour = new Operande(lResultat.ToString("G17"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lRetour = null;
            }

            return lRetour;
        }

        private double calculFactorielle(double entier)
        {
            if (entier > 1)
                return entier * calculFactorielle(entier - 1);
            else if (entier > 0 && (entier % 1 != 0))
                return entier * calculFactorielle(entier - 1);
            else
                return 1;
        }
    }
}
