using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpotifyDeleteCache
{
    public partial class SpotifyDeleteCacheForm : Form
    {
        private bool _isRefresh; // used to avoid showing more than one error message when clicking the Refresh button
        private string _spotifyCacheLocation;
        private string[] _cacheDirectoriesToDelete;

        public SpotifyDeleteCacheForm()
        {
            InitializeComponent();

            // Get cache folder location
            string localAppData   = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _spotifyCacheLocation = Path.Combine(localAppData, @"Spotify\Data");

            _cacheDirectoriesToDelete = new string[] { };
    }

    private void SpotifyDeleteCacheForm_Load(object sender, EventArgs e)
        {
            buttonRefresh.PerformClick();
        }

        private void ComputeTotalCacheSize()
        {
            labelTotalCacheSize.Text = $"Total cache size: { ReadableBytes(GetDirectorySize(_spotifyCacheLocation)) }";
        }

        private void ComputeDeletedCacheSize()
        {
            labelDeletedCacheSize.Text = $"Deleted cache size: { ReadableBytes(GetDirectorySize(_spotifyCacheLocation, false)) }";
        }

        private bool DeleteCacheDirectories()
        {
            bool allFoldersDeleted = true;

            foreach (string directory in _cacheDirectoriesToDelete)
            {
                try
                {
                    Directory.Delete(directory, true);
                }
                catch
                {
                    allFoldersDeleted = false;
                }
            }

            return allFoldersDeleted;
        }

        private bool FindSpotifyCacheLocation()
        {
            // Check if cache folder exists
            bool spotifyCacheFolderExists = Directory.Exists(_spotifyCacheLocation);

            // Update textboxes
            textBoxCacheLocation.Text  = _spotifyCacheLocation;
            labelTotalCacheSize.Text   = "Total cache size: 0.0 B";
            labelDeletedCacheSize.Text = "Deleted cache size: 0.0 B";

            // Toggle elements
            buttonOpenCacheFolder.Enabled      = spotifyCacheFolderExists;
            dateTimePickerDirectoryAge.Enabled = spotifyCacheFolderExists;
            buttonDeleteCache.Enabled          = spotifyCacheFolderExists;

            return spotifyCacheFolderExists;
        }

        private long GetDirectorySize(string path, bool computeTotalSize = true)
        {
            long size = 0;

            if (computeTotalSize)
            {
                string[] filenames;

                try
                {
                    filenames = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

                    foreach (string filename in filenames)
                        size += new FileInfo(filename).Length;
                }
                catch
                {
                    // Nothing to do here
                }
            }
            else
            {
                foreach (string directory in _cacheDirectoriesToDelete)
                    size += GetDirectorySize(directory);
            }

            return size;
        }

        private string[] GetOldCacheDirectories()
        {
            string[] oldCacheDirectories = new string[] { };

            try
            {
                oldCacheDirectories = Directory.GetDirectories(_spotifyCacheLocation)
                                      .Where(directory => new DirectoryInfo(directory).LastWriteTime < dateTimePickerDirectoryAge.Value)
                                      .Select(directory => directory).ToArray();
            }
            catch
            {
                // Nothing to do here
            }

            return oldCacheDirectories;
        }

        private string ReadableBytes(long bytes)
        {
            string[] sizes = new string[] { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            if (bytes == 0) return bytes.ToString("N2") + " " + sizes[0];

            double i = Math.Floor(Math.Log(bytes) / Math.Log(1024));
            return (bytes / Math.Pow(1024, i)).ToString("N2") + " " + sizes[(int)i];
        }

        private void UpdateCacheSize(bool computeTotalSize = false)
        {
            if (Directory.Exists(_spotifyCacheLocation))
            {
                _cacheDirectoriesToDelete = GetOldCacheDirectories();

                if (computeTotalSize)
                    ComputeTotalCacheSize();

                ComputeDeletedCacheSize();
            }
            else if (!_isRefresh)
                MessageBox.Show("The Spofify cache folder no longer exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Event handlers
        private void ButtonDeleteCache_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(_spotifyCacheLocation))
            {
                string text;
                MessageBoxIcon icon;

                if (DeleteCacheDirectories())
                {
                    text = "The Spofify cache has been deleted!";
                    icon = MessageBoxIcon.Information;
                }
                else
                {
                    text = "The Spofify cache has been deleted, but some folder couldn't be deleted.";
                    icon = MessageBoxIcon.Warning;
                }

                MessageBox.Show(text, "Success", MessageBoxButtons.OK, icon);
                UpdateCacheSize(true);
            }
            else if (!_isRefresh)
                MessageBox.Show("The Spofify cache folder no longer exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ButtonOpenCacheFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(_spotifyCacheLocation);
            }
            catch
            {
                MessageBox.Show("The Spofify cache folder no longer exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            _isRefresh = true;

            if (FindSpotifyCacheLocation())
                UpdateCacheSize(true);
            else
                MessageBox.Show("The Spofify cache folder wasn't found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            _isRefresh = false;
        }

        private void ButtonReportBug_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/GenesisFR/SpotifyDeleteCache/issues");
        }

        private void DateTimePickerDirectoryAge_ValueChanged(object sender, EventArgs e)
        {
            UpdateCacheSize();
        }

        private void LinkLabelAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/GenesisFR");
        }

        private void PictureBoxKappa_Click(object sender, EventArgs e)
        {
            Process.Start("http://knowyourmeme.com/memes/kappa");
        }
    }
}
