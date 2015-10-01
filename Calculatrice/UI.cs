using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class frmCalculatrice : Form
    {

        #region Définition
        private controleurCalculatrice mControleur;
        private int mPositionCurseur = 0;
        private Font mPoliceInitiale;
        #endregion

        #region Constructeurs

        public frmCalculatrice()
        {
            InitializeComponent();
            mControleur = new controleurCalculatrice(this);
            mPoliceInitiale = txtResultat.Font;
        }

        #endregion

        #region Evénements
        private void frmCalculatrice_Load(object sender, EventArgs e)
        {
            mControleur.initialiserFenetre();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            effacterCaractere();
        }

        private void btnEffacerTout_Click(object sender, EventArgs e)
        {
            effacerTout();
        }

        private void btnEcrire_Click(object sender, EventArgs e)
        {
            afficherValeur(sender);
        }

        private void txtSaisie_Click(object sender, EventArgs e)
        {
            mPositionCurseur = txtSaisie.SelectionStart;
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            Double resultat = 0;

            try
            {
                resultat = mControleur.calculer(txtSaisie.Text);
                afficherResultat(resultat);
                mPositionCurseur = 0;
            }
            catch(Exception ex)
            {
                afficherErreur(ex.Message);
            }
            
        }

        #endregion

        #region Propriétés

        #endregion

        #region Methodes publiques

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

        private void effacerTout()
        {
            txtResultat.Text = "";
            txtSaisie.Text = "";
            mPositionCurseur = 0;

            txtResultat.Font = mPoliceInitiale;
        }

        private void effacterCaractere()
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

        private void afficherValeur(Object pBouton)
        {
            Button lBouton = (Button)pBouton;

            if (!mControleur.estUnEntier(lBouton.Text) && txtResultat.Text.Length > 0)
            {
                txtSaisie.Text = mControleur.recupererDernierResultat().ToString();
                mPositionCurseur = txtSaisie.Text.Length;
            }

            switch (lBouton.Name)
            {

                case "btnPuissance2":
                    ajouterTexte("^2");
                    break;

                case "btnPuissance3":
                    ajouterTexte("^3");
                    break;

                case "btnPuissancen":
                    ajouterTexte("^");
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
                    ajouterTexte("e^");
                    break;

                case "btnRacine":
                    ajouterTexte("sqrt(");
                    break;

                case "btnFactoriel":
                    ajouterTexte("fact(");
                    break;

                case "btnModeRadian":
                    txtMode.Text = "Rad";
                    break;

                case "btnModeDegre":
                    txtMode.Text = "Deg";
                    break;

                case "btnSigne":

                    String lSaisieGauche;
                    String lSaisieDroite;
                    int lPositionInitiale;
                    int valeur;

                    lPositionInitiale = mPositionCurseur;

                    for(int i = mPositionCurseur - 1; i > 0; i--)
                    {
                        if( !Int32.TryParse( txtSaisie.Text[i].ToString(), out valeur))
                        {
                            lSaisieGauche = txtSaisie.Text.Substring(0, i+1);
                            lSaisieDroite = txtSaisie.Text.Substring(i+1);
                            txtSaisie.Text = lSaisieGauche + "-" + lSaisieDroite;
                            mPositionCurseur = lPositionInitiale + 1;

                            break;
                        }
                        mPositionCurseur = i;
                    }
                    break;

                case "btnPi":
                    ajouterTexte("Pi");
                    break;

                case "BtnDernierResultat":
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
                        ajouterTexte(" " + lBouton.Text + " ");
                    }
                    break;
            }
        }

        private void ajouterTexte(String pAjout)
        {
            String TexteSaisiGauche = "";
            String TexteSaisiDroite = "";

            if (txtSaisie.Text.Length == 0)
            {
                txtSaisie.Text = pAjout;
                mPositionCurseur += pAjout.Length;
            }
            else
            {
                TexteSaisiGauche = txtSaisie.Text.Substring(0, mPositionCurseur);
                TexteSaisiDroite = txtSaisie.Text.Substring(mPositionCurseur, txtSaisie.Text.Length - mPositionCurseur);
                txtSaisie.Text = TexteSaisiGauche + pAjout + TexteSaisiDroite;
                mPositionCurseur += pAjout.Length;
            }
        }

        private void afficherErreur(String pMessage)
        {
            //Ecrire en plus petit
            Font lFontErreur = new Font("Microsoft Sans Serif", 10);
            //on applique
            txtResultat.Font = lFontErreur;
            //affiche le message
            txtResultat.Text = pMessage;
        }

        private void afficherResultat(Double pResultat)
        {
            txtResultat.Text = pResultat.ToString();
        }

        #endregion

    }
}
