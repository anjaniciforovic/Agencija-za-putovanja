namespace AgencijaZaPutovanja
{
    partial class AdminForma
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
            this.lstRezervacije = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabRezervacije = new System.Windows.Forms.TabPage();
            this.btnOsveziRezervacije = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabIzleti = new System.Windows.Forms.TabPage();
            this.btnRefres = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodajIzlet = new System.Windows.Forms.Button();
            this.lstIzleti = new System.Windows.Forms.ListView();
            this.tabKorisnici = new System.Windows.Forms.TabPage();
            this.btnOsveziKorisnike = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.lstKorisnici = new System.Windows.Forms.ListView();
            this.tabAdmin.SuspendLayout();
            this.tabRezervacije.SuspendLayout();
            this.tabIzleti.SuspendLayout();
            this.tabKorisnici.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRezervacije
            // 
            this.lstRezervacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstRezervacije.HideSelection = false;
            this.lstRezervacije.Location = new System.Drawing.Point(17, 46);
            this.lstRezervacije.Name = "lstRezervacije";
            this.lstRezervacije.Size = new System.Drawing.Size(694, 341);
            this.lstRezervacije.TabIndex = 0;
            this.lstRezervacije.UseCompatibleStateImageBehavior = false;
            this.lstRezervacije.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 1;
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnObrisiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(396, 393);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(101, 27);
            this.btnObrisiRezervaciju.TabIndex = 3;
            this.btnObrisiRezervaciju.Text = "Obrisi";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = false;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabRezervacije);
            this.tabAdmin.Controls.Add(this.tabIzleti);
            this.tabAdmin.Controls.Add(this.tabKorisnici);
            this.tabAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(734, 473);
            this.tabAdmin.TabIndex = 4;
            // 
            // tabRezervacije
            // 
            this.tabRezervacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabRezervacije.Controls.Add(this.btnOsveziRezervacije);
            this.tabRezervacije.Controls.Add(this.btnAzuriraj);
            this.tabRezervacije.Controls.Add(this.button3);
            this.tabRezervacije.Controls.Add(this.lstRezervacije);
            this.tabRezervacije.Controls.Add(this.btnObrisiRezervaciju);
            this.tabRezervacije.Controls.Add(this.label1);
            this.tabRezervacije.Location = new System.Drawing.Point(4, 25);
            this.tabRezervacije.Name = "tabRezervacije";
            this.tabRezervacije.Padding = new System.Windows.Forms.Padding(3);
            this.tabRezervacije.Size = new System.Drawing.Size(726, 444);
            this.tabRezervacije.TabIndex = 0;
            this.tabRezervacije.Text = "Rezervacije";
            // 
            // btnOsveziRezervacije
            // 
            this.btnOsveziRezervacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOsveziRezervacije.Location = new System.Drawing.Point(636, 17);
            this.btnOsveziRezervacije.Name = "btnOsveziRezervacije";
            this.btnOsveziRezervacije.Size = new System.Drawing.Size(75, 23);
            this.btnOsveziRezervacije.TabIndex = 6;
            this.btnOsveziRezervacije.Text = "Osvezi";
            this.btnOsveziRezervacije.UseVisualStyleBackColor = false;
            this.btnOsveziRezervacije.Click += new System.EventHandler(this.btnOsveziRezervacije_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(503, 393);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(101, 27);
            this.btnAzuriraj.TabIndex = 5;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(610, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabIzleti
            // 
            this.tabIzleti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabIzleti.Controls.Add(this.btnRefres);
            this.tabIzleti.Controls.Add(this.btnPromeni);
            this.tabIzleti.Controls.Add(this.btnIzbrisi);
            this.tabIzleti.Controls.Add(this.btnDodajIzlet);
            this.tabIzleti.Controls.Add(this.lstIzleti);
            this.tabIzleti.Location = new System.Drawing.Point(4, 25);
            this.tabIzleti.Name = "tabIzleti";
            this.tabIzleti.Padding = new System.Windows.Forms.Padding(3);
            this.tabIzleti.Size = new System.Drawing.Size(726, 444);
            this.tabIzleti.TabIndex = 1;
            this.tabIzleti.Text = "Izleti";
            // 
            // btnRefres
            // 
            this.btnRefres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRefres.Location = new System.Drawing.Point(634, 15);
            this.btnRefres.Name = "btnRefres";
            this.btnRefres.Size = new System.Drawing.Size(75, 23);
            this.btnRefres.TabIndex = 4;
            this.btnRefres.Text = "Osvezi";
            this.btnRefres.UseVisualStyleBackColor = false;
            this.btnRefres.Click += new System.EventHandler(this.btnRefres_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPromeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromeni.Location = new System.Drawing.Point(501, 388);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(101, 27);
            this.btnPromeni.TabIndex = 3;
            this.btnPromeni.Text = "Azuriraj";
            this.btnPromeni.UseVisualStyleBackColor = false;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(394, 388);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(101, 27);
            this.btnIzbrisi.TabIndex = 2;
            this.btnIzbrisi.Text = "Obrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodajIzlet
            // 
            this.btnDodajIzlet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDodajIzlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajIzlet.Location = new System.Drawing.Point(608, 388);
            this.btnDodajIzlet.Name = "btnDodajIzlet";
            this.btnDodajIzlet.Size = new System.Drawing.Size(101, 27);
            this.btnDodajIzlet.TabIndex = 1;
            this.btnDodajIzlet.Text = "Dodaj ";
            this.btnDodajIzlet.UseVisualStyleBackColor = false;
            this.btnDodajIzlet.Click += new System.EventHandler(this.btnDodajIzlet_Click);
            // 
            // lstIzleti
            // 
            this.lstIzleti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstIzleti.HideSelection = false;
            this.lstIzleti.Location = new System.Drawing.Point(20, 44);
            this.lstIzleti.Name = "lstIzleti";
            this.lstIzleti.Size = new System.Drawing.Size(689, 338);
            this.lstIzleti.TabIndex = 0;
            this.lstIzleti.UseCompatibleStateImageBehavior = false;
            // 
            // tabKorisnici
            // 
            this.tabKorisnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabKorisnici.Controls.Add(this.btnOsveziKorisnike);
            this.tabKorisnici.Controls.Add(this.btnIzmeni);
            this.tabKorisnici.Controls.Add(this.btnDodajKorisnika);
            this.tabKorisnici.Controls.Add(this.btnUkloni);
            this.tabKorisnici.Controls.Add(this.lstKorisnici);
            this.tabKorisnici.Location = new System.Drawing.Point(4, 25);
            this.tabKorisnici.Name = "tabKorisnici";
            this.tabKorisnici.Padding = new System.Windows.Forms.Padding(3);
            this.tabKorisnici.Size = new System.Drawing.Size(726, 444);
            this.tabKorisnici.TabIndex = 2;
            this.tabKorisnici.Text = "Korisnici";
            this.tabKorisnici.Click += new System.EventHandler(this.tabKorisnici_Click);
            // 
            // btnOsveziKorisnike
            // 
            this.btnOsveziKorisnike.Location = new System.Drawing.Point(634, 10);
            this.btnOsveziKorisnike.Name = "btnOsveziKorisnike";
            this.btnOsveziKorisnike.Size = new System.Drawing.Size(75, 23);
            this.btnOsveziKorisnike.TabIndex = 4;
            this.btnOsveziKorisnike.Text = "Osvezi";
            this.btnOsveziKorisnike.UseVisualStyleBackColor = true;
            this.btnOsveziKorisnike.Click += new System.EventHandler(this.btnOsveziKorisnike_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(501, 385);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(101, 27);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Azuriraj";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDodajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKorisnika.Location = new System.Drawing.Point(608, 385);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(101, 27);
            this.btnDodajKorisnika.TabIndex = 2;
            this.btnDodajKorisnika.Text = "Dodaj";
            this.btnDodajKorisnika.UseVisualStyleBackColor = false;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click_1);
            // 
            // btnUkloni
            // 
            this.btnUkloni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.Location = new System.Drawing.Point(394, 385);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(101, 27);
            this.btnUkloni.TabIndex = 1;
            this.btnUkloni.Text = "Obrisi";
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // lstKorisnici
            // 
            this.lstKorisnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstKorisnici.HideSelection = false;
            this.lstKorisnici.Location = new System.Drawing.Point(21, 39);
            this.lstKorisnici.Name = "lstKorisnici";
            this.lstKorisnici.Size = new System.Drawing.Size(688, 340);
            this.lstKorisnici.TabIndex = 0;
            this.lstKorisnici.UseCompatibleStateImageBehavior = false;
            this.lstKorisnici.View = System.Windows.Forms.View.Details;
            // 
            // AdminForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(777, 495);
            this.Controls.Add(this.tabAdmin);
            this.Name = "AdminForma";
            this.Text = "AdminForma";
            this.Load += new System.EventHandler(this.AdminForma_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabRezervacije.ResumeLayout(false);
            this.tabRezervacije.PerformLayout();
            this.tabIzleti.ResumeLayout(false);
            this.tabKorisnici.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabRezervacije;
        private System.Windows.Forms.TabPage tabIzleti;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodajIzlet;
        private System.Windows.Forms.ListView lstIzleti;
        private System.Windows.Forms.TabPage tabKorisnici;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.ListView lstKorisnici;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnOsveziKorisnike;
        private System.Windows.Forms.Button btnRefres;
        private System.Windows.Forms.Button btnOsveziRezervacije;
    }
}