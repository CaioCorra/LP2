using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // nome
        {
            if (e.KeyChar == (char)(13)) // tecla que foi pressionada
            {
                SendKeys.Send("{TAB");
                e.Handled = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e) // endereço
        {
            if (textBox2.Text==' ') || textBox2.Text.Length < 20))
                    {
                MessageBox.Show("Endereço Inválido");
                textBox2.Focus();
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e) // email
        {
            if (textBox3.Text==" ")
            {
                MessageBox.Show("E-mail Vazio");
            }   e.Cancel = true;

        }

        private void textBox4_Leave(object sender, EventArgs e) // Celular
        {
            MessageBox.Show("celular-textbox4 perdeu o foco");
        }

        private void textBox5_Enter(object sender, EventArgs e) // CPF
        {

            MessageBox.Show("cps~textbox5 ganhou o foco")
        }
    }
}