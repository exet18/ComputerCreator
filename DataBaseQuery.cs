using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerService
{
    public class DataBaseQuery
    {

        private MySqlCommand _command;
        private MySqlDataAdapter _adapter;
        
        public DataBaseQuery()
        {
            DataBase db = new DataBase(); 
            _adapter = new MySqlDataAdapter();
            _command = new MySqlCommand();
            _command.Connection = db.GetConnection();
        }
        public DataTable GetProcessors()
        {
            return GetTable("SELECT `name`, `price`, `socket`, `company` FROM `cpu`");
        }
        public DataTable GetVideocards()
        {
            return GetTable("SELECT `name`, `price`, `ghz`, `company` FROM `gpu`");
        }
        private DataTable GetTable(string command)
        {
            DataTable table = new DataTable(); 
            _command.CommandText = command;
            _adapter.SelectCommand = _command;
            _adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            return null;
        }
    }
}
