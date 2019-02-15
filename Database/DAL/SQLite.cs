using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace Database.DAL
{
    public class SQLite
    {
        private SQLiteConnection conn;
        private SQLiteCommand comm;

        /// <summary>
        /// Construtor
        /// </summary>
        public SQLite()
        {
            conn = new SQLiteConnection("Data Source=banco.db;");
        }

        protected void AbrirConexão()
        {
            conn.Open();

            comm = new SQLiteCommand(conn);
        }

        protected void FecharConexao()
        {
            conn.Close();
        }

        protected void ExecuteNonQuery(string sql)
        {
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
        }

        protected SQLiteDataReader ExecuteReader(string sql)
        {
            comm.CommandText = sql;
            return comm.ExecuteReader();
        }

        protected DataTable ExecuteDataTable(string sql)
        {
            DataTable dt = new DataTable();
            dt.Load(ExecuteReader(sql));

            return dt;
        }
    }
}
