using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Security.Cryptography;

namespace NauWF
{
    public partial class frmNau : PlantillaWF.frmPlantilla
    {
        #region CRIDA D'ALTRES FORMULARIS
        ClassesComunesBC.GestioMissatges gestioMsg = new ClassesComunesBC.GestioMissatges();
        ClassesComunesBC.RSA rsa = new ClassesComunesBC.RSA();
        ClassesComunesBC.Ejemplo_RSA EjRSA = new ClassesComunesBC.Ejemplo_RSA();
        ClassesComunesBC.IP IPCC = new ClassesComunesBC.IP();
        ClassesComunesBC.ConsultesBBDD consultes = new ClassesComunesBC.ConsultesBBDD();
        ClassesComunesBC.CarpetaZIP carpetaZip = new ClassesComunesBC.CarpetaZIP();
        ClassesComunesBC.tipusSpaceShip Tnau = new ClassesComunesBC.tipusSpaceShip();
        ClassesComunesBC.EncriptacioDesencriptacio EncryptDecrypt = new ClassesComunesBC.EncriptacioDesencriptacio();
        UserControls.CompteEnrereUC compteEnrere = new UserControls.CompteEnrereUC();

        #endregion

        #region INICIALITZACIONS
        public string ConnectionString = "Server=thegungans.database.windows.net; Database=RepublicSystem; User Id=gungan; Password=12345aA12345aA";

        private const int BufferSize = 1024;
        public Thread Tf = null;
        public Thread Tm = null;
        public Thread Ts = null;

        public TcpListener Listener;

        public string tipusNau;

        public bool missatgeEnviat = false;
        public bool PACSRebut = false;
        private string type = "nau";

        public string bloquejatOuter = "Aquesta funcionalitat només està disponible en el InnerRing.";

        #endregion

        public frmNau()
        {
            InitializeComponent();

            // IP guardada en BBDD
            string localIP;
            bool error;

            localIP = IPCC.obtenirIP();

            string query = "UPDATE SpaceShips SET IPSpaceShip= '" + localIP + "' WHERE idSpaceShip = 1;";

            error = IPCC.actualitzarIP(query, localIP);

            if (error)
            {
                MessageBox.Show("Error al afegir la IP");
            }

            // Borrar la carpeta frmNau
            if (Directory.Exists(@"Fitxer\frmNau"))
            {
                Directory.Delete(@"Fitxer\frmNau", true);
            }
        }


        public void enviarMissatge()
        {
            ThreadStart Tsm = null;

            SqlConnection connection = new SqlConnection(ConnectionString);

            Random rnd = new Random();
            rnd.Next();

            string myQuery = "SELECT TOP 1 SpaceShip, CodeDelivery, DeliveryDate FROM DeliveryData ORDER BY newid();";

            SqlCommand command = new SqlCommand(myQuery, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                string spaceShip = reader["SpaceShip"].ToString();
                string codeDelivery = reader["CodeDelivery"].ToString();
                string date = reader["DeliveryDate"].ToString();

                date = ConvertDate(date);

                reader.Close();

                string data = date + spaceShip + codeDelivery;

                if (tipusNau == "INNER")
                {
                    gestioMsg.SendMessageTCP(data, consultes.queryIpPlanet, consultes.queryPortPlanetMessage);

                    Tsm = new ThreadStart(StartReceivingMessages);
                }
                else if (tipusNau == "OUTER")
                {
                    // Tapa missatges per al Outer
                    panelBloqMsg.Visible = true;

                    SendMessageUDP(data);
                    Tsm = new ThreadStart(ReceiveMessageUDP);
                }

                // Message
                Tm = new Thread(Tsm);
                Tm.SetApartmentState(ApartmentState.STA);
                Tm.IsBackground = true;
                Tm.Start();

                missatgeEnviat = true;

                lbMissatgeFinal.Font = new Font("Montserrat", 14, FontStyle.Regular);
                lbMissatgeFinal.ForeColor = Color.LimeGreen;
                lbMissatgeFinal.Text = "Missatge enviat correctament!";
            }
            catch
            {
                lbMissatgeFinal.ForeColor = Color.Yellow;
                lbMissatgeFinal.Font = new Font("Montserrat", 14, FontStyle.Italic);
                lbMissatgeFinal.Text = "Error al enviar el missatge";

                //MessageBox.Show("No es pot enviar el missatge si Planeta no aixeca el servidor");

                //lbMissatgeFinal.Font = new Font("Montserrat", 14, FontStyle.Regular);
                //lbMissatgeFinal.ForeColor = Color.Red;
                //lbMissatgeFinal.Text = "Missatge no enviat.";
            }
            finally
            {
                connection.Close();
            }
        }

