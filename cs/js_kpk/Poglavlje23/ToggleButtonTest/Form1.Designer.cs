namespace ToggleButtonTest
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
            this.toogleButton1 = new SubclassedControl.ToogleButton();
            this.SuspendLayout();
            // 
            // toogleButton1
            // 
            this.toogleButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.toogleButton1.AutoSize = true;
            this.toogleButton1.BackColor = System.Drawing.Color.Red;
            this.toogleButton1.CheckedColor = System.Drawing.Color.Green;
            this.toogleButton1.CheckedText = "Off";
            this.toogleButton1.ForeColor = System.Drawing.Color.White;
            this.toogleButton1.Location = new System.Drawing.Point(112, 106);
            this.toogleButton1.Name = "toogleButton1";
            this.toogleButton1.Size = new System.Drawing.Size(31, 23);
            this.toogleButton1.TabIndex = 0;
            this.toogleButton1.Text = "Off";
            this.toogleButton1.UncheckedColor = System.Drawing.Color.Red;
            this.toogleButton1.UncheckedText = "Unchecked";
            this.toogleButton1.UseVisualStyleBackColor = false;
            this.toogleButton1.Click += new System.EventHandler(this.toogleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.toogleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SubclassedControl.ToogleButton toogleButton1;
    }
}

