using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Projet Calculatrice
/// </summary>
namespace Calculatrice
{
    /// <summary>
    /// GUI de la calculatrice
    /// </summary>
    public partial class frmCalculatrice : Form
    {

        #region Définition
        private const int MAXCAR = 32;

        private controleurCalculatrice mControleur;
        private int mPositionCurseur = 0;
        private int nbCaractereSaisi = 0;
        private Font mPoliceInitiale;
        private bool resultat_affiche = false;

        private bool enModification = false;
        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur de la fenêtre
        /// </summary>
        public frmCalculatrice()
        {
            InitializeComponent();
            mControleur = new controleurCalculatrice(this);
            mPoliceInitiale = txtResultat.Font;
        }

        #endregion

        #region Evénements

        /// <summary>
        /// Au chargement de l'application, on initialise le controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCalculatrice_Load(object sender, EventArgs e)
        {
            mControleur.initialiserFenetre();
            btnEffacerTout.Focus();
        }

        /// <summary>
        /// Le bouton DEL permet d'effacer un caractère selon la position du curseur
        /// dans la zone de saisie (zone supérieure)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            effacerCaractere();

            if (nbCaractereSaisi > 0)
                nbCaractereSaisi--;
        }

        /// <summary>
        /// Le bouton AC permet d'effacer la zone de saisie et la zone de résultat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEffacerTout_Click(object sender, EventArgs e)
        {
            effacerTout();
            nbCaractereSaisi = 0;
        }

        /// <summary>
        /// Evénement lié à tous les boutons sauf DEL, AC, OFF, =, historique (flêches)
        /// qui permet de traité l'affichage de ce qui est cliqué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEcrire_Click(object sender, EventArgs e)
        {
            if (nbCaractereSaisi < MAXCAR)
                afficherValeur(sender);
            else
                Console.Beep();
        }

        /// <summary>
        /// Permet de contrôler la position du curseur lors d'un clic dans la zone de saisie (position visuel du curseur d'ecriture).
        /// Si le curseur n'est pas à la fin, alors la saisie se fait à la suite de la position du curseur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSaisie_Click(object sender, EventArgs e)
        {
            mPositionCurseur = txtSaisie.SelectionStart;

            if (mPositionCurseur == txtSaisie.Text.Length)
                enModification = false;
            else
                enModification = true;
        }

        /// <summary>
        /// Permet de lancer le calcul et de l'afficher. Le curseur est alors positionné à la fin de la zone de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEgal_Click(object sender, EventArgs e)
        {
            Double resultat = 0;
            String calcul = "";

            try
            {
                // on remplace tous les 'Ans' par le dernier résultat
                calcul = txtSaisie.Text;
                calcul = calcul.Replace("Ans", mControleur.recupererDernierResultat().ToString());

                resultat = mControleur.calculer(calcul);
                afficherResultat(resultat);
                mPositionCurseur = txtSaisie.Text.Length;

                resultat_affiche = true;
            }
            catch(Exception ex)
            {
                afficherErreur(ex.Message);
            }
            
        }

        /// <summary>
        /// Permet de quitter l'application Calculette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTermine_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Permet d'afficher l'historique des commandes dans la zone de saisie.
        /// On remonte la liste de l'historique (vers le plus ancien).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAncien_Click(object sender, EventArgs e)
        {
            String saisie = mControleur.recupererHistorique(true);

            if( saisie != "" )
                afficherSaisieHistorique(saisie);
        }

        /// <summary>
        /// Permet d'afficher l'historique des commandes dans la zone de saisie.
        /// On descend la liste de l'historique (vers le plus récent)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecent_Click(object sender, EventArgs e)
        {
            String saisie = mControleur.recupererHistorique(false);

            if (saisie != "")
                afficherSaisieHistorique(saisie);
        }

