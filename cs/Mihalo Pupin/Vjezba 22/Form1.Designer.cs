namespace Vjezba_22
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
            this.btnEngleski = new System.Windows.Forms.Button();
            this.btnDanski = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEngleski
            // 
            this.btnEngleski.Location = new System.Drawing.Point(12, 32);
            this.btnEngleski.Name = "btnEngleski";
            this.btnEngleski.Size = new System.Drawing.Size(112, 40);
            this.btnEngleski.TabIndex = 0;
            this.btnEngleski.Text = "Engleski";
            this.btnEngleski.UseVisualStyleBackColor = true;
            this.btnEngleski.Click += new System.EventHandler(this.btnEngleski_Click);
            // 
            // btnDanski
            // 
            this.btnDanski.Location = new System.Drawing.Point(159, 32);
            this.btnDanski.Name = "btnDanski";
            this.btnDanski.Size = new System.Drawing.Size(117, 40);
            this.btnDanski.TabIndex = 1;
            this.btnDanski.Text = "Danski";
            this.btnDanski.UseVisualStyleBackColor = true;
            this.btnDanski.Click += new System.EventHandler(this.btnDanski_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(89, 100);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 33);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 155);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDanski);
            this.Controls.Add(this.btnEngleski);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEngleski;
        private System.Windows.Forms.Button btnDanski;
        private System.Windows.Forms.Button btnOK;
    }
}

