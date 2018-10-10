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

        #region Padrões dos Botões

        #region Tamanhos

        /// <summary>
        /// Altura do botão
        /// </summary>
        private int hBtn = 40;

        /// <summary>
        /// Largura do botão
        /// </summary>
        private int wBtn;

        /// <summary>
        /// Largura do Icn (Parte colorida na esquerda)
        /// </summary>
        private int wIcn = 7;

        #endregion

        #region Cores

        /// <summary>
        /// Cor do botão - stantard
        /// </summary>
        private Color crBtnSt = Color.FromArgb(217, 217, 217);

        /// <summary>
        /// Cor do botão - selecionado
        /// </summary>
        private Color crBtnSl = Color.FromArgb(59, 60, 63);

        /// <summary>
        /// Cor dos Icn (Parte colorida na esquerda)
        /// </summary>
        private Color crIcn = Color.FromArgb(30, 30, 30);

        #endregion

        #endregion

        public FrmMain()
        {
            InitializeComponent();

            wBtn = pMenuLateral.Size.Width;
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

            //Calculo para centralizar os botões verticalmente
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
        /// <param name="posY"></param>
        /// <param name="name"></param>
        private void AddIcn(int posY, String name)
        {
            Panel p = new Panel
            {
                Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                BackColor = crIcn,
                Name = name,
                TabStop = false,
                Size = new Size(wIcn, hBtn),
                Location = new Point(0, posY),
                Visible = false
            };
            pMenuLateral.Controls.Add(p);
        }

        /// <summary>
        /// Adiciona Botão no menu
        /// </summary>
        /// <param name="posY"></param>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        private void AddButton(int posY, String name, String desc)
        {
            Button b = new Button
            {
                Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, posY),
                Font = new Font("Microsoft Sans Serif", 10F),
                ForeColor = crBtnSt,
                Name = name,
                Size = new Size(wBtn, hBtn),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(wIcn, 0, 0, 0),
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
            foreach (Control c in pMenuLateral.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }

                if (c is Button)
                {
                    c.BackColor = pMenuLateral.BackColor;
                }
            }

            Button b = (Button)sender;
            String pName = "icn" + b.Name;

            //Muda para as novas cores
            b.BackColor = crBtnSl;

            Panel icn = pMenuLateral.Controls.Find(pName, false).FirstOrDefault() as Panel;
            icn.Visible = true;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
