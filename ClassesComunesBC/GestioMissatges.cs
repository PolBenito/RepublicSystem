using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClassesComunesBC
{
    public class GestioMissatges
    {
        IP IPCC = new IP();
        ConsultesBBDD consultes = new ConsultesBBDD();
        Ejemplo_RSA EjRSA = new Ejemplo_RSA();

        public string ConnectionString = "Server=thegungans.database.windows.net; Database=RepublicSystem; User Id=gungan; Password=12345aA12345aA";

        public string dataReceivedSaved = "";

        private const int BufferSize = 1024;

        #region PROPIETATS

        public string _RutaSendTCP;

        public string RutaSendTCP
        {
            get { return _RutaSendTCP; }
            set
            {
                _RutaSendTCP = value;
            }
        }

        public string _IPSendTCP;

        public string IPSendTCP
        {
            get { return _IPSendTCP; }
            set
            {
                _IPSendTCP = value;
            }
        }

        public int _PortSendTCP;

        public int PortSendTCP
        {
            get { return _PortSendTCP; }
            set
            {
                _PortSendTCP = value;
            }
        }

        #endregion

        #region MISSATGE

        public string missatge(string queryIp, string queryPort)
        {
            const int tres = 3;
            string[] receivedDeliveryDate = new string[tres];

            string receivedCodeDelivery;
            string receivedSpaceShip;

            string existeixNau = "Nau no identificada.";

            SqlConnection connection = new SqlConnection(ConnectionString);

            string dataReceived = ReceiveMessage(queryIp, queryPort);
            receivedDeliveryDate = getDate(dataReceived);
            receivedCodeDelivery = getCode(dataReceived);
            receivedSpaceShip = getSpaceShip(dataReceived);

            string myQuery = "SELECT SpaceShip, CodeDelivery, DeliveryDate FROM DeliveryData" +
                    "WHERE SpaceShip = " + receivedSpaceShip + "AND CodeDelivery = " + receivedCodeDelivery +
                    "AND DeliveryDate = " + receivedDeliveryDate[2] + "-" + receivedDeliveryDate[0] + "-" + receivedDeliveryDate[1] + "00:00:00;";

            try
            {
                SqlCommand command = new SqlCommand(myQuery, connection);


                if (command != null)
                {
                    existeixNau = "Nau identificada correctament.";
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                existeixNau = "Error";
            }

            return existeixNau;
        }

        public string ReceiveMessage(string queryIp, string queryPort)
        {
            string dataReceived = "";

            int port = IPCC.obtenirPort(queryPort);

            string ip = IPCC.obtenirIpEspecifica(queryIp);

            IPAddress localAddress = IPAddress.Parse(ip);
            TcpListener listener = new TcpListener(port);

            try
            {
                listener.Start();

                TcpClient client = listener.AcceptTcpClient();

                NetworkStream ns = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                int bytesRead = ns.Read(buffer, 0, client.ReceiveBufferSize);

                dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                ns.Write(buffer, 0, bytesRead);
                client.Close();
                listener.Stop();

                dataReceivedSaved = dataReceived;
            }
            catch { }

            return dataReceived;
        }

        public void SendMessageTCP(string data, string queryIp, string queryPort)
        {
            int port = IPCC.obtenirPort(queryPort);

            string ip = IPCC.obtenirIpEspecifica(queryIp);

            string message = data;

            TcpClient client = new TcpClient(ip, port);
            NetworkStream ns = client.GetStream();
            byte[] bytesToSend = Encoding.ASCII.GetBytes(message);

            ns.Write(bytesToSend, 0, bytesToSend.Length);

            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = ns.Read(bytesToRead, 0, client.ReceiveBufferSize);
            client.Close();
        }

        public void SendMessageUDP(string response)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            string ipNau = IPCC.obtenirIpEspecifica(consultes.queryIpSpaceShip);
            int portMissatge = IPCC.obtenirPort(consultes.queryPortUDPSpaceShip);

            UdpClient udpClient = new UdpClient();
            udpClient.Connect(new IPEndPoint(IPAddress.Parse(ipNau), portMissatge));
            Byte[] sendData = ByteConverter.GetBytes(response);
            udpClient.Send(sendData, sendData.Length);
            udpClient.Close();
        }

        #endregion

        public string[] getDate(string data)
        {
            string[] date = new string[3];

            string month = data.Substring(0, 2);
            string day = data.Substring(2, 4);
            string year = data.Substring(4, 8);

            date[0] = month;
            date[1] = day;
            date[2] = year;

            return date;
        }

        public string getCode(string data)
        {
            string code = data.Substring(16);

            return code;
        }

        public string getSpaceShip(string data)
        {
            string ship = data.Substring(8, 8);
 
            return ship;
        }

        public void resultatComparacio(bool iguals, string queryIp, string queryPort, string tipusNau)
        {
            string response;
            string receivedSpaceShip = "";


            receivedSpaceShip = getSpaceShip(dataReceivedSaved);

            try
            {
                if (iguals)
                {
                    response = receivedSpaceShip + "AG";
                }
                else
                {
                    response = receivedSpaceShip + "AD";
                }

                SendMessageTCP(response, queryIp, queryPort);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void SendTCP()
        {
            string M = RutaSendTCP;
            string IPA = IPSendTCP;
            int PortN = PortSendTCP;

            byte[] SendingBuffer = null;
            TcpClient client = null;
            NetworkStream netstream = null;
            try
            {
                client = new TcpClient(IPA, PortN);
                netstream = client.GetStream();
                FileStream Fs = new FileStream(M, FileMode.Open, FileAccess.Read);
                int NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));
                int TotalLength = (int)Fs.Length, CurrentPacketLength;
                for (int i = 0; i < NoOfPackets; i++)
                {
                    if (TotalLength > BufferSize)
                    {
                        CurrentPacketLength = BufferSize;
                        TotalLength = TotalLength - CurrentPacketLength;
                    }
                    else
                        CurrentPacketLength = TotalLength;

                    SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                    netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                }

                Fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                netstream.Close();
                client.Close();
            }
        }
    }
}