        private void SendMessageUDP(string data)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            string ipPlaneta = IPCC.obtenirIpEspecifica(consultes.queryIpPlanet);
            int portPlanet = IPCC.obtenirPort(consultes.queryPortUDPPlanet);

            UdpClient udpClient = new UdpClient();
            udpClient.Connect(new IPEndPoint(IPAddress.Parse(ipPlaneta), portPlanet));
            Byte[] sendData = ByteConverter.GetBytes(data);
            RSACryptoServiceProvider rsaEnc = ImportarClauPublica();
            RSAParameters ParametresRSA = rsa.ExpImpClauPrivada(rsaEnc, type);
            byte[] encryptedMessage = rsa.UDPEncryptedToSend(ParametresRSA, sendData);

            udpClient.Send(encryptedMessage, encryptedMessage.Length);
            udpClient.Close();
        }

        private void ReceiveMessageUDP()
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            int portNau = IPCC.obtenirPort(consultes.queryPortUDPSpaceShip);

            UdpClient udpClient;
            IPEndPoint IeP;
            try
            {
                udpClient = new UdpClient(portNau);
                IeP = new IPEndPoint(IPAddress.Any, portNau);
                while (true)
                {
                    Thread.Sleep(2000);

                    if (udpClient.Available > 0)
                    {
                        Byte[] BytesIn = udpClient.Receive(ref IeP);
                        string returnData = Encoding.Unicode.GetString(BytesIn, 0, BytesIn.Length);

                        MessageBox.Show(returnData);

                        string final = returnData.Substring(returnData.Length-2, 2);

                        if (final == "AG")
                        {
                            btImgAccess.Image = Image.FromFile(@"img/success.png");
                        }
                        else
                        {
                            btImgAccess.Image = Image.FromFile(@"img/access-denied.png");
                        }

                        //udpClient.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error UDP");
            }






        }

        string ConvertDate(string date)
        {
            string day = date.Substring(0, 2);
            string month = date.Substring(3, 2);
            string year = date.Substring(6, 4);

            string dateString = month + day + year;

            return dateString;
        }

        public void StartReceivingMessages()
        {
            string variable = gestioMsg.ReceiveMessage(consultes.queryIpPlanet, consultes.queryPortSpaceShipMessage);

            string ultimasLetras = variable.Substring(variable.Length-2, 2);

            if (ultimasLetras == "AG")
            {
                btImgAccess.Image = Image.FromFile(@"img/success.png");
            }
            else
            {
                btImgAccess.Image = Image.FromFile(@"img/access-denied.png");
            }

            MessageBox.Show(variable);
        }

        public void aixecarServidor()
        {
            if (tipusNau == "INNER")
            {
                if (missatgeEnviat)
                {
                    lbASFinal.ForeColor = Color.LimeGreen;
                    lbASFinal.Font = new Font("Montserrat", 14, FontStyle.Regular);
                    lbASFinal.Text = "Servidor aixecat correctament!";
                    // Files
                    ThreadStart Tsf = new ThreadStart(StartReceivingFiles);
                    Tf = new Thread(Tsf);
                    Tf.SetApartmentState(ApartmentState.STA);
                    Tf.IsBackground = true;
                    Tf.Start();
                }
                else
                {
                    lbASFinal.ForeColor = Color.Yellow;
                    lbASFinal.Font = new Font("Montserrat", 14, FontStyle.Italic);
                    lbASFinal.Text = "Necessites enviar el missatge abans d'aixecar el servidor";
                    // MessageBox.Show("Necessites enviar el missatge abans d'aixecar el servidor");
                }
            }
            else
            {
                MessageBox.Show(bloquejatOuter);
            }
        }

        public void StartReceivingFiles()
        {
            int port = IPCC.obtenirPort(consultes.queryPortSpaceShipFiles);

            ReceiveTCP(port);
        }

        public void ReceiveTCP(int portN)
        {
            Listener = null;

            try
            {
                Listener = new TcpListener(IPAddress.Any, portN);
                Listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            byte[] RecData = new byte[BufferSize];
            int RecBytes;

            for (; ; )
            {
                TcpClient client = null;
                NetworkStream netstream = null;
                try
                {
                    string message = "Vols acceptar el fitxer?";
                    string caption = "Connexió establerta";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();
                        result = MessageBox.Show(message, caption, buttons);

                        if (result == DialogResult.Yes)
                        {
                            if (!Directory.Exists(@"Fitxer\frmNau\PACS"))
                            {
                                Directory.CreateDirectory(@"Fitxer\frmNau\PACS");
                            }
                            else if (Directory.Exists(@"Fitxer\frmNau\PACS\PACS.zip"))
                            {
                                Directory.Delete(@"Fitxer\frmNau\PACS\PACS.zip");
                            }

                            string SaveFileName = @"Fitxer\frmNau\PACS\PACS.zip";

                            //// Iniciar comptador
                            //compteEnrere.Iniciat = true;
                            //PnlTimer.Controls.Add(compteEnrere);

                            int totalrecbytes = 0;
                            FileStream Fs = new FileStream(SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
                            while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                            {
                                Fs.Write(RecData, 0, RecBytes);
                                totalrecbytes += RecBytes;
                            }
                            Fs.Close();
                            netstream.Close();
                            client.Close();

                            PACSRebut = true;
                        }
                        else
                        {
                            netstream.Close();
                            client.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    Listener.Stop();

                    //netstream.Close();
                }
            }
        }

        private string[] desencriptar()
        {
            string[] clau_arr = carpetaZip.LlegirClau();

            if (File.Exists(@"Fitxer\frmNau\Desencriptat.txt"))
            {
                File.Delete(@"Fitxer\frmNau\Desencriptat.txt");
            }

            StreamWriter ftx_desencripted = new StreamWriter(@"Fitxer\frmNau\Desencriptat.txt");

            try
            {
                for (int i = 1; i <= 4; i++)
                {
                    StreamReader reader = new StreamReader(@"Fitxer\frmNau\PACS\Extract\PACS" + i + ".txt");

                    string nums = "";
                    string numsOK = "";
                    string clau;
                    while (nums != null)
                    {
                        nums = reader.ReadLine();
                        if (nums != null)
                        {
                            numsOK = nums;
                        }

                    }

                    try
                    {
                        for (int x = 0; x < numsOK.Length; x += 4)
                        {
                            clau = numsOK.Substring(x, 4);
                            bool clau_trobada = false;

                            for (int y = 0; y < clau_arr.Length && clau_trobada == false; y++)
                            {

                                if (clau_arr[y].Equals(clau))
                                {
                                    ftx_desencripted.Write(carpetaZip.lletres[y]);
                                    clau_trobada = true;
                                }
                            }
                        }
                        reader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error. Torna a provar més tard.");
                    }
                }
                ftx_desencripted.Close();
            }
            catch
            {
                MessageBox.Show("Error. Reinicia el programa i torna a provar.");
            }

            return clau_arr;
        }

        private void desencriptarEnviar()
        {
            bool error = false;

            string SaveFileName = @"Fitxer\frmNau\PACS\PACS.zip";
            string extract = @"Fitxer\frmNau\PACS\Extract\";

            if (tipusNau == "INNER")
            {
                if (PACSRebut)
                {
                    // Desencriptar el fitxer
                    error = carpetaZip.descomprimirCarpeta(SaveFileName, extract);

                    if (error)
                    {
                        lbDFinal.ForeColor = Color.Yellow;
                        lbDFinal.Font = new Font("Montserrat", 14, FontStyle.Italic);
                        lbDFinal.Text = "Error al descomprimir PACS";
                        // MessageBox.Show("La carpeta no s'ha descomprimit correctament");
                    }

                    // Desencriptar
                    desencriptar();

                    // Enviar l'arxiu
                    string ipPlanet = IPCC.obtenirIpEspecifica(consultes.queryIpPlanet);

                    int port = IPCC.obtenirPort(consultes.queryPortPlanetFiles);

                    gestioMsg._RutaSendTCP = @"Fitxer\frmNau\Desencriptat.txt";
                    gestioMsg._IPSendTCP = ipPlanet;
                    gestioMsg._PortSendTCP = port;

                    ThreadStart Tss = new ThreadStart(gestioMsg.SendTCP);
                    Ts = new Thread(Tss);
                    Ts.SetApartmentState(ApartmentState.STA);
                    Ts.IsBackground = true;
                    Ts.Start();

                    lbDFinal.ForeColor = Color.LimeGreen;
                    lbDFinal.Font = new Font("Montserrat", 14, FontStyle.Regular);
                    lbDFinal.Text = "PACS desxifrat i enviat!";

                    compteEnrere.timer.Stop();
                }
                else
                {
                    lbDFinal.ForeColor = Color.Yellow;
                    lbDFinal.Font = new Font("Montserrat", 14, FontStyle.Italic);
                    lbDFinal.Text = "Encara no has rebut PACS";
                    // MessageBox.Show("No pots desencriptar fins que revis el fitxer PACS");
                }
            }
            else
            {
                MessageBox.Show(bloquejatOuter);
            }
        }

        public RSACryptoServiceProvider ImportarClauPublica()
        {
            string keyQuery = consultes.queryToObtainPublicKey;

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(keyQuery, connection);

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string publicKey = reader["XMLKey"].ToString();

            //CREAR OBJECTE RSA
            RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();

            //INICIALITZAR OBJECTE RSA AMB LA CLAU CARREGADA DES DEL FITXER XML
            rsaEnc.FromXmlString(publicKey);

            return rsaEnc;
        }

        private void opcionsMissatge()
        {
            // Mirem quin tipus de nau es
            tipusNau = Tnau.typeNau();
            tipusNau.Trim();

            enviarMissatge();
        }

        private byte[] getPublicKey(string query)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            string publicKey = reader.ToString();

            byte[] key = Encoding.ASCII.GetBytes(publicKey);

            MessageBox.Show(publicKey);

            return key;
        }

        #region BOTONS

        private void btPanelEM_Click(object sender, EventArgs e)
        {
            opcionsMissatge();
        }

        private void btLabelEM_Click(object sender, EventArgs e)
        {
            opcionsMissatge();
        }

        private void btImgEM_Click(object sender, EventArgs e)
        {
            opcionsMissatge();
        }

        private void btPanelAS_Click(object sender, EventArgs e)
        {
            aixecarServidor();
        }

        private void btImgAS_Click(object sender, EventArgs e)
        {
            aixecarServidor();
        }

        private void btLabelAS_Click(object sender, EventArgs e)
        {
            aixecarServidor();
        }

        private void btPanelDR_Click(object sender, EventArgs e)
        {
            desencriptarEnviar();
        }

        private void btImgDR_Click(object sender, EventArgs e)
        {
            desencriptarEnviar();
        }

        private void btLabelDR_Click(object sender, EventArgs e)
        {
            desencriptarEnviar();
        }

        private void btLabelRb_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btPanelRb_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btImgRb_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        #endregion
    }
}
