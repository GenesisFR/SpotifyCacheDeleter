using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpotifyDeleteCache
{
    public partial class SpotifyDeleteCacheForm : Form
    {
        private string _spotifyCacheLocation;
        private string[] _cacheDirectoriesToDelete = new string[] { };

        public SpotifyDeleteCacheForm()
        {
            InitializeComponent();

            FindSpotifyCacheLocation();
            UpdateCacheSize(true);
        }

        private void ComputeTotalCacheSize()
        {
            labelTotalCacheSize.Text = $"Total cache size: { ReadableBytes(GetDirectorySize(_spotifyCacheLocation)) }";
        }

        private void ComputeDeletedCacheSize()
        {
            labelDeletedCacheSize.Text = $"Deleted cache size: { ReadableBytes(GetDirectorySize(_spotifyCacheLocation, false)) }";
        }

        private void DeleteCacheDirectories()
        {
            try
            {
                foreach (string directory in _cacheDirectoriesToDelete)
                    Directory.Delete(directory, true);
            }
            catch (Exception)
            {
                // Nothing to do here
            }
        }

        private void FindSpotifyCacheLocation()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _spotifyCacheLocation = Path.Combine(localAppData, @"Spotify\Data");
            textBoxCacheLocation.Text = _spotifyCacheLocation;
        }

        private long GetDirectorySize(string path, bool computeTotalSize = true)
        {
            string[] a = computeTotalSize ? Directory.GetFiles(path, "*.*", SearchOption.AllDirectories) : _cacheDirectoriesToDelete;
            long size = 0;

            foreach (string name in a)
                size += computeTotalSize ? new FileInfo(name).Length : GetDirectorySize(name);

            return size;
        }

        private string[] GetOldCacheDirectories()
        {
            string[] oldCacheDirectories = Directory.GetDirectories(_spotifyCacheLocation)
                                           .Where(directory => new DirectoryInfo(directory).LastWriteTime < dateTimePickerDirectoryAge.Value)
                                           .Select(directory => directory).ToArray();
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
            if (computeTotalSize)
                ComputeTotalCacheSize();

            _cacheDirectoriesToDelete = GetOldCacheDirectories();
            ComputeDeletedCacheSize();
        }

        private void DateTimePickerDirectoryAge_ValueChanged(object sender, EventArgs e)
        {
            UpdateCacheSize();
        }

        private void LinkLabelAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/GenesisFR");
        }

        private void ButtonOpenCacheFolder_Click(object sender, EventArgs e)
        {
            Process.Start(_spotifyCacheLocation);
        }

        private void ButtonDeleteCache_Click(object sender, EventArgs e)
        {
            DeleteCacheDirectories();
            UpdateCacheSize(true);
            MessageBox.Show("Spofify cache deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBoxKappa_Click(object sender, EventArgs e)
        {
            Process.Start("http://knowyourmeme.com/memes/kappa");
        }
    }
}
