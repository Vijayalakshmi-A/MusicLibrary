namespace MusicLibrary
{
    partial class frmAddorSearchItems
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtComposer = new System.Windows.Forms.TextBox();
            this.lblComposer = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(110, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title Name";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(227, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(227, 61);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(100, 20);
            this.txtAlbum.TabIndex = 3;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(110, 64);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(67, 13);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Album Name";
            // 
            // txtComposer
            // 
            this.txtComposer.Location = new System.Drawing.Point(227, 100);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(100, 20);
            this.txtComposer.TabIndex = 5;
            // 
            // lblComposer
            // 
            this.lblComposer.AutoSize = true;
            this.lblComposer.Location = new System.Drawing.Point(110, 103);
            this.lblComposer.Name = "lblComposer";
            this.lblComposer.Size = new System.Drawing.Size(85, 13);
            this.lblComposer.TabIndex = 4;
            this.lblComposer.Text = "Composer Name";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(110, 137);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(78, 13);
            this.lblReleaseDate.TabIndex = 6;
            this.lblReleaseDate.Text = "Released Date";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(227, 172);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 20);
            this.txtArtist.TabIndex = 9;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(110, 175);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(61, 13);
            this.lblArtist.TabIndex = 8;
            this.lblArtist.Text = "Artist Name";
            // 
            // dtpRelease
            // 
            this.dtpRelease.CustomFormat = "";
            this.dtpRelease.Location = new System.Drawing.Point(227, 135);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(155, 20);
            this.dtpRelease.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(110, 208);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(54, 13);
            this.lblFile.TabIndex = 14;
            this.lblFile.Text = "File Name";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(227, 208);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(230, 20);
            this.txtFile.TabIndex = 15;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(482, 206);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 17;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(349, 266);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(75, 23);
            this.btnAddClose.TabIndex = 18;
            this.btnAddClose.Text = "Close";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // frmAddorSearchItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 325);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.txtComposer);
            this.Controls.Add(this.lblComposer);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddorSearchItems";
            this.Text = "frmAddorSearchItems";
            this.Load += new System.EventHandler(this.frmAddorSearchItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtComposer;
        private System.Windows.Forms.Label lblComposer;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnAddClose;
    }
}