using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace dynamicMenu
{
    public partial class Config : Form
    {
        private String configFile = "config.xml";

        public String dbAddress { get; private set; }
        public String dbUser { get; private set; }
        public String dbPass { get; private set; }
        public String dbPort { get; private set; }

        /// <summary>
        /// Construtor
        /// </summary>
        public Config()
        {
            InitializeComponent();

            if (System.IO.File.Exists(configFile))
            {
                LoadConfig();
            }
            else
            {
                CreateConfig();
            }

        }

        /// <summary>
        /// Lê as configurações salvas no arquivo de configurações
        /// </summary>
        private void LoadConfig()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            dbAddress = doc.SelectSingleNode("/config/address").InnerText;
            dbUser = doc.SelectSingleNode("/config/user").InnerText;
            dbPass = doc.SelectSingleNode("/config/password").InnerText;
            dbPort = doc.SelectSingleNode("/config/port").InnerText;
        }

        /// <summary>
        /// Cria e salva configurações
        /// </summary>
        private void CreateConfig()
        {
            ShowDialog();

            #region Salva XML

            XmlDocument doc = new XmlDocument();

            XmlElement xeConfig = doc.CreateElement("config");

            XmlElement xeAddress = doc.CreateElement("address");
            xeAddress.InnerText = dbAddress;
            xeConfig.AppendChild(xeAddress);

            XmlElement xeUser = doc.CreateElement("user");
            xeUser.InnerText = dbUser;
            xeConfig.AppendChild(xeUser);

            XmlElement xePass = doc.CreateElement("password");
            xePass.InnerText = dbPass;
            xeConfig.AppendChild(xePass);

            XmlElement xePort = doc.CreateElement("port");
            xePort.InnerText = dbPort;
            xeConfig.AppendChild(xePort);

            doc.AppendChild(xeConfig);
            doc.Save(configFile);

            #endregion

        }

        #region Métodos da Tela

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            dbAddress = tbAddress.Text;
            dbPass = tbPass.Text;
            dbPort = tbPort.Text;
            dbUser = tbUser.Text;

            this.Close();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
        }

        #endregion
    }
}
