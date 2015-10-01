using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculatrice
{
    class controleurCalculatrice
    {
        private frmCalculatrice mFenetre;
        private List<Operation> liste_op_historique;
        private Double resultat;

        public controleurCalculatrice(frmCalculatrice fenetre)
        {
            mFenetre = fenetre;
        }

        public void initialiserFenetre()
        {
            mFenetre.recupererTxtCtrl("Saisie").Text = "";
            mFenetre.recupererTxtCtrl("Resultat").Text = "";
        }

        public Double recupererDernierResultat()
        {
            return this.resultat;
        }

        public void memoriserResultat(Double pResultat)
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
       /*
        public Double parserCalcul(String pOperations)
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
                        if (lNombre.Length > 0) {

                            if (lObjet != null)
                            {
                                if (lObjet.Operande1 != null)
                                {
                                    lObjet.Operande2 = new Operande.Operande(Decimal.Parse(lNombre));
                                }
                                else
                                {
                                    lObjet.Operande1 = new Operande.Operande(Decimal.Parse(lNombre));
                                }
                            }
                            else
                            {
                                lObjet = new Operation.Operation();
                                lObjet.Operande1 = new Operande.Operande(Decimal.Parse(lNombre));
                                lListe.Add(lObjet);
                            }

                            lNombre = "";
                        }

                        if( lObjet.Operande2 != null)
                        {
                            if( lListe.Count() > 0)
                            {
                                lObjet = new Operation.Operation();
                                lObjet.Precedente = lListe[lListe.Count()];
                                lListe[lListe.Count()].Suivante = lObjet;

                                lListe.Add(lObjet);
                            }
                        }

                        //on stock l'opérateur
                        lAlpha += lOperation[i].ToString();
                        lObjet.Operateur = retrouverOperateur(lAlpha);

                        if (lObjet.Operateur != null) {
                            //on regarde si l'opération précédente à une priorité supérieur    
                            if (lListe.Count() > 0) {
                                if (lObjet.Precedente.Operateur.Priorite < lObjet.Operateur.Priorite)
                                {
                                    lObjet.Operande1 = lObjet.Precedente.Operande2;
                                    lObjet.Precedente.Operande2 = lObjet.va
                                }
                            }
                        }

                    } //fin else
                } //fin for

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
        */
        public Double calculer(String pCalcul)
        {
            Calculateur calcul = new Calculateur();
            return calcul.calculerOperation(pCalcul);
            
        }
    }
}