using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;

namespace PlanetaWF
{
    public partial class frmPlaneta : PlantillaWF.frmPlantilla
    {
        #region CRIDA D'ALTRES FORMULARIS
        ClassesComunesBC.GestioMissatges gestioMsg = new ClassesComunesBC.GestioMissatges();
        ClassesComunesBC.RSA rsa = new ClassesComunesBC.RSA();
        ClassesComunesBC.Ejemplo_RSA EjRSA = new ClassesComunesBC.Ejemplo_RSA();
        ClassesComunesBC.IP IPCC = new ClassesComunesBC.IP();
        ClassesComunesBC.CarpetaZIP carpetaZip = new ClassesComunesBC.CarpetaZIP();
        ClassesComunesBC.ConsultesBBDD consultes = new ClassesComunesBC.ConsultesBBDD();
        ClassesComunesBC.tipusSpaceShip Tnau = new ClassesComunesBC.tipusSpaceShip();
        UserControls.CompteEnrereUC compteEnrere = new UserControls.CompteEnrereUC();
        #endregion

        #region INICIALITZACIONS

        public string connectionString = "Server=thegungans.database.windows.net; Database=RepublicSystem; User Id=gungan; Password=12345aA12345aA";

        public string[] lletres = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public string rutaLletres = @"Fitxer\frmPlaneta\Lletres\LLetres";
        public string rutaFitxerEncriptat = @"Fitxer\frmPlaneta\PACS\PACS";

        private const int BufferSize = 1024;
        public string Status = string.Empty;
        public Thread Tf = null;
        public Thread Tm = null;

        public TcpListener Listener;

        private Thread tUDP;
        private UdpClient udpClient;
        private SqlConnection connection;
        private SqlCommand command;
        private string response;

        public int num;
        public bool rebutMsg = false;
        public bool rebutFitxer = false;
        public bool outer = false;
        private string type = "planeta";

        public string tipusNau;
        private string[] claus;
        private CspParameters contenidorClau = new CspParameters();
        private RSACryptoServiceProvider rsaDec = new RSACryptoServiceProvider();
        private RSAParameters parametres = new RSAParameters();

        public string BloquejatOuter = "Aquesta funcionalitat només està disponible en InnerRing";

        #endregion

        public frmPlaneta()
        {
            InitializeComponent();

            // IP guardada en BBDD
            string localIP;
            bool error;

            localIP = IPCC.obtenirIP();

            string query = "UPDATE Planets SET IPPlanet = '" + localIP + "' WHERE idPlanet = 2;";

            error = IPCC.actualitzarIP(query, localIP);

            if (error)
            {
                MessageBox.Show("Error al afegir la IP");
            }

            // RSA
            claus = rsa.GeneradorClausRSA();
            rsa.guardarXMLBBDD(claus[0]);
            rsaDec.FromXmlString(claus[1]);
            //rsaDec = rsa.EmmagatzemarClauPrivada(contenidorClau);
            parametres = rsa.ExpImpClauPrivada(rsaDec, type);
        }


