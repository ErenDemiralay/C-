using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackVolume.Value = 10;
        }
        string[] paths, files;


        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x=0; x<files.Length;x++)
                {
                    trackList.Items.Add(files[x]);
                }
            }
        }


        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[trackList.SelectedIndex];
            Player.Ctlcontrols.play();
        }


        private void button_Stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

  
        private void button_Pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }


        private void button_Play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex < trackList.Items.Count - 1)
            {
                trackList.SelectedIndex = trackList.SelectedIndex + 1;
            }
        }

        private void button_Preview_Click(object sender, EventArgs e)
        {
            if(trackList.SelectedIndex > 0)
            {
                trackList.SelectedIndex = trackList.SelectedIndex - 1;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                pBar.Value = (int)Player.Ctlcontrols.currentPosition;
            }
            try
            {
                label_track_start.Text = Player.Ctlcontrols.currentPositionString;
                label_track_end.Text = Player.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {

            }
        }

        private void pBar_MouseDown(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / pBar.Width;
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = trackVolume.Value;
            label_volume.Text = trackVolume.ToString() + "%";
        }

    }
}
