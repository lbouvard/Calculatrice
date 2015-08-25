using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class controleurCalculatrice
    {
        private frmCalculatrice mFenetre;

        private List<Operation.Operation> liste_operations;
        private List<Operation.Operation> liste_op_historique;
        //private Operande.Operande dernierResultat;

        private Decimal resultat;

        public controleurCalculatrice(frmCalculatrice fenetre)
        {
            mFenetre = fenetre;
        }

        public void initialiserFenetre()
        {
            mFenetre.recupererTxtCtrl("Saisie").Text = "";
            mFenetre.recupererTxtCtrl("Resultat").Text = "";
        }

        public Decimal recupererDernierResultat()
        {
            return this.resultat;
        }

        public void emplilerOperation()
        {

        }

        public void depilerOperation()
        {

        }

        public void calculer()
        {

        }

        public void memoriserResultat(Decimal pResultat)
        {
            this.resultat = pResultat;
        }

        public void ajouterHistorique()
        {

        }

        public void gestionErreur()
        {

        }

        public bool estUnEntier(String pValeur)
        {
            bool lRetour = false;
            int lValeur = 0;

            lRetour = Int32.TryParse(pValeur, out lValeur);

            return lRetour;
        }

        public Decimal parserCalcul(String pOperations)
        {
            //on a besoin d'une opération pour parser.
            if( pOperations.Length == 0)
            {
                throw new Exception("Aucune valeur disponible");
            }

            List<Operation.Operation> lListe = null;
            String lOperation;
            Operation.Operation lObjet = null;
            Decimal lRetour = 0;
            int lResultatOut = 0;
            int lProfondeur = 0;

            String lNombre = "";
            String lAlpha = "";


            try
            {
                lListe = new List<Operation.Operation>();
                lOperation = pOperations;

                //On supprimer tous les espaces.
                lOperation = lOperation.Replace(" ", "");

                //Parcours de tous les caractères de l'opération
                for( int i =0; i < lOperation.Length; i++)
                {
                    if( Int32.TryParse(lOperation[i].ToString(), out lResultatOut) )
                    {
                        if( lAlpha.Length > 0)
                        {
                            lObjet.Operateur = retrouverOperateur(lAlpha);
                            lAlpha = "";
                        }

                        lNombre += lResultatOut.ToString();
                    }
                    else
                    {
                        lObjet = new Operation.Operation();
                        lObjet.Operande1 = new Operande.Operande(Decimal.Parse(lNombre));

                        lNombre = "";
                        lAlpha += lOperation[i].ToString();
                    }
                }

                if( lObjet.Operande2 == null)
                {
                    lObjet.Operande2 = new Operande.Operande(Decimal.Parse(lNombre));
                }
                lListe.Add(lObjet);

                //On parcours la liste et on fait les calculs
                foreach (var op in lListe)
                {
                    lRetour += (op.Operateur.calculer(op.Operande1, op.Operande2)).Valeur;
                }

            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            memoriserResultat(lRetour);
            return lRetour;

        }

        private Operateur.Operateur retrouverOperateur(String pChaine)
        {
            Operateur.Operateur lRetour = null;
            String lChaine = "";

            lChaine = pChaine;

            switch (lChaine)
            {
                case "+":
                    lRetour = new Operateur.Adition();
                       break;
                case "-":
                    lRetour = new Operateur.Soustraction();
                    break;

                case "*":
                    lRetour = new Operateur.Multiplication();
                    break;

                case "/":
                    lRetour = new Operateur.Division();
                    break;

                case "sin":
                    lRetour = new Operateur.Sinus(mFenetre.recupererTxtCtrl("Mode").Text);
                    break;

                case "cos":
                    lRetour = new Operateur.Cosinus(mFenetre.recupererTxtCtrl("Mode").Text);
                    break;

                case "tan":
                    lRetour = new Operateur.Tangente(mFenetre.recupererTxtCtrl("Mode").Text);
                    break;

                case "log":
                    lRetour = new Operateur.Log("10");
                    break;

                case "ln":
                    lRetour = new Operateur.Log("e");
                    break;

                case "^2":
                    lRetour = new Operateur.Puissance(2);
                    break;

                case "^3":
                    lRetour = new Operateur.Puissance(3);
                    break;

                case "^":
                    lRetour = new Operateur.Puissance();
                    break;

                case "e^":
                    lRetour = new Operateur.Exp();
                    break;

                case "sqrt":
                    lRetour = new Operateur.Racine();
                    break;

                case "fact":
                    lRetour = new Operateur.Factorielle();
                    break;

                default:
                    break;
            }

            return lRetour;
        }
    }
}
