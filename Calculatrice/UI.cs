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
        private bool resultat_affiche = false;

        private bool enModification = false;
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
            effacerCaractere();
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

            if (mPositionCurseur == txtSaisie.Text.Length)
                enModification = false;
            else
                enModification = true;
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            Double resultat = 0;

            try
            {
                resultat = mControleur.calculer(txtSaisie.Text);
                afficherResultat(resultat);
                mPositionCurseur = txtSaisie.Text.Length;

                resultat_affiche = true;
            }
            catch(Exception ex)
            {
                afficherErreur(ex.Message);
            }
            
        }

        private void btnTermine_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAncien_Click(object sender, EventArgs e)
        {
            String saisie = mControleur.recupererHistorique(false);

            if( saisie != "" )
                afficherSaisieHistorique(saisie);
        }

        private void btnRecent_Click(object sender, EventArgs e)
        {
            String saisie = mControleur.recupererHistorique(true);

            if (saisie != "")
                afficherSaisieHistorique(saisie);
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

        private void effacerSaisie()
        {
            txtSaisie.Text = "";
        }

        private void afficherSaisieHistorique(String saisie)
        {
            effacerSaisie();
            txtSaisie.Text = saisie;
        }

        private void afficherValeur(Object pBouton)
        {
            Button lBouton = (Button)pBouton;

            // si resultat affiché, on prend la valeur et on l'affiche sur la saisie
            if (!mControleur.estUnEntier(lBouton.Text) && txtResultat.Text.Length > 0 && !enModification )
            {
                txtSaisie.Text = mControleur.recupererDernierResultat().ToString();
                mPositionCurseur = txtSaisie.Text.Length;
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

        public void afficherErreur(String pMessage)
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
            txtResultat.Text = pResultat.ToString("G17");
        }

        #endregion

        private void txtSaisie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right && txtSaisie.SelectionStart == txtSaisie.Text.Length)
                enModification = false;
            else if (e.KeyData == Keys.Left)
                enModification = true;
        }
    }
}
