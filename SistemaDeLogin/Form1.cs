using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login f = new Login(); 

            while (SistemaLogin.Con == null)
            {
                Visible = false;
                f.ShowDialog();
            }
            
            label1.Text = $"Seja Bem Vindo(a){SistemaLogin._usuario}";
        }

       
    }
}
