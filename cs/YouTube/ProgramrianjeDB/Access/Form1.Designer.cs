namespace Access
{
    partial class Form1
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
            this.sacuvaj = new System.Windows.Forms.Button();
            this.izmjeni = new System.Windows.Forms.Button();
            this.obrisi = new System.Windows.Forms.Button();
            this.osvjezi = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Marka = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.MaxBrzina = new System.Windows.Forms.TextBox();
            this.Tezina = new System.Windows.Forms.TextBox();
            this.Tabela = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifikacioni broj";
            // 
            // sacuvaj
            // 
            this.sacuvaj.Location = new System.Drawing.Point(266, 432);
            this.sacuvaj.Name = "sacuvaj";
            this.sacuvaj.Size = new System.Drawing.Size(75, 23);
            this.sacuvaj.TabIndex = 1;
            this.sacuvaj.Text = "Sacuvaj";
            this.sacuvaj.UseVisualStyleBackColor = true;
            this.sacuvaj.Click += new System.EventHandler(this.sacuvaj_Click);
            // 
            // izmjeni
            // 
            this.izmjeni.Location = new System.Drawing.Point(362, 432);
            this.izmjeni.Name = "izmjeni";
            this.izmjeni.Size = new System.Drawing.Size(75, 23);
            this.izmjeni.TabIndex = 2;
            this.izmjeni.Text = "Izmjeni";
            this.izmjeni.UseVisualStyleBackColor = true;
            this.izmjeni.Click += new System.EventHandler(this.izmjeni_Click);
            // 
            // obrisi
            // 
            this.obrisi.Location = new System.Drawing.Point(458, 432);
            this.obrisi.Name = "obrisi";
            this.obrisi.Size = new System.Drawing.Size(75, 23);
            this.obrisi.TabIndex = 3;
            this.obrisi.Text = "Obrisi";
            this.obrisi.UseVisualStyleBackColor = true;
            this.obrisi.Click += new System.EventHandler(this.obrisi_Click);
            // 
            // osvjezi
            // 
            this.osvjezi.Location = new System.Drawing.Point(891, 432);
            this.osvjezi.Name = "osvjezi";
            this.osvjezi.Size = new System.Drawing.Size(75, 23);
            this.osvjezi.TabIndex = 4;
            this.osvjezi.Text = "Osvjezi";
            this.osvjezi.UseVisualStyleBackColor = true;
            this.osvjezi.Click += new System.EventHandler(this.osvjezi_Click);
            // 
            // izlaz
            // 
            this.izlaz.Location = new System.Drawing.Point(15, 432);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(75, 23);
            this.izlaz.TabIndex = 5;
            this.izlaz.Text = "Izlaz";
            this.izlaz.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Brzina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tezina";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(110, 19);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(140, 20);
            this.ID.TabIndex = 10;
            // 
            // Marka
            // 
            this.Marka.Location = new System.Drawing.Point(110, 52);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(140, 20);
            this.Marka.TabIndex = 11;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(110, 85);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(140, 20);
            this.Model.TabIndex = 12;
            // 
            // MaxBrzina
            // 
            this.MaxBrzina.Location = new System.Drawing.Point(110, 118);
            this.MaxBrzina.Name = "MaxBrzina";
            this.MaxBrzina.Size = new System.Drawing.Size(140, 20);
            this.MaxBrzina.TabIndex = 13;
            // 
            // Tezina
            // 
            this.Tezina.Location = new System.Drawing.Point(110, 151);
            this.Tezina.Name = "Tezina";
            this.Tezina.Size = new System.Drawing.Size(140, 20);
            this.Tezina.TabIndex = 14;
            // 
            // Tabela
            // 
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Location = new System.Drawing.Point(266, 12);
            this.Tabela.Name = "Tabela";
            this.Tabela.Size = new System.Drawing.Size(700, 414);
            this.Tabela.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 467);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.Tezina);
            this.Controls.Add(this.MaxBrzina);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.osvjezi);
            this.Controls.Add(this.obrisi);
            this.Controls.Add(this.izmjeni);
            this.Controls.Add(this.sacuvaj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sacuvaj;
        private System.Windows.Forms.Button izmjeni;
        private System.Windows.Forms.Button obrisi;
        private System.Windows.Forms.Button osvjezi;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Marka;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox MaxBrzina;
        private System.Windows.Forms.TextBox Tezina;
        private System.Windows.Forms.DataGridView Tabela;
    }
}

