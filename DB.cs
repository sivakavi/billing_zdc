using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Billing
{
    class DB
    {

        MySqlConnection con = new MySqlConnection("SERVER=localhost;UID=root;PASSWORD=Manager;Database=MIS_Draft");
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlCommand cmd;

        public void connect()
        {
            try
            {
                con.Close();
                if (ConnectionState.Closed == con.State || ConnectionState.Broken == con.State)
                {
                    con.Open();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
