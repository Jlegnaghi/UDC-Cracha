using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace UDC_Cracha
{
    internal class Conexao
    {
        public OleDbConnection cn = new OleDbConnection(); 

        public void conectar()
        {
            cn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Data Source=Legnaghi";
            cn.Open();
        }
        public void desconectar()
        {
            cn.Close();
        }

    }
}
