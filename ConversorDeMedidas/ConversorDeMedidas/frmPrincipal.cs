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

        private void LimparTextBoxs(object sender, EventArgs e)
        {
            foreach (Control ctl in pnlMedidas.Controls)
            {
                if (ctl is NumericUpDown)
                {
                    NumericUpDown num = ctl as NumericUpDown;
                    num.Value = 0;
                }
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
                        MessageBox.Show("Você só pode ter um valor definido para realizar o cálculo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        input = false;
                        break;
                    }
                }
            }

            if (input)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i].Value = calcular.Resultados[i];
                }
            }
            else
            {
                calcular.Posição = "";
                calcular.NumeroOrigem = 0;
                MessageBox.Show("Você precisa definir pelo menos um valor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
