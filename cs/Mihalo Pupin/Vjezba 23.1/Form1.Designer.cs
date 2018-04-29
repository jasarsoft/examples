namespace Vjezba_23._1
{
    partial class fclsMain
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtGodiste = new System.Windows.Forms.TextBox();
            this.txtIzlaz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.chkProgramer = new System.Windows.Forms.CheckBox();
            this.grpPol = new System.Windows.Forms.GroupBox();
            this.rdoMusko = new System.Windows.Forms.RadioButton();
            this.rdoZensko = new System.Windows.Forms.RadioButton();
            this.grpPol.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIme.Location = new System.Drawing.Point(104, 16);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(296, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresa.Location = new System.Drawing.Point(104, 46);
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdresa.Size = new System.Drawing.Size(296, 136);
            this.txtAdresa.TabIndex = 1;
            // 
            // txtGodiste
            // 
            this.txtGodiste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGodiste.Location = new System.Drawing.Point(104, 300);
            this.txtGodiste.Name = "txtGodiste";
            this.txtGodiste.Size = new System.Drawing.Size(72, 20);
            this.txtGodiste.TabIndex = 3;
            // 
            // txtIzlaz
            // 
            this.txtIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIzlaz.Location = new System.Drawing.Point(0, 344);
            this.txtIzlaz.Multiline = true;
            this.txtIzlaz.Name = "txtIzlaz";
            this.txtIzlaz.ReadOnly = true;
            this.txtIzlaz.Size = new System.Drawing.Size(512, 91);
            this.txtIzlaz.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime Prezime:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Godina:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Izlaz:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(415, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.CausesValidation = false;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Location = new System.Drawing.Point(415, 48);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzlaz.Location = new System.Drawing.Point(416, 128);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 12;
            this.btnIzlaz.Text = "&Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            // 
            // chkProgramer
            // 
            this.chkProgramer.AutoSize = true;
            this.chkProgramer.Location = new System.Drawing.Point(104, 189);
            this.chkProgramer.Name = "chkProgramer";
            this.chkProgramer.Size = new System.Drawing.Size(74, 17);
            this.chkProgramer.TabIndex = 13;
            this.chkProgramer.Text = "Programer";
            this.chkProgramer.UseVisualStyleBackColor = true;
            // 
            // grpPol
            // 
            this.grpPol.Controls.Add(this.rdoZensko);
            this.grpPol.Controls.Add(this.rdoMusko);
            this.grpPol.Location = new System.Drawing.Point(104, 212);
            this.grpPol.Name = "grpPol";
            this.grpPol.Size = new System.Drawing.Size(296, 82);
            this.grpPol.TabIndex = 14;
            this.grpPol.TabStop = false;
            this.grpPol.Text = "Pol";
            // 
            // rdoMusko
            // 
            this.rdoMusko.AutoSize = true;
            this.rdoMusko.Location = new System.Drawing.Point(19, 37);
            this.rdoMusko.Name = "rdoMusko";
            this.rdoMusko.Size = new System.Drawing.Size(57, 17);
            this.rdoMusko.TabIndex = 0;
            this.rdoMusko.Text = "Musko";
            this.rdoMusko.UseVisualStyleBackColor = true;
            // 
            // rdoZensko
            // 
            this.rdoZensko.AutoSize = true;
            this.rdoZensko.Location = new System.Drawing.Point(181, 37);
            this.rdoZensko.Name = "rdoZensko";
            this.rdoZensko.Size = new System.Drawing.Size(61, 17);
            this.rdoZensko.TabIndex = 1;
            this.rdoZensko.Text = "Zensko";
            this.rdoZensko.UseVisualStyleBackColor = true;
            // 
            // fclsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 429);
            this.Controls.Add(this.grpPol);
            this.Controls.Add(this.chkProgramer);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIzlaz);
            this.Controls.Add(this.txtGodiste);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtIme);
            this.MinimumSize = new System.Drawing.Size(520, 432);
            this.Name = "fclsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primjer TextBox-a";
            this.grpPol.ResumeLayout(false);
            this.grpPol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtGodiste;
        private System.Windows.Forms.TextBox txtIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.CheckBox chkProgramer;
        private System.Windows.Forms.GroupBox grpPol;
        private System.Windows.Forms.RadioButton rdoZensko;
        private System.Windows.Forms.RadioButton rdoMusko;
    }
}

