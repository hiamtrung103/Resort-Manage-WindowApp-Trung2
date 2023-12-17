using System;
using System.Data;
using System.Data.SqlClient;

namespace baitap.Model
{
    public class ConnectToSQL
    {
        private SqlConnection Conn;
        public string StrCon = null;
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public SqlConnection KetNoi
        {
            get { return Conn; }
        }

        public string ChuoiKetNoi
        {
            get { return StrCon; }
        }

        public ConnectToSQL()
        {
            StrCon = "Data Source=TRUNQ\\MSSQLSERVER01;Initial Catalog=ql_resort;Integrated Security=True;"; 
            Conn = new SqlConnection(StrCon);
        }

        public bool MoKetNoi()
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

        public bool DongKetNoi()
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
