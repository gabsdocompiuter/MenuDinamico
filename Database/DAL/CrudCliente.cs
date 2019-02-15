using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Database.Model;

namespace Database.DAL
{
    public class CrudCliente : Crud
    {
        public Cliente GetCliente(int id)
        {
            Cliente cliente = new Cliente();

            IDataReader r = null;
            try
            {
                AbrirConexão();

                string sql = $"SELECT * FROM Cliente WHERE id = {id};";

                r = ExecuteReader(sql);
                r.Read();

                cliente.Id = r.GetInt32(r.GetOrdinal("Id"));
                cliente.Nome = r.GetString(r.GetOrdinal("Nome"));
                cliente.Email = r.GetString(r.GetOrdinal("Email"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro: \n" + ex);
            }
            finally
            {
                r.Close();
                FecharConexao();
            }
            return cliente;
        }
        
        public DataTable GetDataTable()
        {
            return base.GetDataTable(new Cliente());
        }
    }
}
