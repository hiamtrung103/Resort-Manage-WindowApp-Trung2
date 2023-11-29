using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap.Model
{
    class ConnectToSQL
    {
        private SqlConnection Conn;
        private string StrCon = null;
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public SqlConnection Connection
        {
            get { return Conn; }
        }

        public ConnectToSQL()
        {
            StrCon = "Data Source=Trunq;Initial Catalog=ql_resort;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
        }

        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }

        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
    }
}
