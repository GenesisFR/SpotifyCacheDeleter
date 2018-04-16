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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReportBug = new System.Windows.Forms.Button();
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
            this.textBoxCacheLocation.Location = new System.Drawing.Point(98, 7);
            this.textBoxCacheLocation.Name = "textBoxCacheLocation";
            this.textBoxCacheLocation.ReadOnly = true;
            this.textBoxCacheLocation.Size = new System.Drawing.Size(350, 20);
            this.textBoxCacheLocation.TabIndex = 1;
            // 
            // buttonDeleteCache
            // 
            this.buttonDeleteCache.AutoSize = true;
            this.buttonDeleteCache.Location = new System.Drawing.Point(296, 143);
            this.buttonDeleteCache.Name = "buttonDeleteCache";
            this.buttonDeleteCache.Size = new System.Drawing.Size(81, 23);
            this.buttonDeleteCache.TabIndex = 10;
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
            this.labelDirectoryAge.TabIndex = 4;
            this.labelDirectoryAge.Text = "Delete folders older than";
            // 
            // dateTimePickerDirectoryAge
            // 
            this.dateTimePickerDirectoryAge.CustomFormat = "MMMM dd, yyyy - HH:mm";
            this.dateTimePickerDirectoryAge.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDirectoryAge.Location = new System.Drawing.Point(142, 66);
            this.dateTimePickerDirectoryAge.Name = "dateTimePickerDirectoryAge";
            this.dateTimePickerDirectoryAge.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDirectoryAge.TabIndex = 5;
            this.dateTimePickerDirectoryAge.ValueChanged += new System.EventHandler(this.DateTimePickerDirectoryAge_ValueChanged);
            // 
            // labelTotalCacheSize
            // 
            this.labelTotalCacheSize.AutoSize = true;
            this.labelTotalCacheSize.Location = new System.Drawing.Point(10, 40);
            this.labelTotalCacheSize.Name = "labelTotalCacheSize";
            this.labelTotalCacheSize.Size = new System.Drawing.Size(116, 13);
            this.labelTotalCacheSize.TabIndex = 3;
            this.labelTotalCacheSize.Text = "Total cache size: 0.0 B";
            // 
            // labelDeletedCacheSize
            // 
            this.labelDeletedCacheSize.AutoSize = true;
            this.labelDeletedCacheSize.Location = new System.Drawing.Point(10, 100);
            this.labelDeletedCacheSize.Name = "labelDeletedCacheSize";
            this.labelDeletedCacheSize.Size = new System.Drawing.Size(129, 13);
            this.labelDeletedCacheSize.TabIndex = 6;
            this.labelDeletedCacheSize.Text = "Deleted cache size: 0.0 B";
            // 
            // buttonOpenCacheFolder
            // 
            this.buttonOpenCacheFolder.AutoSize = true;
            this.buttonOpenCacheFolder.Location = new System.Drawing.Point(468, 5);
            this.buttonOpenCacheFolder.Name = "buttonOpenCacheFolder";
            this.buttonOpenCacheFolder.Size = new System.Drawing.Size(105, 24);
            this.buttonOpenCacheFolder.TabIndex = 2;
            this.buttonOpenCacheFolder.Text = "Open cache folder";
            this.buttonOpenCacheFolder.UseVisualStyleBackColor = true;
            this.buttonOpenCacheFolder.Click += new System.EventHandler(this.ButtonOpenCacheFolder_Click);
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.AllowDrop = true;
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.LinkArea = new System.Windows.Forms.LinkArea(16, 7);
            this.linkLabelAuthor.Location = new System.Drawing.Point(98, 149);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(130, 17);
            this.linkLabelAuthor.TabIndex = 8;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "v1.02 - Made by Genesis";
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
            // buttonRefresh
            // 
            this.buttonRefresh.AutoSize = true;
            this.buttonRefresh.Location = new System.Drawing.Point(234, 144);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(54, 23);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // buttonReportBug
            // 
            this.buttonReportBug.AutoSize = true;
            this.buttonReportBug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReportBug.Location = new System.Drawing.Point(13, 143);
            this.buttonReportBug.Name = "buttonReportBug";
            this.buttonReportBug.Size = new System.Drawing.Size(79, 23);
            this.buttonReportBug.TabIndex = 7;
            this.buttonReportBug.Text = "Report a bug";
            this.buttonReportBug.UseVisualStyleBackColor = true;
            this.buttonReportBug.Click += new System.EventHandler(this.ButtonReportBug_Click);
            // 
            // SpotifyDeleteCacheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 176);
            this.Controls.Add(this.buttonReportBug);
            this.Controls.Add(this.buttonRefresh);
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
            this.Load += new System.EventHandler(this.SpotifyDeleteCacheForm_Load);
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
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonReportBug;
    }
}

