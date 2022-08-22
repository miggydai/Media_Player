using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customdesign();
        }
        //codes
        private void customdesign() {
            MediaPanel.Visible = false;
            PlaylistPanel.Visible = false;
            AlbumPanel.Visible = false;
            ToolPanel.Visible = false;
            HelpPanel.Visible = false;

        
        }

        private void HideSubMenu() {
            if (MediaPanel.Visible == true)
                MediaPanel.Visible = false;
            if (PlaylistPanel.Visible == true)
                PlaylistPanel.Visible = false;
            if (AlbumPanel.Visible == true)
                AlbumPanel.Visible = false;
            if (ToolPanel.Visible == true)
                ToolPanel.Visible = false;
            if (HelpPanel.Visible == true)
                HelpPanel.Visible = false;
          
        }

        private void ShowMenu(Panel m) {
            if (m.Visible == false)
            {
                HideSubMenu();
                m.Visible = true;
            }
            else {
                m.Visible = false;
            }
        }

        #region Media Panel
        private void Media_Click(object sender, EventArgs e)
        {
            ShowMenu(MediaPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildPanel(new Form2());
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }
        #endregion

        #region Playlist Panel
        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            ShowMenu(PlaylistPanel);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildPanel(new Form3());
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

       

        #endregion

        #region Album Panel

        private void AlbumsButton_Click(object sender, EventArgs e)
        {
            ShowMenu(AlbumPanel);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }


        #endregion

        #region ToolPanel
        private void ToolsButton_Click(object sender, EventArgs e)
        {
            ShowMenu(ToolPanel);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }
        #endregion

        #region Help Panel
        private void HelpButton_Click(object sender, EventArgs e)
        {
            ShowMenu(HelpPanel);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //...
            //codes
            //...
            HideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildPanel(Form childForm) {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        
        }
    
    
    }
}
