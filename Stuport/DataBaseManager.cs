using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuport
{
    
    public sealed class DataBaseManager
    {
        private static readonly DataBaseManager instance = new DataBaseManager();
        private static readonly OleDbConnection conn = new OleDbConnection(//@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\koketso\Desktop\BoDarki_Remake_DA.accdb
@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\koketso\Desktop\BoDarki_Remake_DA.accdb");

        // Explicit static constructor to tell C# compiler  
        // not to mark type as beforefieldinit
        static DataBaseManager() { 
        
        }

        private DataBaseManager() { }

        //Destructor
        

        public static DataBaseManager getInstance {
            get {
            
                return instance;
            }
        }
        public OleDbDataReader select(string query, object[] values) {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            for (int i = 0; i < values.Length; i++)
            {
                String parameterName = "@" + i;
                cmd.Parameters.AddWithValue(parameterName, values[i]);
            }
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void openConnection() {
            conn.Open();
        }

        public OleDbConnection GetOleDbConnection() {
            return conn;
        }

        public void closeConnection() {
            conn.Close();
        }

        public int update(string query, string[] values) {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);

            for (int i = 0; i < values.Length; i++)
            {

                String parameterName = "@" + i;
                cmd.Parameters.AddWithValue(parameterName, values[i]);
            }

            int result;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (OleDbException e)
            {
                result = 0;
            }


            conn.Close();
            return result;
        }

        public int insert(string tableName, string[] cols, object[] values) {
            conn.Open();

            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO ");
            sb.Append(tableName);
            sb.Append(" (");

            for (int i = 0; i < cols.Length; i++) {
                if (i != 0)
                {
                    sb.Append(", ");
                }

                sb.Append(cols[i]);
            }

            sb.Append(") values (");

            for (int i = 0; i < cols.Length; i++) {
                if (i != 0) {
                    sb.Append(", ");
                }

                sb.Append("@");
                sb.Append(i);
            }

            sb.Append(")");


            OleDbCommand cmd = new OleDbCommand(sb.ToString(), conn);

            for (int i = 0; i < values.Length; i++) {
               
                String parameterName = "@" + i;
                cmd.Parameters.AddWithValue(parameterName, values[i]);
            }

            int result;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (OleDbException e) {
                result = 0;
            }
                
            
            conn.Close();
            return result;
        }

    }
}
