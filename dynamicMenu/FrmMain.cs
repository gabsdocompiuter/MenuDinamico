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
    public partial class FrmMain : Form
    {

        private int hBtn = 40;
        private int wBtn = 209;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CarregaMenu();
        }

        private void CarregaMenu()
        {
            //Tamanho da tela
            int yTela = this.Size.Height;

            //Quantidade de itens no menu
            int qtd = 4;

            String nome = "teste";

            int pos1 = ((yTela - qtd * hBtn) / 2) - (hBtn/2);

            for (int i = 0; i < qtd; i++)
            {
                int pos = pos1 + (i * hBtn);

                String icnNome = $"icn{nome}{i}";
                String btnNome = $"{nome}{i}";

                AddIcn(pos, icnNome);
                AddButton(pos, btnNome, "Texto" + i);
            }
        }

        /// <summary>
        /// Adiciona ícone lateral
        /// </summary>
        /// <param name="y"></param>
        /// <param name="name"></param>
        private void AddIcn(int y, String name)
        {
            Panel p = new Panel
            {
                Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                BackColor = Color.Green,
                Name = name,
                TabStop = false,
                Size = new Size(10, hBtn),
                Location = new Point(0, y),
                Visible = false
            };
            pMenuLateral.Controls.Add(p);
        }

        /// <summary>
        /// Adiciona Botão no menu
        /// </summary>
        /// <param name="y"></param>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        private void AddButton(int y, String name, String desc)
        {
            Button b = new Button
            {
                Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(10, y),
                Font = new Font("Microsoft Sans Serif", 10F),
                ForeColor = Color.FromArgb(217, 217, 217),
                Name = name,
                Size = new Size(wBtn, hBtn),
                TabStop = true,
                Text = desc
            };
            b.FlatAppearance.BorderSize = 0;

            b.Click += new EventHandler(MenuClick);
            pMenuLateral.Controls.Add(b);
        }

        /// <summary>
        /// Click de alguma opção do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuClick(object sender, EventArgs e)
        {
            //Deixa todos com a cor padrão
            foreach (Control p in pMenuLateral.Controls)
            {
                if (p is Panel)
                {
                    p.Visible = false;
                }
            }

            Button b = (Button)sender;
            String pName = "icn" + b.Name;

            //Muda a cor do ícone
            Panel icn = pMenuLateral.Controls.Find(pName, false).FirstOrDefault() as Panel;
            icn.Visible = true;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