        private bool compararFitxers()
        {
            bool iguals = false;

            if (rebutMsg && rebutFitxer && !compteEnrere.tempsLimit && !outer)
            {
                // Comenca a comparar fitxers
                using (HashAlgorithm hashAlg = HashAlgorithm.Create())
                {
                    using (FileStream ftxLT = new FileStream(@"Fitxer\frmPlaneta\LLetres\LLetresTotals.txt", FileMode.Open),
                        ftxD = new FileStream(@"Fitxer\frmPlaneta\Nau\Desencriptat.txt", FileMode.Open))
                    {
                        // Calculate the hash for the files.
                        byte[] hashBytesA = hashAlg.ComputeHash(ftxLT);
                        byte[] hashBytesB = hashAlg.ComputeHash(ftxD);

                        // Compare the hashes.w
                        if (BitConverter.ToString(hashBytesA) == BitConverter.ToString(hashBytesB))
                        {
                            iguals = true;

                            lblHash.ForeColor = Color.LimeGreen;
                            lblHash.Font = new Font("Montserrat", 14, FontStyle.Regular);
                            lblHash.Text = "Accés concedit a la nau!";
                            //MessageBox.Show("Accés concedit a la nau!");
                        }
                        gestioMsg.resultatComparacio(iguals, consultes.queryIpSpaceShip, consultes.queryPortSpaceShipMessage, tipusNau);
                    }
                }
            }
            else if (outer)
            {
                MessageBox.Show(BloquejatOuter);
            }
            else if (compteEnrere.tempsLimit)
            {
                gestioMsg.resultatComparacio(iguals, consultes.queryIpSpaceShip, consultes.queryPortSpaceShipMessage, tipusNau);
            }
            else
            {
                lblHash.ForeColor = Color.Yellow;
                lblHash.Font = new Font("Montserrat", 14, FontStyle.Italic);
                lblHash.Text = "No tens els fitxers necessàris";
                //MessageBox.Show("No tens els fitxers necessàris");
            }

            return iguals;
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
                Status = string.Empty;
                try
                {
                    // Comptador
                    if (compteEnrere.tempsLimit)
                    {
                        compteEnrere.timer.Stop();
                        lblHash.ForeColor = Color.Red;
                        lblHash.Font = new Font("Montserrat", 14, FontStyle.Regular);
                        lblHash.Text = "Has tardat massa en desxifrar el codi. Accés denegat!";
                        //MessageBox.Show("Has tardat massa en desxifrar el codi. Accés denegat!");
                        break;
                    }
                    else
                    {
                        string message = "Vols acceptar el fitxer?";
                        string caption = "Connexió establerta";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        if (Listener.Pending())
                        {
                            client = Listener.AcceptTcpClient();
                            netstream = client.GetStream();
                            Status = "Connected to a client\n";
                            result = MessageBox.Show(message, caption, buttons);

                            if (result == DialogResult.Yes)
                            {
                                if (!Directory.Exists(@"Fitxer\frmPlaneta\Nau"))
                                {
                                    Directory.CreateDirectory(@"Fitxer\frmPlaneta\Nau");
                                }
                                else if (Directory.Exists(@"Fitxer\frmPlaneta\Nau\Desencriptat.txt"))
                                {
                                    File.Delete(@"Fitxer\frmPlaneta\Nau\Desencriptat.txt");
                                }


                                string SaveFileName = @"Fitxer\frmPlaneta\Nau\Desencriptat.txt";

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

                                // Rep el fitxer
                                rebutFitxer = true;
                            }
                            else
                            {
                                netstream.Close();
                                client.Close();
                                rebutFitxer = false;
                            }

                            // Para el comptador 
                            compteEnrere.timer.Stop();
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

        public void StartReceivingFiles()
        {
            int port;

            port = IPCC.obtenirPort(consultes.queryPortPlanetFiles);

            ReceiveTCP(port);
        }

        public void StartReceivingMessagesTCP()
        {
            MessageBox.Show(gestioMsg.missatge(consultes.queryIpSpaceShip, consultes.queryPortPlanetMessage));

            rebutMsg = true;
        }

        private void verifySpaceship(string[] date, string code, string spaceship)
        {
            connection = new SqlConnection(connectionString);

            string query = "SELECT SpaceShip, CodeDelivery, DeliveryDate FROM DeliveryData" +
                    "WHERE SpaceShip = " + spaceship + "AND CodeDelivery = " + code +
                    "AND DeliveryDate = " + date[2] + "-" + date[0] + "-" + date[1] + "00:00:00;";
            try
            {
                command = new SqlCommand(query, connection);

                if (command != null)
                {
                    //lblNau.ForeColor = Color.LimeGreen;
                    //lblNau.Font = new Font("Montserrat", 14, FontStyle.Regular);
                    //lblNau.Text = "Nau identificada correctament!";

                    MessageBox.Show("Nau identificada correctament");
                    response = spaceship + "AG";
                    gestioMsg.SendMessageUDP(response);
                    
                }
                else
                {
                    //lblNau.ForeColor = Color.Yellow;
                    //lblNau.Font = new Font("Montserrat", 14, FontStyle.Italic);
                    //lblNau.Text = "Nau no identificada.";

                    MessageBox.Show("Nau no identificada");
                    response = spaceship + "AD";
                    gestioMsg.SendMessageUDP(response);
                }

                string data = date[2] + date[0] + date[1];

                gestioMsg.dataReceivedSaved = spaceship;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public void StartReceivingMessagesUDP()
        {
            int port = IPCC.obtenirPort(consultes.queryPortUDPPlanet);
            rebutMsg = true;

            try
            {
                while (true)
                {
                    UnicodeEncoding ByteConverter = new UnicodeEncoding();
                    udpClient = new UdpClient(port);
                    IPEndPoint IeP = new IPEndPoint(IPAddress.Any, 0);

                    byte[] BytesIn = udpClient.Receive(ref IeP);
                    byte[] decryptedMessage = rsa.UDPRecivedToDecrypt(parametres, BytesIn);

                    string returnData = ByteConverter.GetString(decryptedMessage);
                    string[] receivedDeliveryDate = gestioMsg.getDate(returnData);
                    string receivedCodeDelivery = gestioMsg.getCode(returnData);
                    string receivedSpaceShip = gestioMsg.getSpaceShip(returnData);

                    verifySpaceship(receivedDeliveryDate, receivedCodeDelivery, receivedSpaceShip);

                    udpClient.Close();
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rebutMsg = false;
            }
        }

        private void aixecarServidor()
        {
            ThreadStart Tsm = null;

            // Mirem quin tipus de nau es
            tipusNau = Tnau.typeNau();
            tipusNau.Trim();

            lblServidor.ForeColor = Color.LimeGreen;
            lblServidor.Font = new Font("Montserrat", 14, FontStyle.Regular);
            lblServidor.Text = "Servidor aixecat!";

            // Files
            ThreadStart Tsf = new ThreadStart(StartReceivingFiles);
            Tf = new Thread(Tsf);
            Tf.SetApartmentState(ApartmentState.STA);
            Tf.IsBackground = true;
            Tf.Start();

            // Message
            if (tipusNau == "INNER")
            {
                Tsm = new ThreadStart(StartReceivingMessagesTCP);
            }
            else if (tipusNau == "OUTER")
            {
                outer = true;
                TaparMssg.Visible = true;
                Tsm = new ThreadStart(StartReceivingMessagesUDP);
            }

            Tm = new Thread(Tsm);
            Tm.SetApartmentState(ApartmentState.STA);
            Tm.IsBackground = true;
            Tm.Start();
        }

        public void encriptacioCGF()
        {
            string[] lletres_random = new string[1000000];

            if (rebutMsg && !outer)
            {
                try
                {
                    Directory.CreateDirectory(@"Fitxer\frmPlaneta\Lletres");

                    StreamWriter ftx_total = new StreamWriter(@"Fitxer\frmPlaneta\Lletres\LLetresTotals.txt");

                    for (int y = 1; y < 5; y++)
                    {
                        lletres_random = GenerarLLetresRnd(y, ftx_total);
                        GenerarArchivosNumeros(lletres_random, y);
                    }
                    ftx_total.Close();

                    comprimirCarpeta(@"Fitxer\frmPlaneta\PACS", @"Fitxer\frmPlaneta\PACS.zip");

                    lblCodificacio.ForeColor = Color.LimeGreen;
                    lblCodificacio.Font = new Font("Montserrat", 14, FontStyle.Regular);
                    lblCodificacio.Text = "Fitxer PACS creat correctament!";

                    // Agafar IP i Port
                    string ipNau = IPCC.obtenirIpEspecifica(consultes.queryIpSpaceShip);

                    int portFitxer = IPCC.obtenirPort(consultes.queryPortSpaceShipFiles);

                    EnviarPacs(@"Fitxer\frmPlaneta\PACS.zip", ipNau, portFitxer);

                    // Compte enrere
                    compteEnrere.Iniciat = true;
                    PnlTimer.Controls.Add(compteEnrere);

                    lblPACS.ForeColor = Color.LimeGreen;
                    lblPACS.Font = new Font("Montserrat", 14, FontStyle.Regular);
                    lblPACS.Text = "Fitxer PACS enviat correctament!";
                    //MessageBox.Show("Fitxer PACS creat i enviat correctament.");
                }
                catch (Exception e)
                {
                    lblPACS.ForeColor = Color.Yellow;
                    lblPACS.Font = new Font("Montserrat", 14, FontStyle.Regular);
                    lblPACS.Text = "Error enviant PACS, torna-ho a provar";
                    // MessageBox.Show(e.Message);
                }
            }
            else if (outer)
            {
                MessageBox.Show(BloquejatOuter);
            }
            else
            {
                lblCodificacio.ForeColor = Color.Yellow;
                lblCodificacio.Font = new Font("Montserrat", 14, FontStyle.Italic);
                lblCodificacio.Text = "No has establert connexió amb la nau";

                lblPACS.ForeColor = Color.Yellow;
                lblPACS.Font = new Font("Montserrat", 14, FontStyle.Italic);
                lblPACS.Text = "No has establert connexió amb la nau";

                // MessageBox.Show("No has establert connexió amb la nau");
            }
        }

        public void EnviarPacs(string SendingFilePath, string ip, int port)
        {
            if (SendingFilePath != string.Empty)
            {
                gestioMsg._RutaSendTCP = SendingFilePath;
                gestioMsg._IPSendTCP = ip;
                gestioMsg._PortSendTCP = port;
                gestioMsg.SendTCP();
            }
            else
            {
                MessageBox.Show("Select a file", "Warning");
            }
        }

        public void comprimirCarpeta(string ruta_carpeta, string zip)
        {
            try
            {
                if (File.Exists(zip))
                {
                    File.Delete(zip);
                }
                ZipFile.CreateFromDirectory(ruta_carpeta, zip);
            }
            catch
            {
                lblCodificacio.ForeColor = Color.Yellow;
                lblCodificacio.Font = new Font("Montserrat", 14, FontStyle.Italic);
                lblCodificacio.Text = "La carpeta no s'ha comprimit correctament";
                //MessageBox.Show("La carpeta no s'ha comprimit correctament");
            }
        }

        private string[] GenerarLLetresRnd(int y, StreamWriter ftx_total)
        {
            string[] lletres_random = new string[1000000];

            StreamWriter ftx = new StreamWriter(rutaLletres + y + ".txt");

            Random rnd = new Random();

            for (int i = 0; i < lletres_random.Length; i++)
            {
                int num = rnd.Next(0, 26); // 0 a 25
                string let = ((char)('a' + num)).ToString();

                ftx.Write(let);
                ftx_total.Write(let);
                lletres_random[i] = let;
            }
            ftx.Close();
            return lletres_random;
        }

        private void GenerarArchivosNumeros(string[] lletres_rand, int y)
        {
            string[] clau_arr = new string[26];
            bool controlador;

            clau_arr = carpetaZip.LlegirClau();

            Directory.CreateDirectory(@"Fitxer/frmPlaneta/PACS");

            StreamWriter nums_rand = new StreamWriter(rutaFitxerEncriptat + y + ".txt");

            for (int i = 0; i < lletres_rand.Length; i++)
            {
                controlador = false;
                for (int x = 0; x < lletres.Length && controlador == false; x++)
                {
                    string sadfasdf = lletres_rand[i];


                    if (lletres_rand[i].Equals(lletres[x]))
                    {
                        nums_rand.Write(clau_arr[x]);
                        controlador = true;
                    }
                }
            }
            nums_rand.Close();
        }

        #region BOTONS

        private void btPanelCGF_Click(object sender, EventArgs e)
        {
            encriptacioCGF();

        }

        private void btLabelCGF_Click(object sender, EventArgs e)
        {
            encriptacioCGF();

        }

        private void btImgCGF_Click(object sender, EventArgs e)
        {
            encriptacioCGF();
        }

        private void btPanelAS_Click(object sender, EventArgs e)
        {
            aixecarServidor();
        }

        private void btLabelAS_Click(object sender, EventArgs e)
        {
            aixecarServidor();
        }

        private void btImgAS_Click(object sender, EventArgs e)
        {
            aixecarServidor();
        }

        private void btTancarPlaneta_Click(object sender, EventArgs e)
        {
            try
            {
                Listener.Stop();
            }
            catch
            {
            };

            Application.Exit();
        }

        private void btImgCF_Click(object sender, EventArgs e)
        {
            compararFitxers();
        }

        private void btLabelCF_Click(object sender, EventArgs e)
        {
            compararFitxers();
        }

        private void btPanelCF_Click(object sender, EventArgs e)
        {
            compararFitxers();
        }

        private void btLabelRb_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btImgRb_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btPanelRb_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #endregion
    }
}
