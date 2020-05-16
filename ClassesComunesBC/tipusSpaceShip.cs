using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesComunesBC
{
    public class tipusSpaceShip
    {
        public string ConnectionString = "Server=thegungans.database.windows.net; Database=RepublicSystem; User Id=gungan; Password=12345aA12345aA";

        ClassesComunesBC.RSA rsa = new ClassesComunesBC.RSA();
        ConsultesBBDD consultes = new ConsultesBBDD();

        public string typeNau()
        {
            string nau;

            SqlConnection conectarBD = new SqlConnection();
            conectarBD.ConnectionString = ConnectionString;
            conectarBD.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            da = new SqlDataAdapter(consultes.queryTypeSpaceShip, conectarBD);
            da.Fill(ds);


            nau = ds.Tables[0].Rows[0][0].ToString();

            return nau;
        }
    }
}
