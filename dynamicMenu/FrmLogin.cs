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

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //testeasradwq
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
                tbUser.Text = String.Empty;
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUser.Text))
            {
                tbUser.Text = "Usuário";
            }
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "password")
            {
                tbPass.Text = String.Empty;
            }
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPass.Text))
            {
                tbPass.Text = "password";
            }
        }

        #endregion
    }
}
