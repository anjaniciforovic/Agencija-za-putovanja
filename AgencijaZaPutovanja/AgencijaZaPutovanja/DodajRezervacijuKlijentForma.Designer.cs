namespace AgencijaZaPutovanja
{
    partial class DodajRezervacijuKlijentForma
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
            this.lstIzleti = new System.Windows.Forms.ListView();
            this.btnRezervisiIzlet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.nudBrojPutnika = new System.Windows.Forms.NumericUpDown();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojPutnika)).BeginInit();
            this.SuspendLayout();
            // 
            // lstIzleti
            // 
            this.lstIzleti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstIzleti.HideSelection = false;
            this.lstIzleti.Location = new System.Drawing.Point(33, 47);
            this.lstIzleti.Name = "lstIzleti";
            this.lstIzleti.Size = new System.Drawing.Size(562, 236);
            this.lstIzleti.TabIndex = 0;
            this.lstIzleti.UseCompatibleStateImageBehavior = false;
            this.lstIzleti.SelectedIndexChanged += new System.EventHandler(this.lstIzleti_SelectedIndexChanged);
            // 
            // btnRezervisiIzlet
            // 
            this.btnRezervisiIzlet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRezervisiIzlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisiIzlet.Location = new System.Drawing.Point(497, 289);
            this.btnRezervisiIzlet.Name = "btnRezervisiIzlet";
            this.btnRezervisiIzlet.Size = new System.Drawing.Size(98, 35);
            this.btnRezervisiIzlet.TabIndex = 1;
            this.btnRezervisiIzlet.Text = "Rezervisi";
            this.btnRezervisiIzlet.UseVisualStyleBackColor = false;
            this.btnRezervisiIzlet.Click += new System.EventHandler(this.btnRezervisiIzlet_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesi broj putnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vasa cena";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(149, 338);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(53, 20);
            this.txtCena.TabIndex = 5;
            // 
            // nudBrojPutnika
            // 
            this.nudBrojPutnika.Location = new System.Drawing.Point(149, 308);
            this.nudBrojPutnika.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBrojPutnika.Name = "nudBrojPutnika";
            this.nudBrojPutnika.Size = new System.Drawing.Size(53, 20);
            this.nudBrojPutnika.TabIndex = 6;
            this.nudBrojPutnika.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(255, 323);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(128, 21);
            this.cmbDrzava.TabIndex = 7;
            this.cmbDrzava.SelectedIndexChanged += new System.EventHandler(this.cmbDrzava_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filtriraj po drzavi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Napravite novu rezervaciju";
            // 
            // DodajRezervacijuKlijentForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(629, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.nudBrojPutnika);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezervisiIzlet);
            this.Controls.Add(this.lstIzleti);
            this.Name = "DodajRezervacijuKlijentForma";
            this.Text = "DodajRezervacijuKlijentForma";
            this.Load += new System.EventHandler(this.DodajRezervacijuKlijentForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojPutnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstIzleti;
        private System.Windows.Forms.Button btnRezervisiIzlet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.NumericUpDown nudBrojPutnika;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}