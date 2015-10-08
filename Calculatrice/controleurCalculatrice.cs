using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculatrice
{
    class controleurCalculatrice
    {
        private frmCalculatrice mFenetre;
        private List<String> historique;
        private int index_historique = 0;
        private Double resultat;

        public controleurCalculatrice(frmCalculatrice fenetre)
        {
            mFenetre = fenetre;
        }

        public void initialiserFenetre()
        {
            mFenetre.recupererTxtCtrl("Saisie").Text = "";
            mFenetre.recupererTxtCtrl("Resultat").Text = "";
            this.historique = new List<string>();
        }

        public Double recupererDernierResultat()
        {
            return this.resultat;
        }

        public void ajouterHistorique(String pCalcul)
        {
            historique.Add(pCalcul);
        }

        public String recupererHistorique(bool avance)
        {
            String retour = "";

            if (historique.Count > 0)
            { 
                retour = historique[index_historique];

                // on avance vers l'historique le plus ancien
                if (!avance && index_historique < historique.Count - 1)
                {
                    index_historique++;
                }
                // on avance vers l'historique le plus ancien
                else if (avance && index_historique > 0)
                {
                    index_historique--;
                }
            }

            // on retourne l'équation
            return retour;
        }

        public bool estUnEntier(String pValeur)
        {
            bool lRetour = false;
            int lValeur = 0;

            lRetour = Int32.TryParse(pValeur, out lValeur);

            return lRetour;
        }

        public Double calculer(String pCalcul)
        {
            // appel du calculateur de la bibliothèque
            Calculateur calcul = new Calculateur();

            // pour les erreurs ou les calculs impossibles
            calcul.TraceErreur += Calcul_TraceErreur;

            // on ajoute l'entrée du calcul dans l'historique
            ajouterHistorique(pCalcul);

            // on effectue le calcul
            resultat = calcul.calculerOperation(pCalcul);

            return resultat;   
        }

        private void Calcul_TraceErreur(object sender, Calculateur.TraceErreurEventArgs e)
        {
            //this.mFenetre.afficherErreur(e.Message);
            throw new ArgumentException(e.Message);
        }

    }
}