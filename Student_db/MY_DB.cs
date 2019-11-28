using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Student_db
{
    class MY_DB
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=majid2112;database=student");

        public MySqlConnection getConnection
        {
            get
            {
                return conn;
            }
            
        }

        public void openConnection()
        {
             if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
