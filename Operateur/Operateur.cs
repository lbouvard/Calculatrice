using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operateur
{
    public abstract class Operateur
    {
        public int Priorite { get; set; }

        abstract public Operande.Operande calculer(Operande.Operande op1, Operande.Operande op2);
    }

    public class Adition : Operateur
    {
        public Adition()
        {
            this.Priorite = 1;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;

            lResultat = pOp1.Valeur + pOp2.Valeur;

            lRetour = new Operande.Operande(lResultat);

            return lRetour;
        }
    }

    public class Soustraction : Operateur
    {
        public Soustraction()
        {
            this.Priorite = 1;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;

            lResultat = pOp1.Valeur - pOp2.Valeur;

            lRetour = new Operande.Operande(lResultat);

            return lRetour;
        }
    }

    public class Multiplication : Operateur
    {
        public Multiplication()
        {
            this.Priorite = 2;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;

            lResultat = pOp1.Valeur * pOp2.Valeur;

            lRetour = new Operande.Operande(lResultat);

            return lRetour;
        }

    }

    public class Division : Operateur
    {
        public Division()
        {
            this.Priorite = 2;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;

            try
            {
                lResultat = pOp1.Valeur / pOp2.Valeur;
                lRetour = new Operande.Operande(lResultat);
            }
            catch(DivideByZeroException ex)
            {
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
            this.Priorite = 3;
            this.mDegre = pDegre;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2 = null)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;

            try
            {
                if (pOp2 != null)
                {
                    lResultat = (Decimal)Math.Pow((double)pOp1.Valeur, (double)pOp2.Valeur);
                }
                else
                {
                    lResultat = (Decimal)Math.Pow((double)pOp1.Valeur, mDegre);
                }
                 
                lRetour = new Operande.Operande(lResultat);
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
            this.Priorite = 1;
            this.mUnite = unite;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2 = null)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;
            double lOperande = 0;

            try
            {
                if( mUnite == "Deg")
                {
                    lOperande = (double)pOp1.Valeur * (double)(Math.PI / 180);
                }
                else
                {
                    lOperande = (double)pOp1.Valeur;
                }

                lResultat = (Decimal)Math.Cos(lOperande);


                if( mUnite == "Deg")
                {
                    lResultat = (Decimal)(((double)lResultat * 180) / Math.PI);
                }

                lRetour = new Operande.Operande(lResultat);
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
            this.Priorite = 1;
            this.mUnite = unite;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2 = null)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;
            double lOperande = 0;

            try
            {
                if (mUnite == "Deg")
                {
                    lOperande = (double)pOp1.Valeur * (double)(Math.PI / 180);
                }
                else
                {
                    lOperande = (double)pOp1.Valeur;
                }

                lResultat = (Decimal)Math.Sin(lOperande);


                if (mUnite == "Deg")
                {
                    lResultat = (Decimal)(((double)lResultat * 180) / Math.PI);
                }

                lRetour = new Operande.Operande(lResultat);
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
            this.Priorite = 1;
            this.mUnite = unite;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2 = null)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;
            double lOperande = 0;

            try
            {
                if (mUnite == "Deg")
                {
                    lOperande = (double)pOp1.Valeur * (double)(Math.PI / 180);
                }
                else
                {
                    lOperande = (double)pOp1.Valeur;
                }

                lResultat = (Decimal)Math.Tan(lOperande);


                if (mUnite == "Deg")
                {
                    lResultat = (Decimal)(((double)lResultat * 180) / Math.PI);
                }

                lRetour = new Operande.Operande(lResultat);
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
            this.Priorite = 1;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2 = null)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;

            try
            {
                if( mDegre == "e")
                {
                    lResultat = (Decimal)Math.Log((double)pOp1.Valeur);
                }
                else if( mDegre == "10")
                {
                    lResultat = (Decimal)Math.Log10((double)pOp1.Valeur);
                }
                
                lRetour = new Operande.Operande(lResultat);
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
            this.Priorite = 1;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2 = null)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;

            try
            {
                lResultat = (Decimal)Math.Sqrt((double)pOp1.Valeur); 
                lRetour = new Operande.Operande(lResultat);
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
            this.Priorite = 1;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2 = null)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;

            try
            {
                lResultat = (Decimal)Math.Exp((double)pOp1.Valeur);
                lRetour = new Operande.Operande(lResultat);
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
            this.Priorite = 1;
        }

        public override Operande.Operande calculer(Operande.Operande pOp1, Operande.Operande pOp2 = null)
        {
            Operande.Operande lRetour = null;
            Decimal lResultat = 0;

            try
            {
                lResultat = (Decimal)calculFactorielle((double)pOp1.Valeur);
                lRetour = new Operande.Operande(lResultat);
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
