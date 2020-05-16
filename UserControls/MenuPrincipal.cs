using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class MenuPrincipal : UserControl
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            toolTip.SetToolTip(this.btImgMain, "Torna a la pantalla principal");
        }

        private void btImgMain_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "frmMain")
                {
                    frm.Show();
                }
                else
                {
                    frm.Hide();
                }
            }
        }
    }
}
