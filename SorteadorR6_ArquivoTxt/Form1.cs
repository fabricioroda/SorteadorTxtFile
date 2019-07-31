using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteadorR6_ArquivoTxt
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<string> linhasL = new List<string>();
            using (StreamReader reader = new StreamReader(@"C:\temp\R6.txt"))
            {
                string Linhas = string.Empty;
                while ((Linhas = reader.ReadLine()) != null)
                {
                    linhasL.Add(Linhas);
                }

                Random rand = new Random();
                int aleatorio = rand.Next(0, linhasL.Count);
                lblResultado.Text = "O Sorteado foi " + (linhasL[aleatorio]);
                Thread.Sleep(1500);
                lblResultado.Visible = true;
                btnSorteio.Enabled = false;
                btnLimpar.Enabled = true;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            btnSorteio.Enabled = true;
            lblResultado.Text = "";
            lblResultado.Visible = false;
        }
    }
}
