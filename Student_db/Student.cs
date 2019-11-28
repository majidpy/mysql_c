using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_db
{
    class Student
    {
        MY_DB db = new MY_DB();

        public Boolean InsertStudent(String fname, string lname, DateTime dob, string gender)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO students (`First_Name`, `Last_Name`, `DoB`, `Gender`) VALUES (@fname, @lname, @bd, @gen);", db.getConnection);

            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = dob;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender;
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }
    }
}

