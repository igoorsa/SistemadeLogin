using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string nome = Usuario.Text;
            string senha = Senha.Text;
                
            SistemaLogin login = new SistemaLogin();    

            if (login.FazerLogin(nome, senha))
            {
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Não Cadastrado");
                Usuario.Text = "";
                Senha.Text = "";
                Usuario.Focus();
                Close();
            }
            
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            SistemaLogin.Con = "";

        }
    }
}
