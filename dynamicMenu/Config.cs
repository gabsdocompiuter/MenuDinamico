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
    public partial class Config : Form
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public Config()
        {
            InitializeComponent();

            if (System.IO.File.Exists("config.xml"))
            {
                LoadConfig();
            }
            else
            {
                CreateConfig();
            }

        }

        private void LoadConfig()
        {

        }

        private void CreateConfig()
        {
            ShowDialog();
        }
    }
}
