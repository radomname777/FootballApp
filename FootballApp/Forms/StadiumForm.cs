using FootballApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApp.Forms
{
    public partial class StadiumForm : Form
    {
        public List<Player>? Players { get; set; }
        
        public string CountryName
        {
            get { return lbl_country.Text; }
            set { 
                lbl_country.Text = value;
                ChangeFlag();
            }
        }
        public int[]? TacticFormat { get; set; }
        public void delete()
        {
            foreach (var item2 in Controls)
            {

              if (item2 is Panel pnl)
              {
                foreach (var item in pnl.Controls)
                {
                  if (item is UserControls.ControlPlayer pl)
                  {
                    pnl.Controls.Remove(pl);
                  }
                }
              }
                
            }
        }
        public void Row()
        {
            foreach (var item2 in Controls)
            {
                 foreach (var item in Players)
                 {
                    if (item2 is Panel pnl)
                    {
                        if (item.Position == pnl.Tag)
                        {       
                            UserControls.ControlPlayer B = new UserControls.ControlPlayer();
                            B.Dock = DockStyle.Right;
                            B.Player_Number = item.Number.ToString();
                            B.Names = item.Name;
                            pnl.Controls.Add(B);
                        }
                    }
                 }
            }
        }
        public StadiumForm()
        {
            InitializeComponent();
        }
        private void ChangeFlag()
        {
            pBox_Flag.LoadAsync($"https://countryflagsapi.com/png/{CountryName}");
        }
    }
}
