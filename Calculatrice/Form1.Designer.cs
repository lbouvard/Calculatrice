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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTouche = new System.Windows.Forms.Panel();
            this.btnShift = new System.Windows.Forms.Button();
            this.pnlTouche.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 57);
            this.panel1.TabIndex = 0;
            // 
            // pnlTouche
            // 
            this.pnlTouche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTouche.Controls.Add(this.btnShift);
            this.pnlTouche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTouche.Location = new System.Drawing.Point(0, 57);
            this.pnlTouche.Name = "pnlTouche";
            this.pnlTouche.Size = new System.Drawing.Size(360, 423);
            this.pnlTouche.TabIndex = 1;
            // 
            // btnShift
            // 
            this.btnShift.Location = new System.Drawing.Point(3, 3);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(68, 36);
            this.btnShift.TabIndex = 0;
            this.btnShift.Text = "Shift";
            this.btnShift.UseVisualStyleBackColor = true;
            // 
            // frmCalculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.pnlTouche);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalculatrice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculatrice";
            this.pnlTouche.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTouche;
        private System.Windows.Forms.Button btnShift;
    }
}

