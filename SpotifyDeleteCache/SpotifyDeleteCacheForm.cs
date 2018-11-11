using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpotifyDeleteCache
{
    public partial class SpotifyDeleteCacheForm : Form
    {
        private bool _hideWarnings; // used to avoid showing too many warnings
        private string _spotifyBrowserCacheLocation;
        private string _spotifyDataCacheLocation;
        private string[] _cacheFilesToDelete;
        private string[] _cacheDirectoriesToDelete;

        public SpotifyDeleteCacheForm()
        {
            InitializeComponent();

            // Get cache folders location
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _spotifyBrowserCacheLocation = Path.Combine(localAppData, @"Spotify\Browser\Cache");
            _spotifyDataCacheLocation = Path.Combine(localAppData, @"Spotify\Data");

            _cacheFilesToDelete = new string[] { };
            _cacheDirectoriesToDelete = new string[] { };
        }

        private void SpotifyDeleteCacheForm_Load(object sender, EventArgs e)
        {
            pictureBoxKappa.Visible = Environment.GetCommandLineArgs().Length > 1 && Environment.GetCommandLineArgs()[1] == "-kappa";
            buttonRefresh.PerformClick();
        }

        private void ComputeTotalCacheSize()
        {
            long totalCacheSize = GetDirectorySize(_spotifyBrowserCacheLocation) + GetDirectorySize(_spotifyDataCacheLocation);
            labelTotalCacheSize.Text = $"Total cache size: { ReadableBytes(totalCacheSize) }";
        }

        private void ComputeDeletedCacheSize()
        {
            long deletedCacheSize = GetDirectorySize(_spotifyBrowserCacheLocation, false) +
                GetDirectorySize(_spotifyDataCacheLocation, false);
            labelDeletedCacheSize.Text = $"Deleted cache size: { ReadableBytes(deletedCacheSize) }";
        }

        private bool DeleteCacheDirectories()
        {
            bool allFilesDeleted = true;
            bool allFoldersDeleted = true;

            // Delete cache files
            foreach (string file in _cacheFilesToDelete)
            {
                try
                {
                    File.Delete(file);
                }
                catch
                {
                    allFilesDeleted = false;
                }
            }

            // Delete cache directories
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

            return allFilesDeleted && allFoldersDeleted;
        }

        private bool FindSpotifyCacheLocation()
        {
            // Check if any cache folder exists
            bool spotifyBrowserCacheFolderExists = Directory.Exists(_spotifyBrowserCacheLocation);
            bool spotifyDataCacheFolderExists = Directory.Exists(_spotifyDataCacheLocation);

            // Update textboxes
            textBoxBrowserCacheLocation.Text = _spotifyBrowserCacheLocation;
            textBoxDataCacheLocation.Text = _spotifyDataCacheLocation;
            labelTotalCacheSize.Text = "Total cache size: 0.0 B";
            labelDeletedCacheSize.Text = "Deleted cache size: 0.0 B";

            // Toggle elements
            buttonOpenBrowserCacheFolder.Enabled = spotifyBrowserCacheFolderExists;
            buttonOpenDataCacheFolder.Enabled = spotifyDataCacheFolderExists;
            dateTimePickerDirectoryAge.Enabled = spotifyBrowserCacheFolderExists || spotifyDataCacheFolderExists;
            buttonDeleteCache.Enabled = spotifyBrowserCacheFolderExists || spotifyDataCacheFolderExists;

            return spotifyBrowserCacheFolderExists || spotifyDataCacheFolderExists;
        }

        private long GetDirectorySize(string path, bool computeTotalSize = true)
        {
            long directorySize = 0L;

            // Compute size of all files in that directory
            if (computeTotalSize)
            {
                try
                {
                    // Add length of all files to compute directory size
                    if (Directory.Exists(path))
                    {
                        string[] filenames = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

                        foreach (string fileName in filenames)
                            directorySize += new FileInfo(fileName).Length;
                    }
                }
                catch
                {
                    // Nothing to do here
                }
            }
            // Only compute size of files to delete 
            else
            {
                if (path == _spotifyBrowserCacheLocation)
                {
                    foreach (string fileName in _cacheFilesToDelete)
                        directorySize += new FileInfo(fileName).Length;
                }
                else
                {
                    foreach (string directory in _cacheDirectoriesToDelete)
                        directorySize += GetDirectorySize(directory);
                }
            }

            return directorySize;
        }

        private string[] GetCacheFilesToDelete()
        {
            string[] oldCacheFiles = new string[] { };

            try
            {
                // Add browser cache files, if present
                if (Directory.Exists(_spotifyBrowserCacheLocation))
                {
                    oldCacheFiles = Directory.GetFiles(_spotifyBrowserCacheLocation)
                        .Where(file => new FileInfo(file).LastWriteTime < dateTimePickerDirectoryAge.Value)
                        .Select(file => file).ToArray();
                }
            }
            catch
            {
                // Nothing to do here
            }

            return oldCacheFiles;
        }

        private string[] GetCacheDirectoriesToDelete()
        {
            string[] oldCacheDirectories = new string[] { };

            try
            {
                // Add data cache directories, if present
                if (Directory.Exists(_spotifyDataCacheLocation))
                {
                    oldCacheDirectories = Directory.GetDirectories(_spotifyDataCacheLocation)
                        .Where(directory => new DirectoryInfo(directory).LastWriteTime < dateTimePickerDirectoryAge.Value)
                        .Select(directory => directory).ToArray();
                }
            }
            catch
            {
                // Nothing to do here
            }

            return oldCacheDirectories;
        }

        private void OpenFolder(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch
            {
                MessageBox.Show("The Spofify cache folder no longer exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string ReadableBytes(long bytes)
        {
            // Convert bytes to a readable format
            string[] sizes = new string[] { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            if (bytes == 0) return bytes.ToString("N2") + " " + sizes[0];

            double i = Math.Floor(Math.Log(bytes) / Math.Log(1024));
            return (bytes / Math.Pow(1024, i)).ToString("N2") + " " + sizes[(int)i];
        }

        private void UpdateCacheSize(bool computeTotalSize = true)
        {
            _cacheFilesToDelete = GetCacheFilesToDelete();
            _cacheDirectoriesToDelete = GetCacheDirectoriesToDelete();

            if (computeTotalSize)
                ComputeTotalCacheSize();

            ComputeDeletedCacheSize();

            if ((!Directory.Exists(_spotifyBrowserCacheLocation) || !Directory.Exists(_spotifyBrowserCacheLocation)) && !_hideWarnings)
                MessageBox.Show("The Spofify cache folder no longer exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Event handlers
        private void DateTimePickerDirectoryAge_ValueChanged(object sender, EventArgs e)
        {
            _hideWarnings = true;
            UpdateCacheSize();
            _hideWarnings = false;
        }

        private void ButtonOpenBrowserCacheFolder_Click(object sender, EventArgs e)
        {
            OpenFolder(_spotifyBrowserCacheLocation);
        }

        private void ButtonOpenDataCacheFolder_Click(object sender, EventArgs e)
        {
            OpenFolder(_spotifyDataCacheLocation);
        }

        private void ButtonReportBug_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/GenesisFR/SpotifyDeleteCache/issues");
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            _hideWarnings = true;

            if (FindSpotifyCacheLocation())
                UpdateCacheSize();
            else
                MessageBox.Show("The Spofify cache folder wasn't found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            _hideWarnings = false;
        }

        private void ButtonDeleteCache_Click(object sender, EventArgs e)
        {
            bool areDirectoriesDeleted = DeleteCacheDirectories();
            UpdateCacheSize();

            string text = areDirectoriesDeleted ? "The Spofify cache has been deleted!" :
                    "The Spofify cache has been deleted, but some folder couldn't be deleted.";
            MessageBoxIcon icon = areDirectoriesDeleted ? MessageBoxIcon.Information : MessageBoxIcon.Warning;

            MessageBox.Show(text, "Success", MessageBoxButtons.OK, icon);

            if ((!Directory.Exists(_spotifyBrowserCacheLocation) || !Directory.Exists(_spotifyBrowserCacheLocation)) && !_hideWarnings)
                MessageBox.Show("The Spofify cache folder no longer exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PictureBoxKappa_Click(object sender, EventArgs e)
        {
            Process.Start("http://knowyourmeme.com/memes/kappa");
        }
    }
}
