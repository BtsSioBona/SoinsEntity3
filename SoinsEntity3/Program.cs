using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinsEntity3
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection con = new OracleConnection();
            
            con.ConnectionString = "SERVER=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.10.2.10)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=slam)));User id=rahmanesoin; Password=slam;";
            con.Open();
            Console.WriteLine("Connected to Oracle" + con.ServerVersion);

            // Close and Dispose OracleConnection object
            con.Close();
            con.Dispose();
            Console.WriteLine("Disconnected");
            Console.ReadLine();
        }
    }
}
