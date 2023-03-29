using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDC_Cracha
{
    static class Autenticacao
    {
        static string nome;
        static string senha;
        static int nivel;

        public static void login(string nome1, string senha1, int nivel1) 
        {
            nome =nome1;
            senha = senha1;
            nivel = nivel1;
        }
        public static void logout()
        {
            nome = null;
            senha = null;
            nivel = 0;
        }

        public static string getUsuario() 
        {
            return "Nome: " + nome + "\nSenha: " + senha + "\nNivel: " + nivel;
        }
    }
}
