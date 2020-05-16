using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWF
{
    public partial class frmMain : PlantillaWF.frmPlantilla
    {
        public string connectionString = "Server=thegungans.database.windows.net; Database=RepublicSystem; User Id=gungan; Password=12345aA12345aA";

        public frmMain()
        {
            InitializeComponent();
        }

        private void guardarTipusBBDD(string tipusNau)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet v_id = new DataSet();

            using (SqlConnection connexio = new SqlConnection(connectionString))
            {
                connexio.Open();

                string query = "UPDATE SpaceShips SET TypeSpaceShip = '" + tipusNau + "' WHERE idSpaceShip = 1;";

                using (SqlCommand command = new SqlCommand(query, connexio))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TypeSpaceShip", tipusNau);
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                    }
                }
            }
        }

        #region BOTONS
        private void btImgMF_Click(object sender, EventArgs e)
        {
            NauWF.frmNau nau = new NauWF.frmNau();
            nau.Show();

            string tipusNau = "INNER";

            guardarTipusBBDD(tipusNau.Trim());

            this.Hide();
        }

        private void btImgDS_Click(object sender, EventArgs e)
        {
            NauWF.frmNau nau = new NauWF.frmNau();
            nau.Show();

            string tipusNau = "OUTER";

            guardarTipusBBDD(tipusNau.Trim());

            this.Hide();
        }

        #endregion
    }
}
