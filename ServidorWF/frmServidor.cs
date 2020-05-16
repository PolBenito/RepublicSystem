using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ServidorWF
{
    public partial class frmServidor : PlantillaWF.frmPlantilla
    {
        #region INICIALITZACIONS
        DateTime dia;

        public int[] numeros = new int[26];
        public string[] v_numeros = new string[26];
        public string[] DataActual;
        public string[] lletres = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public int num;
        public int id, numbers;
        public int contTemps = 0;
        public string connectionString;
        public string word;
        public string numText;
        public bool repetit = false;

        #endregion

        public frmServidor()
        {
            InitializeComponent();

            connectionString = "Server=thegungans.database.windows.net; Database=RepublicSystem; User Id=gungan; Password=12345aA12345aA";

            lbFinal.Text = "Clau no creada.";
            lbFinal.ForeColor = Color.Red;
        }

        public void creacioXifrat()
        {
            lbFinal.ForeColor = Color.Yellow;
            lbFinal.Font = new Font("Montserrat", 14, FontStyle.Italic);
            lbFinal.Text = "Processant la clau diària...";

            crearFitxer();

            dia = obtenirDiaHoraActual();

            afegirDataBaseDades(dia);
        }

        public void crearFitxer()
        {
            string rutaFitxer = @"Fitxer/frmServidor";
            string rutaClau = @"Fitxer/frmServidor/Clau.txt";

            if (!Directory.Exists(rutaFitxer))
            {
                Directory.CreateDirectory(rutaFitxer);
            }

            using (StreamWriter ftx = File.CreateText(rutaClau))
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    Random rnd = new Random();

                    num = rnd.Next(0, 9999);

                    if (i > 0)
                    {
                        for (int x = 0; x < i; x++)
                        {
                            if (num == numeros[x])
                            {
                                repetit = true;
                            }
                        }

                        if (!repetit)
                        {
                            numeros[i] = num;
                        }
                    }
                    else
                    {
                        numeros[i] = num;
                    }

                    if (!repetit)
                    {
                        numText = num.ToString();

                        numText = numText.PadLeft(4, '0');

                        ftx.Write(numText);

                        v_numeros[i] = numText;
                    }
                    else
                    {
                        i--;
                    }
                    repetit = false;
                }
                ftx.Close();
            }
        }

        public DateTime obtenirDiaHoraActual()
        {
            DateTime dataAvui = DateTime.Today;

            return dataAvui;
        }

        public void afegirDataBaseDades(DateTime dia)
        {
            string queryIE, queryIED;
            string consultaID;
            int id = 0;

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet v_id = new DataSet();

            dia = obtenirDiaHoraActual();

            using (SqlConnection connexio = new SqlConnection(connectionString))
            {
                queryIE = "INSERT INTO InnerEncryption ([Day]) VALUES (@dia);";

                connexio.Open();

                using (SqlCommand command = new SqlCommand(queryIE, connexio))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@dia", dia);
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Error al afegir la data");
                    }
                }

                consultaID = "SELECT max(IdInnerEncryption) FROM InnerEncryption";
                da = new SqlDataAdapter(consultaID, connexio);
                da.Fill(v_id);
                id = Int32.Parse(v_id.Tables[0].Rows[0][0].ToString());

                queryIED = "INSERT INTO InnerEncryptionData ([IdInnerEncryption], [Word], [Numbers]) VALUES (" + id + ", @word, @numbers);";


                for (int i = 0; i < v_numeros.Length; i++)
                {
                    using (SqlCommand command = new SqlCommand(queryIED, connexio))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@word", lletres[i]);
                            command.Parameters.AddWithValue("@numbers", v_numeros[i]);
                            command.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Error al insertar les dades");
                        }
                    }
                }
                lbFinal.Font = new Font("Montserrat", 14, FontStyle.Regular);
                lbFinal.ForeColor = Color.LimeGreen;
                lbFinal.Text = "Clau diària creada correctament!";

                connexio.Close();
            }
        }

        #region BOTONS
        private void btPanel_Click(object sender, EventArgs e)
        {
            creacioXifrat();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            creacioXifrat();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            creacioXifrat();
        }

        #endregion
    }
}
