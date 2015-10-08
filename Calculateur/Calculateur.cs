using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Calculateur
    {
        List<Operation> liste_op;
        String mode;

        public Calculateur(String pMode = "Deg")
        {
            mode = pMode;
            liste_op = new List<Operation>();
        }

        public Double calculerOperation(String calcul)
        {
            Double resultat = 0.0;

            try
            {
                // verification de la validité du calcul
                if (verifierCalculEntree(calcul))
                {
                    // on récupère le résultat 
                    resultat = Double.Parse(calculerSousOperation(calcul, liste_op));
                }

                // vide la liste pour les prochains calcul
                liste_op.Clear();

                return resultat;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                liste_op.Clear();
                return 0.0;
            }
        }

        private String calculerSousOperation(String calcul, List<Operation> liste)
        {
            try
            {
                // on transforme la chaîne d'entrée en une liste d'opération
                decomposerCalcul(calcul, liste);
                // on contrôle la priorité pour les opérations en attente d'opérande 
                verifierPriorite(liste);
                // on trie la liste de façon à avoir les plus grande priorités au début
                trierListe(liste);
                // calcule de la liste
                Calculer(liste);

                // on récupère le résultat qui se trouve dans le dernier élément de la liste
                return liste[liste.Count - 1].Resultat;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return "ERR";
            }
        }

        private bool verifierCalculEntree(String calcul)
        {
            int nbParenthese = 0;
            bool retour = true;

            foreach (char c in calcul)
            {
                if (c == '(')
                    nbParenthese++;
                else if (c == ')')
                    nbParenthese--;
            }

            if (nbParenthese != 0)
                retour = false;

            return retour;
        }

        private void decomposerCalcul(String calcul, List<Operation> liste)
        {
            // on supprime tous les espaces
            String donnees = calcul.Replace(" ", "");
            donnees = donnees.Replace("Pi", Math.PI.ToString("G17"));

            String operande = "";
            String operateur = "";
            Char c;

            Operation op = null;
            Operation suiv = null;

            bool numerique = true;
            bool rempli = false;

            // on parcours chaque caractère
            for (int i = 0; i < donnees.Length; i++)
            {
                c = donnees[i];

                // opération complète (2 opérandes ok) et autre opération à suivre
                if (rempli)
                {
                    rempli = false;
                    suiv = new Operation();
                    op.Suivante = suiv;
                    suiv.Precedente = op;

                    suiv.Operateur = retrouverOperateur(operateur);

                    liste.Add(op);
                    operateur = "";

                    op = suiv;
                    numerique = true;
                }

                if (char.IsDigit(c) || c == ',')
                {
                    //si on avait un caractère sur le caractère précédent
                    if (!numerique)
                    {
                        if (op != null && operateur != "")
                        {
                            op.Operateur = retrouverOperateur(operateur);
                            operateur = "";
                        }
                        else
                        {
                            // on ne fait rien
                        }
                    }
                    //nombre
                    operande += c;
                    numerique = true;
                }
                else
                {
                    int tailleOperateur = 0;
                    String operateurSpe = "";
                    bool operateurTrouve = true;

                    // opérateur spécifique
                    switch (c)
                    {
                        case 'c':
                            // cos( )
                            if (donnees[i + 1] == 'o' && donnees[i + 2] == 's')
                            {
                                operateurSpe = "cos";
                                tailleOperateur = 3;
                            }
                            // carre( )
                            else if (donnees[i + 1] == 'a' && donnees[i + 2] == 'r' && donnees[i + 3] == 'r' && donnees[i + 4] == 'e')
                            {
                                operateurSpe = "carre";
                                tailleOperateur = 5;
                            }
                            // cube( )
                            else if (donnees[i + 1] == 'u' && donnees[i + 2] == 'b' && donnees[i + 3] == 'e')
                            {
                                operateurSpe = "cube";
                                tailleOperateur = 4;
                            }
                            break;
                        case 's':
                            // sin( )
                            if (donnees[i + 1] == 'i' && donnees[i + 2] == 'n')
                            {
                                operateurSpe = "sin";
                                tailleOperateur = 3;
                            }
                            // racine carré
                            else if(donnees[i + 1] == 'q' && donnees[i + 2] == 'r' && donnees[i + 3] == 't')
                            {
                                operateurSpe = "sqrt";
                                tailleOperateur = 4;
                            }
                            break;
                        case 't':
                            // tan( )
                            if (donnees[i + 1] == 'a' && donnees[i + 2] == 'n')
                            {
                                operateurSpe = "tan";
                                tailleOperateur = 3;
                            }
                            break;
                        case 'l':
                            // logarithme népérien ln( )
                            if (donnees[i + 1] == 'n')
                            {
                                operateurSpe = "ln";
                                tailleOperateur = 2;
                            }
                            // logarithme base 10 log( )
                            else if (donnees[i + 1] == 'o' && donnees[i + 2] == 'g')
                            {
                                operateurSpe = "log";
                                tailleOperateur = 3;
                            }
                            break;
                        case 'f':
                            // factorielle fact( )
                            if (donnees[i + 1] == 'a' && donnees[i + 2] == 'c' && donnees[i + 3] == 't')
                            {
                                operateurSpe = "fact";
                                tailleOperateur = 4;
                            }
                            break;
                        case 'p':
                            // puissance népériene
                            if (donnees[i + 1] == 'o' && donnees[i + 2] == 'w' && donnees[i + 3] == 'e')
                            {
                                operateurSpe = "powe";
                                tailleOperateur = 4;
                            }
                            break;
                        case '^':
                            operateurSpe = "^";
                            tailleOperateur = 1;
                            break;
                        default:
                            operateurTrouve = false;
                            break;
                    }

                    if (operateurTrouve)
                    {
                        // on calcul par récurrence le contenu d'un couple de parenthèse
                        int positionFinParenthese = getPositionParentheseFermante(donnees.Substring(i + tailleOperateur + 1));
                        // on envoi la chaine découpée sans les parenthèses
                        String resultat = calculerSousOperation(donnees.Substring(i + tailleOperateur + 1, positionFinParenthese), new List<Operation>());
                        // on retire les informations avec les parenthèses
                        donnees = donnees.Remove(i, tailleOperateur + positionFinParenthese + 2);

                        // cas de la puissance
                        if (operateurSpe == "^")
                        {
                            resultat = calculExterne(operande, resultat, new Puissance());
                            donnees = donnees.Remove(i - operande.Length, operande.Length);
                            operande = "";
                        }
                        else
                        {
                            resultat = calculExterne(resultat, null, retrouverOperateur(operateurSpe));
                        }

                        // cas de la puissance sur une operation complexe
                        if (i < donnees.Length)
                        {
                            if (donnees[i] == '^')
                            {
                                resultat = calculPuissance(resultat, ref donnees, i);
                            }
                        }

                        // cas ou un multiple se trouve devant l'opérateur
                        if (operande != "")
                        {
                            resultat = calculExterne(operande, resultat, new Multiplication());
                        }

                        if (op == null)
                        {
                            op = new Operation();
                            op.Resultat = resultat;

                            liste.Add(op);
                        }
                        else
                        {
                            if( op.Resultat == "-")
                            {
                                op.Resultat += resultat;
                                liste.Add(op);
                            }
                            else
                            {
                                op.Operande2 = new Operande(resultat);
                                if( operateur != "")
                                {
                                    op.Operateur = retrouverOperateur(operateur);
                                }

                                // l'ajout de l'opération ce fera dans la prochaine itération
                                rempli = true;

                                // si y a des calcul à la suite
                                if (donnees.Length > i)
                                    c = donnees[i];

                                operateur = "";
                            }
                        }

                        numerique = false;
                    }

                    // priorité des parenthèses
                    if (c == '(')
                    {
                        // dans le cas ou une opération entre parenthèse est la deuxieme opérande d'un calcul
                        if (operateur != "" && op.Operande1 != null && op.Operande2 != null)
                        {
                            Operation tampon = new Operation();
                            tampon.Operateur = retrouverOperateur(operateur);

                            op.Suivante = tampon;
                            tampon.Precedente = op;

                            liste.Add(op);

                            op = tampon;
                        }

                        // on calcul par récurrence le contenu d'un couple de parenthèse
                        int positionFinParenthese = getPositionParentheseFermante(donnees.Substring(i + 1));
                        // on envoi la chaine découpée sans les parenthèses
                        String resultat = calculerSousOperation(donnees.Substring(i + 1, positionFinParenthese), new List<Operation>());
                        // on retire les informations avec les parenthèses
                        donnees = donnees.Remove(i, positionFinParenthese + 2);

                        // tout le calcul est entre parenthèse
                        if (donnees.Length == 0)
                        {
                            op = new Operation();
                            op.Resultat = resultat;

                            liste.Add(op);
                            // on annule la variable par défaut à true
                            numerique = false;
                        }
                        // 1ere calcul
                        else if (op == null)
                        {
                            op = new Operation();

                            op.Operande1 = new Operande(resultat);
                            op.Operateur = retrouverOperateur(donnees[i].ToString());
                        }
                        else
                        {
                            // on enregistre le résultat
                            op.Operande2 = new Operande(resultat);
                            // on enregistre l'opérateur de la sous opération
                            if( operateur != "")
                            {
                                op.Operateur = retrouverOperateur(operateur);
                                operateur = "";
                            }
                            else
                            {
                                continue;
                            }


                            if ((op.Operande1 == null || op.Operande2 == null || donnees.Length > i + 1) && liste.Count == 0)
                            {
                                // nouvelle opération
                                Operation tampon = new Operation();
                                tampon.Operateur = retrouverOperateur(donnees[i].ToString());
                                op.Suivante = tampon;
                                tampon.Precedente = op;

                                // ajout à la liste des calculs
                                liste.Add(op);

                                // on passe à l'opération en cours
                                op = tampon;
                            }
                            else
                            {
                                liste.Add(op);
                            }
                        }

                        continue;
                    }


                    //si on avait un nombre sur le caractère précédent
                    if (numerique)
                    {
                        //si on a déjà une opération en cours
                        if (op != null)
                        {
                            // cas d'un calcul avec parenthèse
                            if (op.Resultat == "-")
                            {
                                op.Operande1 = new Operande("-" + operande);
                                op.Resultat = null;
                                operande = "";
                            }
                            else if (op.Operande2 == null)
                            {
                                op.Operande2 = new Operande(operande);
                                operande = "";
                                rempli = true;
                            }
                        }
                        else
                        {
                            op = new Operation();

                            // pour un nombre négatif
                            if (operande == "")
                            {
                                op.Resultat = "-";
                                continue;
                            }
                            else
                            {
                                op.Operande1 = new Operande(operande);
                                operande = "";
                            }
                        }
                    }

                    //operateur
                    operateur += c;
                    numerique = false;
                }
            }

            //dernière operande
            if (numerique)
            {
                //si on a déjà une opération en cours
                if (op != null)
                {
                    // cas du nombre négatif
                    if( op.Resultat == "-")
                    {
                        op.Resultat += operande;
                    }
                    else if (op.Operande2 == null)
                    {
                        op.Operande2 = new Operande(operande);
                    }

                    operande = "";
                    liste.Add(op);
                }
                // opération comme première opérande
                else
                {
                    op = new Operation();
                    op.Resultat = operande;
                    liste.Add(op);
                }
            }

            // cas de calcul complexe ou une opération à tous les éléments de rempli
            if (rempli && !numerique && op.Operande1 != null)
            {
                liste.Add(op);
            }
        }

        private void verifierPriorite(List<Operation> liste)
        {
            // seulement si on a plus d'un élément
            if (liste.Count > 1)
            {
                for (int i = 1; i < liste.Count; i++)
                {
                    //si la priorité de l'opération en cours est supérieur à l'opération -1
                    if (liste[i].Operateur.Priorite > liste[i - 1].Operateur.Priorite && liste[i].Operande1 == null)
                    {
                        liste[i].Operande1 = liste[i - 1].Operande2;
                        liste[i - 1].Operande2 = null;
                    }
                }
            }
        }

        private void trierListe(List<Operation> liste)
        {
            Operation op;
            int priorite;
            int indice;

            for (int i = 0; i < liste.Count - 1; i++)
            {
                //op = liste_op[i];
                priorite = liste[i].Operateur.Priorite;
                indice = i;

                while (liste[indice + 1].Operateur.Priorite > priorite && indice > -1)
                {
                    op = liste[indice + 1];
                    liste.Remove(op);
                    liste.Insert(indice, op);

                    // priorité en cours
                    priorite = liste[indice].Operateur.Priorite;

                    indice--;
                }
            }

            // dernier element doit donner le resultat, donc on cible l'avant dernier resultat
            if (liste.Count > 1 && liste[liste.Count - 1].Suivante == null)
            {
                liste[liste.Count - 1].Precedente = liste[liste.Count - 2];
            }
        }

        private void Calculer(List<Operation> liste)
        {
            foreach (Operation op in liste)
            {
                //on a une valeur dans les deux opérandes, alors on calcul
                if (op.Operande1 != null && op.Operande2 != null && op.Resultat == null)
                {
                    op.recupererResultat();
                }
                else
                {
                    // on calcul 
                    if (op.Precedente != null && op.Suivante != null && op.Resultat == null)
                    {
                        if (op.Precedente.Resultat != null && op.Suivante.Resultat != null)
                        {
                            op.Resultat = calculExterne(op.Precedente.Resultat, op.Suivante.Resultat, op.Operateur);
                        }
                        else if (op.Precedente.Resultat != null && op.Operande2!= null)
                        {
                            op.Resultat = calculExterne(op.Precedente.Resultat, op.Operande2.Valeur, op.Operateur);
                        }
                        else if (op.Suivante.Resultat != null && op.Operande1 != null)
                        {
                            op.Resultat = calculExterne(op.Operande1.Valeur, op.Suivante.Resultat, op.Operateur);
                        }
                    }
                    //si derniere opération
                    else if (op.Suivante == null && op.Resultat == null)
                    {
                        op.Resultat = calculExterne(op.Precedente.Resultat, op.Operande2.Valeur, op.Operateur);
                    }
                    else if (op.Resultat == null)
                    {
                        op.Resultat = calculExterne(op.Operande1.Valeur, op.Suivante.Resultat, op.Operateur);
                    }
                }
            }
        }

        private String calculExterne(String operande1, String operande2, Operateur operateur)
        {
            try
            {
                Operation calcul = new Operation();
                calcul.Operande1 = new Operande(operande1);

                if (operande2 != null)
                {
                    calcul.Operande2 = new Operande(operande2);
                }
                else
                {
                    calcul.Operande2 = null;
                }
                calcul.Operateur = operateur;

                return calcul.recupererResultat().Valeur;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return "0";
            }
        }

        private String calculPuissance(String operande1, ref String operation, int indice)
        {
            String retour = "";

            // on calcul par récurrence le contenu d'un couple de parenthèse
            int positionFinParenthese = getPositionParentheseFermante(operation.Substring(indice + 2));
            // on envoi la chaine découpée sans les parenthèses
            retour = calculerSousOperation(operation.Substring(indice + 2, positionFinParenthese), new List<Operation>());
            // on retire les informations avec les parenthèses
            operation = operation.Remove(indice, positionFinParenthese + 3);

            retour = calculExterne(operande1, retour, new Puissance());

            return retour;
        }

        private int getPositionParentheseFermante(String chaine)
        {
            int i;
            int nbParenthese = 0;
            char c;

            for (i = 0; i < chaine.Length; i++)
            {
                c = chaine[i];

                if (c == '(')
                    nbParenthese++;
                else if (c == ')')
                    nbParenthese--;

                if (nbParenthese < 0)
                    break;
            }

            return i;
        }

        private Operateur retrouverOperateur(String pChaine)
        {
            Operateur lRetour = null;
            String lChaine = "";

            lChaine = pChaine;

            switch (lChaine)
            {
                case "+":
                    lRetour = new Addition();
                    break;
                case "-":
                    lRetour = new Soustraction();
                    break;

                case "x":
                    lRetour = new Multiplication();
                    break;

                case "/":
                    lRetour = new Division();
                    break;

                case "sin":
                    lRetour = new Sinus(mode);
                    break;

                case "cos":
                    lRetour = new Cosinus(mode);
                    break;

                case "tan":
                    lRetour = new Tangente(mode);
                    break;

                case "log":
                    lRetour = new Log("10");
                    break;

                case "ln":
                    lRetour = new Log("e");
                    break;

                case "carre":
                    lRetour = new Puissance(2);
                    break;

                case "cube":
                    lRetour = new Puissance(3);
                    break;

                case "^":
                    lRetour = new Puissance();
                    break;

                case "powe":
                    lRetour = new Exp();
                    break;

                case "sqrt":
                    lRetour = new Racine();
                    break;

                case "fact":
                    lRetour = new Factorielle();
                    break;

                default:
                    lRetour = null;
                    break;
            }

            return lRetour;
        }


        // trace à remonter au contrôleur appelant
        public event EventHandler<TraceErreurEventArgs> TraceErreur;

        protected virtual void TracerErreur(TraceErreurEventArgs e)
        {
            EventHandler<TraceErreurEventArgs> handler = TraceErreur;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        public class TraceErreurEventArgs : EventArgs
        {
            public String Message { get; set; }
        }
    }
}
