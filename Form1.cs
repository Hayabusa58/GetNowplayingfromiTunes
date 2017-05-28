using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTunesLib;


namespace GetNowPlayingfromiTunes
{
    public partial class Form1 : Form
    {
        iTunesApp app = new iTunesApp();
        
        string copytxt;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IITTrack track = app.CurrentTrack;
            if (track != null)
            {
                label4.Visible = true;
                label4.Text = track.Name;
                label5.Visible = true;
                label5.Text = track.Artist;
                label6.Visible = true;
                label6.Text = track.Album;
                System.Diagnostics.Debug.WriteLine("This is a message for Debugging.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IITTrack track = app.CurrentTrack;
            copytxt = "#nowplaying " + track.Name + " / " + track.Artist;
            Clipboard.SetText(copytxt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
