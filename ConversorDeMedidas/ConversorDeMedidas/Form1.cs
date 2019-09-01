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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calcular calcular;

        private void LimparTextBoxs()
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

        private void Calcular()
        {
            calcular = new Calcular();
            bool input = false;

            foreach (Control ctl in pnlMedidas.Controls)
            {
                if (ctl is NumericUpDown)
                {
                    NumericUpDown num = ctl as NumericUpDown;
                    if (num.Value != 0)
                    {
                        if (input == false)
                        {
                            input = true; 
                        }
                        else
                        {
                            MessageBox.Show("Você só pode ter um valor definido para realizar o cálculo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                }
            }

            if (input == false)
            {
                MessageBox.Show("")
            }


            if (numMedida1.Value != 0)
            {
                calcular.RecebePosição = "K";
            }
            else if (numMedida2.Value != 0)
            {
                calcular.RecebePosição = "H";
            }
            else if (numMedida3.Value != 0)
            {
                calcular.rece
            }
        }

    }
}
