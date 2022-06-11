using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApp.UserControls
{
    public partial class ControlPlayer : UserControl
    {
        public string Player_Number { get => Number_txt.Text; set => Number_txt.Text = value; }
        private bool isokay = false;
        public ControlPlayer()
        {
            InitializeComponent();
        }
        public string Names
        {
            get => lbl_name.Text; set
            {
                lbl_name.Text = value;
            }
        }
        
        public int LoactionX
        {
            
            get { return Location.X; }
            set {
                Point name = new Point();
                name.X = value;
                name.Y = Location.Y;
                Location = name; }
        }
        public int Marginsize
        {
            get { return Margin.All; }
            set
            {
                Padding name = new Padding();
                name.All = value;
                Margin = name;
            }
        }
        private void guna2ImageButton1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isokay) { imagebutton.Image = Resources.sekil_pmg; isokay = true; }
            else { imagebutton.Image = Resources.depositphotos_57111133_stock_illustration_pixel_art_style_illustration_shows; isokay = false; }
        }

        private void Number_txt_Click(object sender, EventArgs e)
        {

        }
    }
}
