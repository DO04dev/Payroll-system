using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string pkk;

        public void DbConnection()
        {
            con = new SqlConnection(@"Data Source=*************;Initial Catalog=MiniPayroll;User ID=******;Password=***********");
            con.Open();
        }

        public void dataSend(string SQL)
        {
            try
            {
                DbConnection();
                cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                pkk = "";
            }catch(Exception ex)
            {
                pkk = "Please double Check Your Data";
            }
            con.Close();
        }

        public void dataGet(string SQL)
        {
            try
            {
                DbConnection();
                sda = new SqlDataAdapter(SQL, con);
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}
