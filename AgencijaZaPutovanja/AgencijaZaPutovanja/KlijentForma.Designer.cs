namespace AgencijaZaPutovanja
{
    partial class KlijentForma
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
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.btnDodajNovuRez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVidiDetalje = new System.Windows.Forms.Button();
            this.lstVaseRezervacije = new System.Windows.Forms.ListView();
            this.lnkIstorija = new System.Windows.Forms.LinkLabel();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnObrisiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(511, 86);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(145, 31);
            this.btnObrisiRezervaciju.TabIndex = 0;
            this.btnObrisiRezervaciju.Text = "Obrisi rezervaciju";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = false;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // btnDodajNovuRez
            // 
            this.btnDodajNovuRez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDodajNovuRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovuRez.Location = new System.Drawing.Point(511, 145);
            this.btnDodajNovuRez.Name = "btnDodajNovuRez";
            this.btnDodajNovuRez.Size = new System.Drawing.Size(145, 28);
            this.btnDodajNovuRez.TabIndex = 1;
            this.btnDodajNovuRez.Text = "Dodaj novu rezervaciju";
            this.btnDodajNovuRez.UseVisualStyleBackColor = false;
            this.btnDodajNovuRez.Click += new System.EventHandler(this.btnDodajNovuRez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vase rezervacije ";
            // 
            // btnVidiDetalje
            // 
            this.btnVidiDetalje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVidiDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVidiDetalje.Location = new System.Drawing.Point(511, 203);
            this.btnVidiDetalje.Name = "btnVidiDetalje";
            this.btnVidiDetalje.Size = new System.Drawing.Size(145, 30);
            this.btnVidiDetalje.TabIndex = 3;
            this.btnVidiDetalje.Text = "Vidi detalje";
            this.btnVidiDetalje.UseVisualStyleBackColor = false;
            this.btnVidiDetalje.Click += new System.EventHandler(this.btnVidiDetalje_Click);
            // 
            // lstVaseRezervacije
            // 
            this.lstVaseRezervacije.HideSelection = false;
            this.lstVaseRezervacije.Location = new System.Drawing.Point(12, 86);
            this.lstVaseRezervacije.Name = "lstVaseRezervacije";
            this.lstVaseRezervacije.Size = new System.Drawing.Size(493, 206);
            this.lstVaseRezervacije.TabIndex = 4;
            this.lstVaseRezervacije.UseCompatibleStateImageBehavior = false;
            this.lstVaseRezervacije.View = System.Windows.Forms.View.Details;
            this.lstVaseRezervacije.SelectedIndexChanged += new System.EventHandler(this.lstVaseRezervacije_SelectedIndexChanged);
            // 
            // lnkIstorija
            // 
            this.lnkIstorija.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkIstorija.AutoSize = true;
            this.lnkIstorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIstorija.LinkColor = System.Drawing.Color.Black;
            this.lnkIstorija.Location = new System.Drawing.Point(40, 299);
            this.lnkIstorija.Name = "lnkIstorija";
            this.lnkIstorija.Size = new System.Drawing.Size(59, 18);
            this.lnkIstorija.TabIndex = 5;
            this.lnkIstorija.TabStop = true;
            this.lnkIstorija.Text = "Istorija..";
            this.lnkIstorija.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIstorija_LinkClicked);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(511, 266);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(145, 26);
            this.btnAzuriraj.TabIndex = 6;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOsvezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvezi.Location = new System.Drawing.Point(401, 299);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(104, 24);
            this.btnOsvezi.TabIndex = 7;
            this.btnOsvezi.Text = "Osvezi";
            this.btnOsvezi.UseVisualStyleBackColor = false;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // KlijentForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(668, 389);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lnkIstorija);
            this.Controls.Add(this.lstVaseRezervacije);
            this.Controls.Add(this.btnVidiDetalje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajNovuRez);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Name = "KlijentForma";
            this.Text = "klijent";
            this.Load += new System.EventHandler(this.KlijentForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.Button btnDodajNovuRez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVidiDetalje;
        private System.Windows.Forms.ListView lstVaseRezervacije;
        private System.Windows.Forms.LinkLabel lnkIstorija;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnOsvezi;
    }
}