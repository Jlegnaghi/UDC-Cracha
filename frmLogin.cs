using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UDC_Cracha
{
    public partial class fmrLogin : Form
    {
        Thread cadastro;
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUsuario.Text.Equals("Jefferson") || txtUsuario.Text.Equals("jefferson")) && txtSenha.Text.Equals("teste"))
                {
                    // Ir para frmCadastro
                    this.Close();
                    cadastro = new Thread(abrirCadastro);
                    cadastro.SetApartmentState(ApartmentState.STA);
                    cadastro.Start();

                } else
                {
                    MessageBox.Show("Usuário ou senha Incorretos",
                                    "Desculpe",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Desculpe",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void abrirCadastro(object obj)
        {
            Application.Run(new frmCadastro());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
