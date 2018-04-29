namespace Vjezba_27
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fclsMain));
            this.lblTrenutnaPutanja = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.groPregledMod = new System.Windows.Forms.GroupBox();
            this.rdoLargeIcon = new System.Windows.Forms.RadioButton();
            this.rdoSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.rdoDetails = new System.Windows.Forms.RadioButton();
            this.ilMaleIkone = new System.Windows.Forms.ImageList(this.components);
            this.ilVelikeIkone = new System.Windows.Forms.ImageList(this.components);
            this.lwFajloviFolder = new System.Windows.Forms.ListView();
            this.groPregledMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrenutnaPutanja
            // 
            this.lblTrenutnaPutanja.Location = new System.Drawing.Point(16, 8);
            this.lblTrenutnaPutanja.Name = "lblTrenutnaPutanja";
            this.lblTrenutnaPutanja.Size = new System.Drawing.Size(528, 16);
            this.lblTrenutnaPutanja.TabIndex = 0;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(240, 256);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // groPregledMod
            // 
            this.groPregledMod.Controls.Add(this.rdoDetails);
            this.groPregledMod.Controls.Add(this.rdoList);
            this.groPregledMod.Controls.Add(this.rdoSmallIcon);
            this.groPregledMod.Controls.Add(this.rdoLargeIcon);
            this.groPregledMod.Location = new System.Drawing.Point(424, 32);
            this.groPregledMod.Name = "groPregledMod";
            this.groPregledMod.Size = new System.Drawing.Size(120, 128);
            this.groPregledMod.TabIndex = 2;
            this.groPregledMod.TabStop = false;
            this.groPregledMod.Text = "Pregled Mod";
            // 
            // rdoLargeIcon
            // 
            this.rdoLargeIcon.AutoSize = true;
            this.rdoLargeIcon.Location = new System.Drawing.Point(8, 24);
            this.rdoLargeIcon.Name = "rdoLargeIcon";
            this.rdoLargeIcon.Size = new System.Drawing.Size(83, 17);
            this.rdoLargeIcon.TabIndex = 0;
            this.rdoLargeIcon.TabStop = true;
            this.rdoLargeIcon.Text = "Velike ikone";
            this.rdoLargeIcon.UseVisualStyleBackColor = true;
            this.rdoLargeIcon.CheckedChanged += new System.EventHandler(this.rdoLargeIcon_CheckedChanged);
            // 
            // rdoSmallIcon
            // 
            this.rdoSmallIcon.AutoSize = true;
            this.rdoSmallIcon.Location = new System.Drawing.Point(8, 48);
            this.rdoSmallIcon.Name = "rdoSmallIcon";
            this.rdoSmallIcon.Size = new System.Drawing.Size(77, 17);
            this.rdoSmallIcon.TabIndex = 1;
            this.rdoSmallIcon.TabStop = true;
            this.rdoSmallIcon.Text = "Male ikone";
            this.rdoSmallIcon.UseVisualStyleBackColor = true;
            this.rdoSmallIcon.CheckedChanged += new System.EventHandler(this.rdoSmallIcon_CheckedChanged);
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Location = new System.Drawing.Point(8, 72);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(79, 17);
            this.rdoList.TabIndex = 2;
            this.rdoList.TabStop = true;
            this.rdoList.Text = "List pregled";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // rdoDetails
            // 
            this.rdoDetails.AutoSize = true;
            this.rdoDetails.Location = new System.Drawing.Point(8, 96);
            this.rdoDetails.Name = "rdoDetails";
            this.rdoDetails.Size = new System.Drawing.Size(90, 17);
            this.rdoDetails.TabIndex = 3;
            this.rdoDetails.TabStop = true;
            this.rdoDetails.Text = "Detalj pregled";
            this.rdoDetails.UseVisualStyleBackColor = true;
            this.rdoDetails.CheckedChanged += new System.EventHandler(this.rdoDetails_CheckedChanged);
            // 
            // ilMaleIkone
            // 
            this.ilMaleIkone.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMaleIkone.ImageStream")));
            this.ilMaleIkone.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMaleIkone.Images.SetKeyName(0, "folder.ico");
            this.ilMaleIkone.Images.SetKeyName(1, "file.ico");
            // 
            // ilVelikeIkone
            // 
            this.ilVelikeIkone.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilVelikeIkone.ImageStream")));
            this.ilVelikeIkone.TransparentColor = System.Drawing.Color.Transparent;
            this.ilVelikeIkone.Images.SetKeyName(0, "folder.ico");
            this.ilVelikeIkone.Images.SetKeyName(1, "file.ico");
            // 
            // lwFajloviFolder
            // 
            this.lwFajloviFolder.LargeImageList = this.ilVelikeIkone;
            this.lwFajloviFolder.Location = new System.Drawing.Point(12, 12);
            this.lwFajloviFolder.Name = "lwFajloviFolder";
            this.lwFajloviFolder.Size = new System.Drawing.Size(406, 238);
            this.lwFajloviFolder.SmallImageList = this.ilMaleIkone;
            this.lwFajloviFolder.TabIndex = 3;
            this.lwFajloviFolder.UseCompatibleStateImageBehavior = false;
            this.lwFajloviFolder.View = System.Windows.Forms.View.List;
            this.lwFajloviFolder.ItemActivate += new System.EventHandler(this.lwFajloviFolder_ItemActivate);
            // 
            // fclsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 287);
            this.Controls.Add(this.lwFajloviFolder);
            this.Controls.Add(this.groPregledMod);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblTrenutnaPutanja);
            this.Name = "fclsMain";
            this.Text = "Kontrola Listview";
            this.groPregledMod.ResumeLayout(false);
            this.groPregledMod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrenutnaPutanja;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.GroupBox groPregledMod;
        private System.Windows.Forms.RadioButton rdoDetails;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.RadioButton rdoSmallIcon;
        private System.Windows.Forms.RadioButton rdoLargeIcon;
        private System.Windows.Forms.ImageList ilMaleIkone;
        private System.Windows.Forms.ImageList ilVelikeIkone;
        private System.Windows.Forms.ListView lwFajloviFolder;
    }
}

