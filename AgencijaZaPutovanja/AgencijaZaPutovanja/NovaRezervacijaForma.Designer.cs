namespace AgencijaZaPutovanja
{
    partial class NovaRezervacijaForma
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
            this.numBrojacPutnika = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojacPutnika)).BeginInit();
            this.SuspendLayout();
            // 
            // numBrojacPutnika
            // 
            this.numBrojacPutnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBrojacPutnika.Location = new System.Drawing.Point(152, 44);
            this.numBrojacPutnika.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBrojacPutnika.Name = "numBrojacPutnika";
            this.numBrojacPutnika.Size = new System.Drawing.Size(45, 26);
            this.numBrojacPutnika.TabIndex = 0;
            this.numBrojacPutnika.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrojacPutnika.ValueChanged += new System.EventHandler(this.numBrojacPutnika_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj putnika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ukupna cena";
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(79, 166);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(85, 32);
            this.btnRezervisi.TabIndex = 6;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = false;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(141, 119);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(56, 20);
            this.txtCena.TabIndex = 15;
            // 
            // NovaRezervacijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(246, 242);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBrojacPutnika);
            this.Name = "NovaRezervacijaForma";
            this.Text = "NovaRezervacija";
            this.Load += new System.EventHandler(this.NovaRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBrojacPutnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numBrojacPutnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.TextBox txtCena;
    }
}