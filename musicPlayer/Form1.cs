using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace musicPlayer
{
    public partial class mainForm : Form
    {
        static string _path;
        string _userpath;
        IWavePlayer _waveout = new WaveOut();
        bool playing = false;
        public mainForm()
        {
            InitializeComponent();
        }

        private void _selfile_FileOk(object sender, CancelEventArgs e)
        {
            _path = _selfile.FileName;
            _userpath = _selfile.SafeFileName;
            _currenttrack.Text = "Currently playing: " + _userpath;
            Update();
            var file = TagLib.File.Create(_path);
            if (file.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                _albumart.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(200, 200, null, IntPtr.Zero);
            }
            AudioFileReader _audiofr = new AudioFileReader(_path);
            _waveout.Init(_audiofr);
            string t = _audiofr.TotalTime.ToString();

            int.TryParse(t, out int x);
            _progress.Maximum = x;
        }
        private void _choose_Click(object sender, EventArgs e)
        {
            _selfile.ShowDialog();
        }

        private void _albumart_Click(object sender, EventArgs e)
        {

        }

        private void _play_Click(object sender, EventArgs e)
        {
            try
            {
                _waveout.Play();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            playing = true;
            while(playing)
            {
            }
        }

        private void _pause_Click(object sender, EventArgs e)
        {
            try
            {
                _waveout.Pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void _stop_Click(object sender, EventArgs e)
        {
            try
            {
                _waveout.Stop();
                _waveout.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
