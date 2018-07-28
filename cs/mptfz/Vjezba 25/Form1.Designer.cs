namespace Vjezba_25
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
            this.btnPrebaci = new System.Windows.Forms.Button();
            this.chkListaIzbora = new System.Windows.Forms.CheckedListBox();
            this.lstSelektovani = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPrebaci
            // 
            this.btnPrebaci.Location = new System.Drawing.Point(152, 80);
            this.btnPrebaci.Name = "btnPrebaci";
            this.btnPrebaci.Size = new System.Drawing.Size(75, 23);
            this.btnPrebaci.TabIndex = 0;
            this.btnPrebaci.Text = "Prebaci";
            this.btnPrebaci.UseVisualStyleBackColor = true;
            this.btnPrebaci.Click += new System.EventHandler(this.btnPrebaci_Click);
            // 
            // chkListaIzbora
            // 
            this.chkListaIzbora.CheckOnClick = true;
            this.chkListaIzbora.FormattingEnabled = true;
            this.chkListaIzbora.Items.AddRange(new object[] {
            "jedan",
            "dva",
            "tri",
            "cetiri",
            "pet",
            "sest",
            "sedam",
            "osam",
            "devet"});
            this.chkListaIzbora.Location = new System.Drawing.Point(8, 8);
            this.chkListaIzbora.Name = "chkListaIzbora";
            this.chkListaIzbora.Size = new System.Drawing.Size(136, 184);
            this.chkListaIzbora.TabIndex = 1;
            // 
            // lstSelektovani
            // 
            this.lstSelektovani.FormattingEnabled = true;
            this.lstSelektovani.Location = new System.Drawing.Point(232, 8);
            this.lstSelektovani.Name = "lstSelektovani";
            this.lstSelektovani.Size = new System.Drawing.Size(136, 186);
            this.lstSelektovani.TabIndex = 2;
            // 
            // fclsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 199);
            this.Controls.Add(this.lstSelektovani);
            this.Controls.Add(this.chkListaIzbora);
            this.Controls.Add(this.btnPrebaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fclsMain";
            this.Text = "Kontrola ListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrebaci;
        private System.Windows.Forms.CheckedListBox chkListaIzbora;
        private System.Windows.Forms.ListBox lstSelektovani;
    }
}

