namespace Calculatrice
{
    partial class frmCalculatrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculatrice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.pnlTouche = new System.Windows.Forms.Panel();
            this.btnRecent = new System.Windows.Forms.Button();
            this.btnAncien = new System.Windows.Forms.Button();
            this.btnTermine = new System.Windows.Forms.Button();
            this.btnModeDegre = new System.Windows.Forms.Button();
            this.btnEgal = new System.Windows.Forms.Button();
            this.btnDernierResultat = new System.Windows.Forms.Button();
            this.btnSeparateur = new System.Windows.Forms.Button();
            this.btnNb0 = new System.Windows.Forms.Button();
            this.btnSoustraction = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnNb3 = new System.Windows.Forms.Button();
            this.btnNb2 = new System.Windows.Forms.Button();
            this.btnNb1 = new System.Windows.Forms.Button();
            this.btnDiviser = new System.Windows.Forms.Button();
            this.btnMultiplier = new System.Windows.Forms.Button();
            this.btnNb6 = new System.Windows.Forms.Button();
            this.btnNb5 = new System.Windows.Forms.Button();
            this.btnNb4 = new System.Windows.Forms.Button();
            this.btnParentheseFermante = new System.Windows.Forms.Button();
            this.btnParentheseOuvrante = new System.Windows.Forms.Button();
            this.btnNb9 = new System.Windows.Forms.Button();
            this.btnNb8 = new System.Windows.Forms.Button();
            this.btnNb7 = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnPourcentage = new System.Windows.Forms.Button();
            this.btnRacine = new System.Windows.Forms.Button();
            this.btnFactoriel = new System.Windows.Forms.Button();
            this.btnModeRadian = new System.Windows.Forms.Button();
            this.btnPuissance3 = new System.Windows.Forms.Button();
            this.btnPuissancen = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnLogNeperien = new System.Windows.Forms.Button();
            this.btnPuissance2 = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnEffacerTout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlTouche.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtResultat);
            this.panel1.Controls.Add(this.txtMode);
            this.panel1.Controls.Add(this.txtSaisie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 70);
            this.panel1.TabIndex = 0;
            // 
            // txtResultat
            // 
            this.txtResultat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultat.Location = new System.Drawing.Point(54, 27);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(430, 31);
            this.txtResultat.TabIndex = 2;
            this.txtResultat.TabStop = false;
            this.txtResultat.Text = "2543";
            this.txtResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMode
            // 
            this.txtMode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMode.Location = new System.Drawing.Point(-1, 46);
            this.txtMode.Margin = new System.Windows.Forms.Padding(0);
            this.txtMode.Multiline = true;
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(58, 20);
            this.txtMode.TabIndex = 1;
            this.txtMode.TabStop = false;
            this.txtMode.Text = "Deg";
            this.txtMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaisie
            // 
            this.txtSaisie.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSaisie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaisie.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSaisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaisie.Location = new System.Drawing.Point(0, 0);
            this.txtSaisie.MaxLength = 32;
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.ReadOnly = true;
            this.txtSaisie.Size = new System.Drawing.Size(494, 19);
            this.txtSaisie.TabIndex = 0;
            this.txtSaisie.TabStop = false;
            this.txtSaisie.Text = "25+10+sqrt(10)";
            this.txtSaisie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaisie.Click += new System.EventHandler(this.txtSaisie_Click);
            this.txtSaisie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSaisie_KeyUp);
            // 
            // pnlTouche
            // 
            this.pnlTouche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTouche.Controls.Add(this.btnRecent);
            this.pnlTouche.Controls.Add(this.btnAncien);
            this.pnlTouche.Controls.Add(this.btnTermine);
            this.pnlTouche.Controls.Add(this.btnModeDegre);
            this.pnlTouche.Controls.Add(this.btnEgal);
            this.pnlTouche.Controls.Add(this.btnDernierResultat);
            this.pnlTouche.Controls.Add(this.btnSeparateur);
            this.pnlTouche.Controls.Add(this.btnNb0);
            this.pnlTouche.Controls.Add(this.btnSoustraction);
            this.pnlTouche.Controls.Add(this.btnAddition);
            this.pnlTouche.Controls.Add(this.btnNb3);
            this.pnlTouche.Controls.Add(this.btnNb2);
            this.pnlTouche.Controls.Add(this.btnNb1);
            this.pnlTouche.Controls.Add(this.btnDiviser);
            this.pnlTouche.Controls.Add(this.btnMultiplier);
            this.pnlTouche.Controls.Add(this.btnNb6);
            this.pnlTouche.Controls.Add(this.btnNb5);
            this.pnlTouche.Controls.Add(this.btnNb4);
            this.pnlTouche.Controls.Add(this.btnParentheseFermante);
            this.pnlTouche.Controls.Add(this.btnParentheseOuvrante);
            this.pnlTouche.Controls.Add(this.btnNb9);
            this.pnlTouche.Controls.Add(this.btnNb8);
            this.pnlTouche.Controls.Add(this.btnNb7);
            this.pnlTouche.Controls.Add(this.btnRetour);
            this.pnlTouche.Controls.Add(this.btnPi);
            this.pnlTouche.Controls.Add(this.btnPourcentage);
            this.pnlTouche.Controls.Add(this.btnRacine);
            this.pnlTouche.Controls.Add(this.btnFactoriel);
            this.pnlTouche.Controls.Add(this.btnModeRadian);
            this.pnlTouche.Controls.Add(this.btnPuissance3);
            this.pnlTouche.Controls.Add(this.btnPuissancen);
            this.pnlTouche.Controls.Add(this.btnExp);
            this.pnlTouche.Controls.Add(this.btnLogNeperien);
            this.pnlTouche.Controls.Add(this.btnPuissance2);
            this.pnlTouche.Controls.Add(this.btnSin);
            this.pnlTouche.Controls.Add(this.btnCos);
            this.pnlTouche.Controls.Add(this.btnTan);
            this.pnlTouche.Controls.Add(this.btnLog);
            this.pnlTouche.Controls.Add(this.btnEffacerTout);
            this.pnlTouche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTouche.Location = new System.Drawing.Point(0, 70);
            this.pnlTouche.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTouche.Name = "pnlTouche";
            this.pnlTouche.Size = new System.Drawing.Size(496, 505);
            this.pnlTouche.TabIndex = 1;
            // 
            // btnRecent
            // 
            this.btnRecent.BackColor = System.Drawing.Color.Bisque;
            this.btnRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecent.Location = new System.Drawing.Point(399, 107);
            this.btnRecent.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(91, 44);
            this.btnRecent.TabIndex = 14;
            this.btnRecent.Text = "▼";
            this.btnRecent.UseVisualStyleBackColor = false;
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
            // 
            // btnAncien
            // 
            this.btnAncien.BackColor = System.Drawing.Color.Bisque;
            this.btnAncien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAncien.Location = new System.Drawing.Point(399, 55);
            this.btnAncien.Margin = new System.Windows.Forms.Padding(4);
            this.btnAncien.Name = "btnAncien";
            this.btnAncien.Size = new System.Drawing.Size(91, 44);
            this.btnAncien.TabIndex = 9;
            this.btnAncien.Text = "▲";
            this.btnAncien.UseVisualStyleBackColor = false;
            this.btnAncien.Click += new System.EventHandler(this.btnAncien_Click);
            // 
            // btnTermine
            // 
            this.btnTermine.BackColor = System.Drawing.Color.Crimson;
            this.btnTermine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermine.Location = new System.Drawing.Point(399, 4);
            this.btnTermine.Margin = new System.Windows.Forms.Padding(4);
            this.btnTermine.Name = "btnTermine";
            this.btnTermine.Size = new System.Drawing.Size(91, 44);
            this.btnTermine.TabIndex = 4;
            this.btnTermine.Text = "O";
            this.btnTermine.UseVisualStyleBackColor = false;
            this.btnTermine.Click += new System.EventHandler(this.btnTermine_Click);
            // 
            // btnModeDegre
            // 
            this.btnModeDegre.Location = new System.Drawing.Point(103, 107);
            this.btnModeDegre.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeDegre.Name = "btnModeDegre";
            this.btnModeDegre.Size = new System.Drawing.Size(91, 44);
            this.btnModeDegre.TabIndex = 11;
            this.btnModeDegre.Text = "Deg";
            this.btnModeDegre.UseVisualStyleBackColor = true;
            this.btnModeDegre.Click += new System.EventHandler(this.btnModeDegre_Click);
            // 
            // btnEgal
            // 
            this.btnEgal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgal.Location = new System.Drawing.Point(301, 434);
            this.btnEgal.Margin = new System.Windows.Forms.Padding(4);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(189, 62);
            this.btnEgal.TabIndex = 38;
            this.btnEgal.Text = "=";
            this.btnEgal.UseVisualStyleBackColor = false;
            this.btnEgal.Click += new System.EventHandler(this.btnEgal_Click);
            // 
            // btnDernierResultat
            // 
            this.btnDernierResultat.BackColor = System.Drawing.Color.Green;
            this.btnDernierResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDernierResultat.Location = new System.Drawing.Point(201, 434);
            this.btnDernierResultat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDernierResultat.Name = "btnDernierResultat";
            this.btnDernierResultat.Size = new System.Drawing.Size(91, 62);
            this.btnDernierResultat.TabIndex = 37;
            this.btnDernierResultat.Text = "ANS";
            this.btnDernierResultat.UseVisualStyleBackColor = false;
            this.btnDernierResultat.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnSeparateur
            // 
            this.btnSeparateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeparateur.Location = new System.Drawing.Point(103, 434);
            this.btnSeparateur.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeparateur.Name = "btnSeparateur";
            this.btnSeparateur.Size = new System.Drawing.Size(91, 62);
            this.btnSeparateur.TabIndex = 36;
            this.btnSeparateur.Text = ",";
            this.btnSeparateur.UseVisualStyleBackColor = true;
            this.btnSeparateur.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb0
            // 
            this.btnNb0.Location = new System.Drawing.Point(4, 434);
            this.btnNb0.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb0.Name = "btnNb0";
            this.btnNb0.Size = new System.Drawing.Size(91, 62);
            this.btnNb0.TabIndex = 35;
            this.btnNb0.Text = "0";
            this.btnNb0.UseVisualStyleBackColor = true;
            this.btnNb0.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnSoustraction
            // 
            this.btnSoustraction.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSoustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoustraction.Location = new System.Drawing.Point(399, 366);
            this.btnSoustraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoustraction.Name = "btnSoustraction";
            this.btnSoustraction.Size = new System.Drawing.Size(91, 62);
            this.btnSoustraction.TabIndex = 34;
            this.btnSoustraction.Text = "-";
            this.btnSoustraction.UseVisualStyleBackColor = false;
            this.btnSoustraction.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.Location = new System.Drawing.Point(300, 366);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(91, 62);
            this.btnAddition.TabIndex = 33;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb3
            // 
            this.btnNb3.Location = new System.Drawing.Point(201, 366);
            this.btnNb3.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb3.Name = "btnNb3";
            this.btnNb3.Size = new System.Drawing.Size(91, 62);
            this.btnNb3.TabIndex = 32;
            this.btnNb3.Text = "3";
            this.btnNb3.UseVisualStyleBackColor = true;
            this.btnNb3.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb2
            // 
            this.btnNb2.Location = new System.Drawing.Point(103, 366);
            this.btnNb2.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb2.Name = "btnNb2";
            this.btnNb2.Size = new System.Drawing.Size(91, 62);
            this.btnNb2.TabIndex = 31;
            this.btnNb2.Text = "2";
            this.btnNb2.UseVisualStyleBackColor = true;
            this.btnNb2.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb1
            // 
            this.btnNb1.Location = new System.Drawing.Point(4, 366);
            this.btnNb1.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb1.Name = "btnNb1";
            this.btnNb1.Size = new System.Drawing.Size(91, 62);
            this.btnNb1.TabIndex = 30;
            this.btnNb1.Text = "1";
            this.btnNb1.UseVisualStyleBackColor = true;
            this.btnNb1.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnDiviser
            // 
            this.btnDiviser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDiviser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnDiviser.Location = new System.Drawing.Point(399, 297);
            this.btnDiviser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiviser.Name = "btnDiviser";
            this.btnDiviser.Size = new System.Drawing.Size(91, 62);
            this.btnDiviser.TabIndex = 29;
            this.btnDiviser.Text = "/";
            this.btnDiviser.UseVisualStyleBackColor = false;
            this.btnDiviser.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnMultiplier
            // 
            this.btnMultiplier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnMultiplier.Location = new System.Drawing.Point(300, 297);
            this.btnMultiplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(91, 62);
            this.btnMultiplier.TabIndex = 28;
            this.btnMultiplier.Text = "x";
            this.btnMultiplier.UseVisualStyleBackColor = false;
            this.btnMultiplier.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb6
            // 
            this.btnNb6.Location = new System.Drawing.Point(201, 297);
            this.btnNb6.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb6.Name = "btnNb6";
            this.btnNb6.Size = new System.Drawing.Size(91, 62);
            this.btnNb6.TabIndex = 27;
            this.btnNb6.Text = "6";
            this.btnNb6.UseVisualStyleBackColor = true;
            this.btnNb6.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb5
            // 
            this.btnNb5.Location = new System.Drawing.Point(103, 297);
            this.btnNb5.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb5.Name = "btnNb5";
            this.btnNb5.Size = new System.Drawing.Size(91, 62);
            this.btnNb5.TabIndex = 26;
            this.btnNb5.Text = "5";
            this.btnNb5.UseVisualStyleBackColor = true;
            this.btnNb5.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb4
            // 
            this.btnNb4.Location = new System.Drawing.Point(4, 297);
            this.btnNb4.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb4.Name = "btnNb4";
            this.btnNb4.Size = new System.Drawing.Size(91, 62);
            this.btnNb4.TabIndex = 25;
            this.btnNb4.Text = "4";
            this.btnNb4.UseVisualStyleBackColor = true;
            this.btnNb4.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnParentheseFermante
            // 
            this.btnParentheseFermante.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnParentheseFermante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentheseFermante.Location = new System.Drawing.Point(399, 228);
            this.btnParentheseFermante.Margin = new System.Windows.Forms.Padding(4);
            this.btnParentheseFermante.Name = "btnParentheseFermante";
            this.btnParentheseFermante.Size = new System.Drawing.Size(91, 62);
            this.btnParentheseFermante.TabIndex = 24;
            this.btnParentheseFermante.Text = ")";
            this.btnParentheseFermante.UseVisualStyleBackColor = false;
            this.btnParentheseFermante.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnParentheseOuvrante
            // 
            this.btnParentheseOuvrante.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnParentheseOuvrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentheseOuvrante.Location = new System.Drawing.Point(300, 228);
            this.btnParentheseOuvrante.Margin = new System.Windows.Forms.Padding(4);
            this.btnParentheseOuvrante.Name = "btnParentheseOuvrante";
            this.btnParentheseOuvrante.Size = new System.Drawing.Size(91, 62);
            this.btnParentheseOuvrante.TabIndex = 23;
            this.btnParentheseOuvrante.Text = "(";
            this.btnParentheseOuvrante.UseVisualStyleBackColor = false;
            this.btnParentheseOuvrante.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb9
            // 
            this.btnNb9.Location = new System.Drawing.Point(201, 228);
            this.btnNb9.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb9.Name = "btnNb9";
            this.btnNb9.Size = new System.Drawing.Size(91, 62);
            this.btnNb9.TabIndex = 22;
            this.btnNb9.Text = "9";
            this.btnNb9.UseVisualStyleBackColor = true;
            this.btnNb9.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb8
            // 
            this.btnNb8.Location = new System.Drawing.Point(103, 228);
            this.btnNb8.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb8.Name = "btnNb8";
            this.btnNb8.Size = new System.Drawing.Size(91, 62);
            this.btnNb8.TabIndex = 21;
            this.btnNb8.Text = "8";
            this.btnNb8.UseVisualStyleBackColor = true;
            this.btnNb8.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnNb7
            // 
            this.btnNb7.Location = new System.Drawing.Point(4, 228);
            this.btnNb7.Margin = new System.Windows.Forms.Padding(4);
            this.btnNb7.Name = "btnNb7";
            this.btnNb7.Size = new System.Drawing.Size(91, 62);
            this.btnNb7.TabIndex = 20;
            this.btnNb7.Text = "7";
            this.btnNb7.UseVisualStyleBackColor = true;
            this.btnNb7.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Bisque;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(399, 159);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(91, 62);
            this.btnRetour.TabIndex = 19;
            this.btnRetour.Text = "DEL";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPi.Font = new System.Drawing.Font("Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPi.Location = new System.Drawing.Point(300, 159);
            this.btnPi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(91, 62);
            this.btnPi.TabIndex = 18;
            this.btnPi.Text = "p";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnPourcentage
            // 
            this.btnPourcentage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPourcentage.Location = new System.Drawing.Point(201, 159);
            this.btnPourcentage.Margin = new System.Windows.Forms.Padding(4);
            this.btnPourcentage.Name = "btnPourcentage";
            this.btnPourcentage.Size = new System.Drawing.Size(91, 62);
            this.btnPourcentage.TabIndex = 17;
            this.btnPourcentage.Text = "%";
            this.btnPourcentage.UseVisualStyleBackColor = false;
            this.btnPourcentage.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnRacine
            // 
            this.btnRacine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRacine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacine.Location = new System.Drawing.Point(103, 159);
            this.btnRacine.Margin = new System.Windows.Forms.Padding(4);
            this.btnRacine.Name = "btnRacine";
            this.btnRacine.Size = new System.Drawing.Size(91, 62);
            this.btnRacine.TabIndex = 16;
            this.btnRacine.Text = "√";
            this.btnRacine.UseVisualStyleBackColor = false;
            this.btnRacine.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnFactoriel
            // 
            this.btnFactoriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactoriel.Location = new System.Drawing.Point(202, 107);
            this.btnFactoriel.Margin = new System.Windows.Forms.Padding(4);
            this.btnFactoriel.Name = "btnFactoriel";
            this.btnFactoriel.Size = new System.Drawing.Size(91, 44);
            this.btnFactoriel.TabIndex = 12;
            this.btnFactoriel.Text = "x!";
            this.btnFactoriel.UseVisualStyleBackColor = true;
            this.btnFactoriel.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnModeRadian
            // 
            this.btnModeRadian.Location = new System.Drawing.Point(4, 107);
            this.btnModeRadian.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeRadian.Name = "btnModeRadian";
            this.btnModeRadian.Size = new System.Drawing.Size(91, 44);
            this.btnModeRadian.TabIndex = 10;
            this.btnModeRadian.Text = "Rad";
            this.btnModeRadian.UseVisualStyleBackColor = true;
            this.btnModeRadian.Click += new System.EventHandler(this.btnModeRadian_Click);
            // 
            // btnPuissance3
            // 
            this.btnPuissance3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuissance3.Location = new System.Drawing.Point(103, 55);
            this.btnPuissance3.Margin = new System.Windows.Forms.Padding(4);
            this.btnPuissance3.Name = "btnPuissance3";
            this.btnPuissance3.Size = new System.Drawing.Size(91, 44);
            this.btnPuissance3.TabIndex = 6;
            this.btnPuissance3.Text = "x³";
            this.btnPuissance3.UseVisualStyleBackColor = true;
            this.btnPuissance3.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnPuissancen
            // 
            this.btnPuissancen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuissancen.Location = new System.Drawing.Point(201, 55);
            this.btnPuissancen.Margin = new System.Windows.Forms.Padding(4);
            this.btnPuissancen.Name = "btnPuissancen";
            this.btnPuissancen.Size = new System.Drawing.Size(91, 44);
            this.btnPuissancen.TabIndex = 7;
            this.btnPuissancen.Text = "xⁿ";
            this.btnPuissancen.UseVisualStyleBackColor = true;
            this.btnPuissancen.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(300, 55);
            this.btnExp.Margin = new System.Windows.Forms.Padding(4);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(91, 44);
            this.btnExp.TabIndex = 8;
            this.btnExp.Text = "e";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnLogNeperien
            // 
            this.btnLogNeperien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogNeperien.Location = new System.Drawing.Point(301, 107);
            this.btnLogNeperien.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogNeperien.Name = "btnLogNeperien";
            this.btnLogNeperien.Size = new System.Drawing.Size(91, 44);
            this.btnLogNeperien.TabIndex = 13;
            this.btnLogNeperien.Text = "ln";
            this.btnLogNeperien.UseVisualStyleBackColor = true;
            this.btnLogNeperien.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnPuissance2
            // 
            this.btnPuissance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuissance2.Location = new System.Drawing.Point(4, 55);
            this.btnPuissance2.Margin = new System.Windows.Forms.Padding(4);
            this.btnPuissance2.Name = "btnPuissance2";
            this.btnPuissance2.Size = new System.Drawing.Size(91, 44);
            this.btnPuissance2.TabIndex = 5;
            this.btnPuissance2.Text = "x²";
            this.btnPuissance2.UseVisualStyleBackColor = true;
            this.btnPuissance2.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(4, 4);
            this.btnSin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(91, 44);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(102, 4);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(91, 44);
            this.btnCos.TabIndex = 1;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(201, 4);
            this.btnTan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(91, 44);
            this.btnTan.TabIndex = 2;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(300, 4);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(91, 44);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnEcrire_Click);
            // 
            // btnEffacerTout
            // 
            this.btnEffacerTout.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEffacerTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacerTout.Location = new System.Drawing.Point(4, 159);
            this.btnEffacerTout.Margin = new System.Windows.Forms.Padding(4);
            this.btnEffacerTout.Name = "btnEffacerTout";
            this.btnEffacerTout.Size = new System.Drawing.Size(91, 62);
            this.btnEffacerTout.TabIndex = 15;
            this.btnEffacerTout.Text = "AC";
            this.btnEffacerTout.UseVisualStyleBackColor = false;
            this.btnEffacerTout.Click += new System.EventHandler(this.btnEffacerTout_Click);
            // 
            // frmCalculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(496, 575);
            this.Controls.Add(this.pnlTouche);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalculatrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.frmCalculatrice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTouche.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTouche;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnEffacerTout;
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Button btnDernierResultat;
        private System.Windows.Forms.Button btnSeparateur;
        private System.Windows.Forms.Button btnNb0;
        private System.Windows.Forms.Button btnSoustraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnNb3;
        private System.Windows.Forms.Button btnNb2;
        private System.Windows.Forms.Button btnNb1;
        private System.Windows.Forms.Button btnDiviser;
        private System.Windows.Forms.Button btnMultiplier;
        private System.Windows.Forms.Button btnNb6;
        private System.Windows.Forms.Button btnNb5;
        private System.Windows.Forms.Button btnNb4;
        private System.Windows.Forms.Button btnParentheseFermante;
        private System.Windows.Forms.Button btnParentheseOuvrante;
        private System.Windows.Forms.Button btnNb9;
        private System.Windows.Forms.Button btnNb8;
        private System.Windows.Forms.Button btnNb7;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnPourcentage;
        private System.Windows.Forms.Button btnRacine;
        private System.Windows.Forms.Button btnFactoriel;
        private System.Windows.Forms.Button btnModeRadian;
        private System.Windows.Forms.Button btnPuissance3;
        private System.Windows.Forms.Button btnPuissancen;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLogNeperien;
        private System.Windows.Forms.Button btnPuissance2;
        private System.Windows.Forms.Button btnModeDegre;
        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Button btnAncien;
        private System.Windows.Forms.Button btnTermine;
    }
}

