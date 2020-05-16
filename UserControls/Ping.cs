using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace UserControls
{
    public partial class Ping : UserControl
    {
        ClassesComunesBC.IP IPCC = new ClassesComunesBC.IP();

        public string query;
        public string destiNom;

        public Ping()
        {
            InitializeComponent();

            toolTip.SetToolTip(this.btPing, "Comprovar ping");
        }

        #region PROPIETAT

        public enum SeleccionaDesti
        {
            Planeta = 1,
            Nau = 2
        }

        public SeleccionaDesti _Desti;

        public SeleccionaDesti Desti
        {
            get { return _Desti; }
            set
            {
                queryDesti(value);
                _Desti = value;
            }
        }

        public void queryDesti(SeleccionaDesti valor)
        {
            if (valor == SeleccionaDesti.Planeta)
            {
                query = "SELECT IPPlanet FROM Planets WHERE idPlanet= 2";
                destiNom = "el Planeta";
            }

            if (valor == SeleccionaDesti.Nau)
            {
                query = "SELECT IPSpaceShip FROM SpaceShips WHERE idSpaceShip = 1";
                destiNom = "la Nau";
            }
        }

        #endregion

        private bool comprovarPing()
        {
            string ip = IPCC.obtenirIpEspecifica(query);

            bool pingable = IPCC.returnPing(ip);

            return pingable;
        }

        private void btPing_Click(object sender, EventArgs e)
        {
            bool ping = comprovarPing();

            if (ping)
            {
                lbMissatge.Text = "Tens connexió amb " + destiNom + "!";
            }
            else
            {
                lbMissatge.Text = "No tens connexió amb " + destiNom + "!";
            }
        }
    }
}