        /// <summary>
        /// Permet de suivre la position du curseur lorsque l'utilisateur utilise les flèches pour déplacer 
        /// visuellement le curseur dans la zone de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSaisie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right && txtSaisie.SelectionStart == txtSaisie.Text.Length)
                enModification = false;
            else if (e.KeyData == Keys.Left)
                enModification = true;
        }

        /// <summary>
        /// Permet de faire les calculs trigonométriques en Radian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModeRadian_Click(object sender, EventArgs e)
        {
            txtMode.Text = "Rad";
        }

        /// <summary>
        /// Permet de faire les calculs trigonométriques en Degré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModeDegre_Click(object sender, EventArgs e)
        {
            txtMode.Text = "Deg";
        }

        #endregion

        #region Propriétés

        #endregion

        #region Methodes publiques

        /// <summary>
        /// Permet de modifier la fenêtre depuis le contrôleur
        /// </summary>
        /// <param name="pNom">Nom de la zone de texte à modifier</param>
        /// <returns>Le composant zone de texte demandé</returns>
        public TextBox recupererTxtCtrl(String pNom)
        {
            TextBox txtCtrl = null;

            if (pNom == "Saisie")
                txtCtrl = txtSaisie;
            else if (pNom == "Resultat")
                txtCtrl = txtResultat;
            else if (pNom == "Mode")
                txtCtrl = txtMode;

            return txtCtrl;
        }    

        #endregion

        #region Méthodes privées

        /// <summary>
        /// Efface la zone de saisie et la zone de résultat
        /// </summary>
        private void effacerTout()
        {
            txtResultat.Text = "0";
            txtSaisie.Text = "";
            mPositionCurseur = 0;

            resultat_affiche = false;
            txtResultat.Font = mPoliceInitiale;
        }

        /// <summary>
        /// Permet d'effacer le caractère juste après le curseur
        /// </summary>
        private void effacerCaractere()
        {
            String TexteSaisiGauche = "";
            String TexteSaisiDroite = "";

            if (txtSaisie.Text.Length > 0)
            {
                if (mPositionCurseur == 0)
                {
                    txtSaisie.Text = txtSaisie.Text.Substring(0, txtSaisie.Text.Length - 1);
                }
                else
                {
                    TexteSaisiGauche = txtSaisie.Text.Substring(0, mPositionCurseur - 1);
                    TexteSaisiDroite = txtSaisie.Text.Substring(mPositionCurseur);
                    txtSaisie.Text = TexteSaisiGauche + TexteSaisiDroite;
                    mPositionCurseur -= 1;

                }
            }
        }

        /// <summary>
        /// Permet d'effacer uniquement la zone de saisie.
        /// </summary>
        private void effacerSaisie()
        {
            txtSaisie.Text = "";
        }

        /// <summary>
        /// Permet d'afficher l'historique des commandes.
        /// Efface la zone de saisie et affiche la commande demandé.
        /// </summary>
        /// <param name="saisie"></param>
        private void afficherSaisieHistorique(String saisie)
        {
            effacerSaisie();
            txtSaisie.Text = saisie;
        }

        /// <summary>
        /// Fonction de traitement du bouton cliqué.
        /// Permet de préparer les opérandes et les opérateurs pour affichage dans la zone de saisie.
        /// </summary>
        /// <param name="pBouton">Information sur le bouton cliqué</param>
        private void afficherValeur(Object pBouton)
        {
            Button lBouton = (Button)pBouton;

            // si resultat affiché, on prend la valeur et on l'affiche sur la saisie
            if (!mControleur.estUnEntier(lBouton.Text) && resultat_affiche && !enModification )
            {
                String opeComplexe = estUnOperateurComplexe(lBouton.Name);

                if( opeComplexe == "" )
                {
                    txtSaisie.Text = "Ans";
                    mPositionCurseur = txtSaisie.Text.Length;
                }
                else
                {
                    //on affiche déjà l'opération avec "Ans" et on finie la fonction
                    if (opeComplexe != "Ans" && opeComplexe != "Pi" && opeComplexe != "Err")
                    {
                        txtSaisie.Text = opeComplexe + "Ans";
                    }
                    else
                    {
                        if (opeComplexe == "Ans" || opeComplexe == "Err" )
                        {
                            txtSaisie.Text = "Ans";
                        }
                        else
                        {
                            txtSaisie.Text = "Pi";
                        }
                    }
                    mPositionCurseur = txtSaisie.Text.Length;

                    //nouvelle saisie donc on supprimer le contenu du résultat
                    resultat_affiche = false;
                    txtResultat.Text = "";

                    return;
                }
                
            }

            // si on a un resultat affiché, on supprime le resultat
            if (resultat_affiche)
            {
                resultat_affiche = false;
                txtResultat.Text = "";
            }

            switch (lBouton.Name)
            {

                case "btnPuissance2":
                    ajouterTexte("carre(");
                    break;

                case "btnPuissance3":
                    ajouterTexte("cube(");
                    break;

                case "btnPuissancen":
                    ajouterTexte("^(");
                    break;

                case "btnCos":
                    ajouterTexte("cos(");
                    break;

                case "btnSin":
                    ajouterTexte("sin(");
                    break;

                case "btnTan":
                    ajouterTexte("tan(");
                    break;

                case "btnLog":
                    ajouterTexte("log(");
                    break;

                case "btnLogNeperien":
                    ajouterTexte("ln(");
                    break;

                case "btnExp":
                    ajouterTexte("powe(");
                    break;

                case "btnRacine":
                    ajouterTexte("sqrt(");
                    break;

                case "btnFactoriel":
                    ajouterTexte("fact(");
                    break;

                case "btnPi":
                    ajouterTexte("Pi");
                    break;

                case "btnDernierResultat":
                    ajouterTexte(mControleur.recupererDernierResultat().ToString());
                    break;

                case "btnParentheseOuvrante":
                    ajouterTexte(lBouton.Text);
                    break;

                case "btnParentheseFermante":
                    ajouterTexte(lBouton.Text);
                    break;

                default:
                    int sortie;

                    if( Int32.TryParse(lBouton.Text, out sortie ))
                    {
                        ajouterTexte(sortie.ToString());
                    }
                    else
                    {
                        if (lBouton.Text == ",")
                            ajouterTexte(lBouton.Text);
                        else
                            ajouterTexte(" " + lBouton.Text + " ");
                    }
                    break;
            }
        }

        /// <summary>
        /// Permet d'afficher les informations dans la zone de saisie.
        /// </summary>
        /// <param name="pAjout">Chaîne à ajouter à la zone de saisie</param>
        private void ajouterTexte(String pAjout)
        {
            String TexteSaisiGauche = "";
            String TexteSaisiDroite = "";

            // si aucune saisie
            if (txtSaisie.Text.Length == 0)
            {
                nbCaractereSaisi = 0;
                txtSaisie.Text = pAjout;
                mPositionCurseur += pAjout.Length;
            }
            else
            {
                // on ajoute à la position du curseur. On récupère donc le texte à gauche et à droite de la position du curseur
                TexteSaisiGauche = txtSaisie.Text.Substring(0, mPositionCurseur);
                TexteSaisiDroite = txtSaisie.Text.Substring(mPositionCurseur, txtSaisie.Text.Length - mPositionCurseur);
                // on recompose le tout
                txtSaisie.Text = TexteSaisiGauche + pAjout + TexteSaisiDroite;
                // on décale la position du curseur (virtuel) du nombre de caractère ajouté
                mPositionCurseur += pAjout.Length;
            }

            nbCaractereSaisi += pAjout.Length;
        }

        /// <summary>
        /// Permet d'afficher un message dans la zone de résultat (erreur, info...)
        /// </summary>
        /// <param name="pMessage">Message à afficher</param>
        public void afficherErreur(String pMessage)
        {
            //Ecrire en plus petit
            Font lFontErreur = new Font("Microsoft Sans Serif", 10);
            //on applique
            txtResultat.Font = lFontErreur;
            //affiche le message
            txtResultat.Text = pMessage;
        }

        /// <summary>
        /// Permet d'afficher le résultat du calcul.
        /// </summary>
        /// <param name="pResultat">Résultat double à afficher</param>
        private void afficherResultat(Double pResultat)
        {
            // on transforme le double en texte avec une précision spécifique (G17)
            txtResultat.Text = pResultat.ToString();
        }

        /// <summary>
        /// Permet de vérifier que l'opérateur demandé lors d'une nouvelle saisie doit précéder le "Ans"
        /// </summary>
        /// <param name="operateur">Nom du bouton opération</param>
        /// <returns></returns>
        private String estUnOperateurComplexe(String operateur)
        {
            String retour = "";

            switch (operateur)
            {

                case "btnPuissance2":
                    retour = "carre(";
                    break;

                case "btnPuissance3":
                    retour = "cube(";
                    break;

                case "btnCos":
                    retour = "cos(";
                    break;

                case "btnSin":
                    retour = "sin(";
                    break;

                case "btnTan":
                    retour = "tan(";
                    break;

                case "btnLog":
                    retour = "log(";
                    break;

                case "btnLogNeperien":
                    retour = "ln(";
                    break;

                case "btnExp":
                    retour = "powe(";
                    break;

                case "btnRacine":
                    retour = "sqrt(";
                    break;

                case "btnFactoriel":
                    retour = "fact(";
                    break;

                case "btnDernierResultat":
                    retour = "Ans";
                    break;

                case "btnPi":
                    retour = "Pi";
                    break;

                case "btnParentheseOuvrante":
                    retour = "(";
                    break;

                //aucune utilité, on ignore la saisie
                case "btnParentheseFermante":
                    retour = "Err";
                    break;
            }

            return retour;
        }

        #endregion
    }
}
