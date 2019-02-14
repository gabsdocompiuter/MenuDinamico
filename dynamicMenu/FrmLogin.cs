using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamicMenu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mostra e oculta a senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bViewPass_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '\0')
            {
                tbPass.PasswordChar = '●';
                bViewPass.Image = Properties.Resources.eye_24x24;
            }
            else
            {
                tbPass.PasswordChar = '\0';
                bViewPass.Image = Properties.Resources.eye_hidden_24x24;
            }
        }

        #region Textos padrões

        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "Usuário")
            {
                tbUser.Text = string.Empty;
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUser.Text))
            {
                tbUser.Text = "Usuário";
            }
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "password")
            {
                tbPass.Text = string.Empty;
            }
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPass.Text))
            {
                tbPass.Text = "password";
            }
        }

        #endregion

        #region Eventos da Tela

        /// <summary>
        /// Botão Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Botão Logar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLogin_Click(object sender, EventArgs e)
        {
            /*
             * ... Realiza verificações do login ...
             * 
             */

            //Após realizar o login, abre o Menu Principal
            FrmMain main = new FrmMain();
            main.ShowDialog();

            //Após fechar o principal, finalizar o programa
            this.Close();
        }

        #endregion
    }
}
