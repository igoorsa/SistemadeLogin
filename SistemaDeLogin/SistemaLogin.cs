using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLogin
{
    class SistemaLogin
    {
        private static Usuarios[] users = new Usuarios[]
        {
            new Usuarios() {nome = "Paulo", senha= "Alves"},
            new Usuarios() {nome = "Fabio", senha= "Alves"}
        };
        public static string Con = null;
        
        public static string _usuario { get; private set; }
       
        public bool FazerLogin(string nome, string senha)
        {

            foreach (Usuarios u in users)
            {

                if (u.nome == nome & u.senha == senha )
                {
                    _usuario= u.nome;
                    Con = "";
                    return true;
                }
                
            }
                    return false;
        }
    }
}
