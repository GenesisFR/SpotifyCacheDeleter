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
            this.labelBrowserCacheLocation = new System.Windows.Forms.Label();
            this.textBoxBrowserCacheLocation = new System.Windows.Forms.TextBox();
            this.buttonDeleteCache = new System.Windows.Forms.Button();
            this.labelDirectoryAge = new System.Windows.Forms.Label();
            this.dateTimePickerDirectoryAge = new System.Windows.Forms.DateTimePicker();
            this.labelTotalCacheSize = new System.Windows.Forms.Label();
            this.labelDeletedCacheSize = new System.Windows.Forms.Label();
            this.buttonOpenBrowserCacheFolder = new System.Windows.Forms.Button();
            this.pictureBoxKappa = new System.Windows.Forms.PictureBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReportBug = new System.Windows.Forms.Button();
            this.buttonOpenDataCacheFolder = new System.Windows.Forms.Button();
            this.textBoxDataCacheLocation = new System.Windows.Forms.TextBox();
            this.labelDataCacheLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKappa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBrowserCacheLocation
            // 
            this.labelBrowserCacheLocation.AutoSize = true;
            this.labelBrowserCacheLocation.Location = new System.Drawing.Point(10, 10);
            this.labelBrowserCacheLocation.Name = "labelBrowserCacheLocation";
            this.labelBrowserCacheLocation.Size = new System.Drawing.Size(118, 13);
            this.labelBrowserCacheLocation.TabIndex = 0;
            this.labelBrowserCacheLocation.Text = "Browser cache location";
            // 
            // textBoxBrowserCacheLocation
            // 
            this.textBoxBrowserCacheLocation.Location = new System.Drawing.Point(142, 7);
            this.textBoxBrowserCacheLocation.Name = "textBoxBrowserCacheLocation";
            this.textBoxBrowserCacheLocation.ReadOnly = true;
            this.textBoxBrowserCacheLocation.Size = new System.Drawing.Size(352, 20);
            this.textBoxBrowserCacheLocation.TabIndex = 1;
            // 
            // buttonDeleteCache
            // 
            this.buttonDeleteCache.AutoSize = true;
            this.buttonDeleteCache.Location = new System.Drawing.Point(158, 148);
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
            this.labelDirectoryAge.Location = new System.Drawing.Point(10, 95);
            this.labelDirectoryAge.Name = "labelDirectoryAge";
            this.labelDirectoryAge.Size = new System.Drawing.Size(122, 13);
            this.labelDirectoryAge.TabIndex = 4;
            this.labelDirectoryAge.Text = "Delete folders older than";
            // 
            // dateTimePickerDirectoryAge
            // 
            this.dateTimePickerDirectoryAge.CustomFormat = "MMMM dd, yyyy - HH:mm";
            this.dateTimePickerDirectoryAge.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDirectoryAge.Location = new System.Drawing.Point(142, 92);
            this.dateTimePickerDirectoryAge.Name = "dateTimePickerDirectoryAge";
            this.dateTimePickerDirectoryAge.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDirectoryAge.TabIndex = 5;
            this.dateTimePickerDirectoryAge.ValueChanged += new System.EventHandler(this.DateTimePickerDirectoryAge_ValueChanged);
            // 
            // labelTotalCacheSize
            // 
            this.labelTotalCacheSize.AutoSize = true;
            this.labelTotalCacheSize.Location = new System.Drawing.Point(10, 65);
            this.labelTotalCacheSize.Name = "labelTotalCacheSize";
            this.labelTotalCacheSize.Size = new System.Drawing.Size(116, 13);
            this.labelTotalCacheSize.TabIndex = 3;
            this.labelTotalCacheSize.Text = "Total cache size: 0.0 B";
            // 
            // labelDeletedCacheSize
            // 
            this.labelDeletedCacheSize.AutoSize = true;
            this.labelDeletedCacheSize.Location = new System.Drawing.Point(10, 125);
            this.labelDeletedCacheSize.Name = "labelDeletedCacheSize";
            this.labelDeletedCacheSize.Size = new System.Drawing.Size(129, 13);
            this.labelDeletedCacheSize.TabIndex = 6;
            this.labelDeletedCacheSize.Text = "Deleted cache size: 0.0 B";
            // 
            // buttonOpenBrowserCacheFolder
            // 
            this.buttonOpenBrowserCacheFolder.AutoSize = true;
            this.buttonOpenBrowserCacheFolder.Location = new System.Drawing.Point(500, 5);
            this.buttonOpenBrowserCacheFolder.Name = "buttonOpenBrowserCacheFolder";
            this.buttonOpenBrowserCacheFolder.Size = new System.Drawing.Size(73, 24);
            this.buttonOpenBrowserCacheFolder.TabIndex = 2;
            this.buttonOpenBrowserCacheFolder.Text = "Open folder";
            this.buttonOpenBrowserCacheFolder.UseVisualStyleBackColor = true;
            this.buttonOpenBrowserCacheFolder.Click += new System.EventHandler(this.ButtonOpenBrowserCacheFolder_Click);
            // 
            // pictureBoxKappa
            // 
            this.pictureBoxKappa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKappa.Image")));
            this.pictureBoxKappa.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxKappa.InitialImage")));
            this.pictureBoxKappa.Location = new System.Drawing.Point(380, 62);
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
            this.buttonRefresh.Location = new System.Drawing.Point(98, 148);
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
            this.buttonReportBug.Location = new System.Drawing.Point(13, 148);
            this.buttonReportBug.Name = "buttonReportBug";
            this.buttonReportBug.Size = new System.Drawing.Size(79, 23);
            this.buttonReportBug.TabIndex = 7;
            this.buttonReportBug.Text = "Report a bug";
            this.buttonReportBug.UseVisualStyleBackColor = true;
            this.buttonReportBug.Click += new System.EventHandler(this.ButtonReportBug_Click);
            // 
            // buttonOpenDataCacheFolder
            // 
            this.buttonOpenDataCacheFolder.AutoSize = true;
            this.buttonOpenDataCacheFolder.Location = new System.Drawing.Point(500, 31);
            this.buttonOpenDataCacheFolder.Name = "buttonOpenDataCacheFolder";
            this.buttonOpenDataCacheFolder.Size = new System.Drawing.Size(73, 24);
            this.buttonOpenDataCacheFolder.TabIndex = 48;
            this.buttonOpenDataCacheFolder.Text = "Open folder";
            this.buttonOpenDataCacheFolder.UseVisualStyleBackColor = true;
            this.buttonOpenDataCacheFolder.Click += new System.EventHandler(this.ButtonOpenDataCacheFolder_Click);
            // 
            // textBoxDataCacheLocation
            // 
            this.textBoxDataCacheLocation.Location = new System.Drawing.Point(142, 33);
            this.textBoxDataCacheLocation.Name = "textBoxDataCacheLocation";
            this.textBoxDataCacheLocation.ReadOnly = true;
            this.textBoxDataCacheLocation.Size = new System.Drawing.Size(352, 20);
            this.textBoxDataCacheLocation.TabIndex = 47;
            // 
            // labelDataCacheLocation
            // 
            this.labelDataCacheLocation.AutoSize = true;
            this.labelDataCacheLocation.Location = new System.Drawing.Point(10, 36);
            this.labelDataCacheLocation.Name = "labelDataCacheLocation";
            this.labelDataCacheLocation.Size = new System.Drawing.Size(103, 13);
            this.labelDataCacheLocation.TabIndex = 46;
            this.labelDataCacheLocation.Text = "Data cache location";
            // 
            // SpotifyDeleteCacheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 176);
            this.Controls.Add(this.buttonOpenDataCacheFolder);
            this.Controls.Add(this.textBoxDataCacheLocation);
            this.Controls.Add(this.labelDataCacheLocation);
            this.Controls.Add(this.buttonReportBug);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.pictureBoxKappa);
            this.Controls.Add(this.buttonOpenBrowserCacheFolder);
            this.Controls.Add(this.labelDeletedCacheSize);
            this.Controls.Add(this.labelTotalCacheSize);
            this.Controls.Add(this.dateTimePickerDirectoryAge);
            this.Controls.Add(this.labelDirectoryAge);
            this.Controls.Add(this.buttonDeleteCache);
            this.Controls.Add(this.textBoxBrowserCacheLocation);
            this.Controls.Add(this.labelBrowserCacheLocation);
            this.MaximizeBox = false;
            this.Name = "SpotifyDeleteCacheForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotifyDeleteCache v1.02";
            this.Load += new System.EventHandler(this.SpotifyDeleteCacheForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKappa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBrowserCacheLocation;
        private System.Windows.Forms.TextBox textBoxBrowserCacheLocation;
        private System.Windows.Forms.Button buttonDeleteCache;
        private System.Windows.Forms.Label labelDirectoryAge;
        private System.Windows.Forms.DateTimePicker dateTimePickerDirectoryAge;
        private System.Windows.Forms.Label labelTotalCacheSize;
        private System.Windows.Forms.Label labelDeletedCacheSize;
        private System.Windows.Forms.Button buttonOpenBrowserCacheFolder;
        private System.Windows.Forms.PictureBox pictureBoxKappa;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonReportBug;
        private System.Windows.Forms.Button buttonOpenDataCacheFolder;
        private System.Windows.Forms.TextBox textBoxDataCacheLocation;
        private System.Windows.Forms.Label labelDataCacheLocation;
    }
}

