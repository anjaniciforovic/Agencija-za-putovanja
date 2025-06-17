namespace AgencijaZaPutovanja
{
    partial class DodajNovuRezervacijuForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdKorisnika = new System.Windows.Forms.TextBox();
            this.txtIdIzleta = new System.Windows.Forms.TextBox();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.txtBrRezMesta = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID izleta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ukupna cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj rezervisanih mesta";
            // 
            // txtIdKorisnika
            // 
            this.txtIdKorisnika.Location = new System.Drawing.Point(202, 47);
            this.txtIdKorisnika.Name = "txtIdKorisnika";
            this.txtIdKorisnika.Size = new System.Drawing.Size(74, 20);
            this.txtIdKorisnika.TabIndex = 5;
            // 
            // txtIdIzleta
            // 
            this.txtIdIzleta.Location = new System.Drawing.Point(202, 91);
            this.txtIdIzleta.Name = "txtIdIzleta";
            this.txtIdIzleta.Size = new System.Drawing.Size(74, 20);
            this.txtIdIzleta.TabIndex = 6;
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Location = new System.Drawing.Point(202, 139);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.Size = new System.Drawing.Size(74, 20);
            this.txtUkupnaCena.TabIndex = 7;
            // 
            // txtBrRezMesta
            // 
            this.txtBrRezMesta.Location = new System.Drawing.Point(202, 187);
            this.txtBrRezMesta.Name = "txtBrRezMesta";
            this.txtBrRezMesta.Size = new System.Drawing.Size(74, 20);
            this.txtBrRezMesta.TabIndex = 8;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(112, 244);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 28);
            this.btnSacuvaj.TabIndex = 9;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // DodajNovuRezervacijuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(321, 355);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtBrRezMesta);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.txtIdIzleta);
            this.Controls.Add(this.txtIdKorisnika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajNovuRezervacijuForma";
            this.Text = "DodajNovuRezervacijuForma";
            this.Load += new System.EventHandler(this.DodajNovuRezervacijuForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdKorisnika;
        private System.Windows.Forms.TextBox txtIdIzleta;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.TextBox txtBrRezMesta;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}