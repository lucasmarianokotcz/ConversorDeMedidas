using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeMedidas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        Calcular calcular;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LimparTextBoxs(null, null);
        }
        private void LimparTextBoxs(object sender, EventArgs e)
        {
            foreach (Control numeric in pnlMedidas.Controls)
            {
                numeric.Text = "0";
                numeric.ResetText();
            }
        }

        private void Calcular(object sender, EventArgs e)
        {
            calcular = new Calcular();
            bool input = false;

            NumericUpDown[] nums = new NumericUpDown[] { numMedida1, numMedida2, numMedida3, numMedida4, numMedida5, numMedida6, numMedida7 };
            string[] posicoes = new string[] { "K", "H", "DA", "", "D", "C", "M" };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].Value != 0)
                {
                    if (input == false)
                    {
                        input = true;
                        calcular.Posição = posicoes[i];
                        calcular.NumeroOrigem = nums[i].Value;
                    }
                    else
                    {
                        input = false;
                        break;
                    }
                }
            }

            if (input)
            {
                calcular.RealizaCalculo();

                for (int i = 0; i < nums.Length; i++)
                {
                    try
                    {
                        nums[i].Value = calcular.Resultados[i];
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        nums[i].Value = 0;
                    }
                }
            }
            else
            {
                calcular.Posição = "";
                calcular.NumeroOrigem = 0;
                MessageBox.Show("Você precisa definir apenas um valor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
