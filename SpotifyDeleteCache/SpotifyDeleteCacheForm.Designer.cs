namespace SpotifyDeleteCache
{
    partial class SpotifyDeleteCacheForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpotifyDeleteCacheForm));
            this.labelCacheLocation = new System.Windows.Forms.Label();
            this.textBoxCacheLocation = new System.Windows.Forms.TextBox();
            this.buttonDeleteCache = new System.Windows.Forms.Button();
            this.labelDirectoryAge = new System.Windows.Forms.Label();
            this.dateTimePickerDirectoryAge = new System.Windows.Forms.DateTimePicker();
            this.labelTotalCacheSize = new System.Windows.Forms.Label();
            this.labelDeletedCacheSize = new System.Windows.Forms.Label();
            this.buttonOpenCacheFolder = new System.Windows.Forms.Button();
            this.linkLabelAuthor = new System.Windows.Forms.LinkLabel();
            this.pictureBoxKappa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKappa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCacheLocation
            // 
            this.labelCacheLocation.AutoSize = true;
            this.labelCacheLocation.Location = new System.Drawing.Point(10, 10);
            this.labelCacheLocation.Name = "labelCacheLocation";
            this.labelCacheLocation.Size = new System.Drawing.Size(78, 13);
            this.labelCacheLocation.TabIndex = 0;
            this.labelCacheLocation.Text = "Cache location";
            // 
            // textBoxCacheLocation
            // 
            this.textBoxCacheLocation.Location = new System.Drawing.Point(175, 7);
            this.textBoxCacheLocation.Name = "textBoxCacheLocation";
            this.textBoxCacheLocation.ReadOnly = true;
            this.textBoxCacheLocation.Size = new System.Drawing.Size(400, 20);
            this.textBoxCacheLocation.TabIndex = 1;
            // 
            // buttonDeleteCache
            // 
            this.buttonDeleteCache.Location = new System.Drawing.Point(298, 145);
            this.buttonDeleteCache.Name = "buttonDeleteCache";
            this.buttonDeleteCache.Size = new System.Drawing.Size(79, 23);
            this.buttonDeleteCache.TabIndex = 8;
            this.buttonDeleteCache.Text = "Delete cache";
            this.buttonDeleteCache.UseVisualStyleBackColor = true;
            this.buttonDeleteCache.Click += new System.EventHandler(this.ButtonDeleteCache_Click);
            // 
            // labelDirectoryAge
            // 
            this.labelDirectoryAge.AutoSize = true;
            this.labelDirectoryAge.Location = new System.Drawing.Point(10, 70);
            this.labelDirectoryAge.Name = "labelDirectoryAge";
            this.labelDirectoryAge.Size = new System.Drawing.Size(122, 13);
            this.labelDirectoryAge.TabIndex = 3;
            this.labelDirectoryAge.Text = "Delete folders older than";
            // 
            // dateTimePickerDirectoryAge
            // 
            this.dateTimePickerDirectoryAge.CustomFormat = "MMMM dd, yyyy - HH:mm";
            this.dateTimePickerDirectoryAge.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDirectoryAge.Location = new System.Drawing.Point(175, 66);
            this.dateTimePickerDirectoryAge.Name = "dateTimePickerDirectoryAge";
            this.dateTimePickerDirectoryAge.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDirectoryAge.TabIndex = 4;
            this.dateTimePickerDirectoryAge.ValueChanged += new System.EventHandler(this.DateTimePickerDirectoryAge_ValueChanged);
            // 
            // labelTotalCacheSize
            // 
            this.labelTotalCacheSize.AutoSize = true;
            this.labelTotalCacheSize.Location = new System.Drawing.Point(10, 40);
            this.labelTotalCacheSize.Name = "labelTotalCacheSize";
            this.labelTotalCacheSize.Size = new System.Drawing.Size(121, 13);
            this.labelTotalCacheSize.TabIndex = 2;
            this.labelTotalCacheSize.Text = "Total cache size: 0.0GB";
            // 
            // labelDeletedCacheSize
            // 
            this.labelDeletedCacheSize.AutoSize = true;
            this.labelDeletedCacheSize.Location = new System.Drawing.Point(10, 100);
            this.labelDeletedCacheSize.Name = "labelDeletedCacheSize";
            this.labelDeletedCacheSize.Size = new System.Drawing.Size(134, 13);
            this.labelDeletedCacheSize.TabIndex = 5;
            this.labelDeletedCacheSize.Text = "Deleted cache size: 0.0GB";
            // 
            // buttonOpenCacheFolder
            // 
            this.buttonOpenCacheFolder.Location = new System.Drawing.Point(175, 145);
            this.buttonOpenCacheFolder.Name = "buttonOpenCacheFolder";
            this.buttonOpenCacheFolder.Size = new System.Drawing.Size(103, 23);
            this.buttonOpenCacheFolder.TabIndex = 7;
            this.buttonOpenCacheFolder.Text = "Open cache folder";
            this.buttonOpenCacheFolder.UseVisualStyleBackColor = true;
            this.buttonOpenCacheFolder.Click += new System.EventHandler(this.ButtonOpenCacheFolder_Click);
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.AllowDrop = true;
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.LinkArea = new System.Windows.Forms.LinkArea(8, 7);
            this.linkLabelAuthor.Location = new System.Drawing.Point(10, 150);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(92, 17);
            this.linkLabelAuthor.TabIndex = 44;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "Made by Genesis";
            this.linkLabelAuthor.UseCompatibleTextRendering = true;
            this.linkLabelAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAuthor_LinkClicked);
            // 
            // pictureBoxKappa
            // 
            this.pictureBoxKappa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKappa.Image")));
            this.pictureBoxKappa.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxKappa.InitialImage")));
            this.pictureBoxKappa.Location = new System.Drawing.Point(383, 59);
            this.pictureBoxKappa.Name = "pictureBoxKappa";
            this.pictureBoxKappa.Size = new System.Drawing.Size(192, 108);
            this.pictureBoxKappa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKappa.TabIndex = 45;
            this.pictureBoxKappa.TabStop = false;
            this.pictureBoxKappa.Visible = false;
            this.pictureBoxKappa.WaitOnLoad = true;
            this.pictureBoxKappa.Click += new System.EventHandler(this.PictureBoxKappa_Click);
            // 
            // SpotifyDeleteCacheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 176);
            this.Controls.Add(this.pictureBoxKappa);
            this.Controls.Add(this.linkLabelAuthor);
            this.Controls.Add(this.buttonOpenCacheFolder);
            this.Controls.Add(this.labelDeletedCacheSize);
            this.Controls.Add(this.labelTotalCacheSize);
            this.Controls.Add(this.dateTimePickerDirectoryAge);
            this.Controls.Add(this.labelDirectoryAge);
            this.Controls.Add(this.buttonDeleteCache);
            this.Controls.Add(this.textBoxCacheLocation);
            this.Controls.Add(this.labelCacheLocation);
            this.MaximizeBox = false;
            this.Name = "SpotifyDeleteCacheForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotifyDeleteCache";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKappa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCacheLocation;
        private System.Windows.Forms.TextBox textBoxCacheLocation;
        private System.Windows.Forms.Button buttonDeleteCache;
        private System.Windows.Forms.Label labelDirectoryAge;
        private System.Windows.Forms.DateTimePicker dateTimePickerDirectoryAge;
        private System.Windows.Forms.Label labelTotalCacheSize;
        private System.Windows.Forms.Label labelDeletedCacheSize;
        private System.Windows.Forms.Button buttonOpenCacheFolder;
        private System.Windows.Forms.LinkLabel linkLabelAuthor;
        private System.Windows.Forms.PictureBox pictureBoxKappa;
    }
}

