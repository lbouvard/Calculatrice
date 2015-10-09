using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Projet Calculatrice
/// </summary>
namespace Calculatrice
{
    /// <summary>
    /// Contrôleur de la fenêtre GUI
    /// </summary>
    class controleurCalculatrice
    {
        private frmCalculatrice mFenetre;
        private List<String> historique;
        private int index_historique = 0;
        private Double resultat;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="fenetre">Fenêtre à controler</param>
        public controleurCalculatrice(frmCalculatrice fenetre)
        {
            mFenetre = fenetre;
        }

        /// <summary>
        /// RAZ des zones de saisies et initialisation de variables
        /// </summary>
        public void initialiserFenetre()
        {
            //RAZ
            mFenetre.recupererTxtCtrl("Saisie").Text = "";
            mFenetre.recupererTxtCtrl("Resultat").Text = "0";
            // liste des commandes pour historique
            this.historique = new List<string>();
        }

        /// <summary>
        /// Permet de récupérer le dernier résultat
        /// </summary>
        /// <returns>Résultat du dernier calcul</returns>
        public Double recupererDernierResultat()
        {
            return this.resultat;
        }

        /// <summary>
        /// Permet d'ajouter la dernière commande dans la liste historique
        /// </summary>
        /// <param name="pCalcul">Dernier calcul à sauvegarder</param>
        public void ajouterHistorique(String pCalcul)
        {
            historique.Add(pCalcul);
            index_historique = historique.Count - 1;
        }

        /// <summary>
        /// Permet de récupérer une valeur dans l'historique.
        /// </summary>
        /// <param name="up">Si vrai, on se déplace de la plus récente commande à la plus ancienne commande</param>
        /// <returns>La commande qui a été mémorisée</returns>
        public String recupererHistorique(bool up)
        {
            String retour = "";

            if (historique.Count > 0)
            { 
                retour = historique[index_historique];

                // on remonte la liste vers la commande la plus ancienne
                if (up && index_historique > 0 )
                {
                    index_historique--;
                }
                // on descend la liste vers la commande la plus récente
                else if (!up && index_historique < historique.Count - 1)
                {
                    index_historique++;
                }
            }

            // on retourne l'équation
            return retour;
        }

        /// <summary>
        /// Permet de vérifier si le bouton cliqué est un nombre.
        /// </summary>
        /// <param name="pValeurBouton">Caractère à saisir</param>
        /// <returns></returns>
        public bool estUnEntier(String pValeurBouton)
        {
            bool lRetour = false;
            int lValeur = 0;

            lRetour = Int32.TryParse(pValeurBouton, out lValeur);

            return lRetour;
        }

        /// <summary>
        /// Permet de traiter le calcul saisie et renvoyer la valeur du résultat
        /// </summary>
        /// <param name="pCalcul">Chaine qui représente le calcul</param>
        /// <returns></returns>
        public Double calculer(String pCalcul)
        {
            // appel du calculateur de la bibliothèque
            Calculateur calcul = new Calculateur(mFenetre.recupererTxtCtrl("Mode").Text);

            // pour les erreurs ou les calculs impossibles
            calcul.TraceErreur += Calcul_TraceErreur;

            // on ajoute l'entrée du calcul dans l'historique
            ajouterHistorique(pCalcul);

            // on effectue le calcul
            resultat = calcul.calculerOperation(pCalcul);

            return resultat;   
        }

        /// <summary>
        /// Retour des erreurs du calculateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calcul_TraceErreur(object sender, Calculateur.TraceErreurEventArgs e)
        {
            //this.mFenetre.afficherErreur(e.Message);
            throw new ArgumentException(e.Message);
        }

    }
}