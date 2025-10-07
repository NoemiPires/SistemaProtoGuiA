using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProtoGuiA
{
    public partial class ValidacaoServidor : Form
    {
        public ValidacaoServidor()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            String cpf = mskCpf.Text;

            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");
            //MessageBox.Show(cpf);

            UInt32 cpfInteiro = Convert.ToUInt32(cpf);

            MessageBox.Show(cpfInteiro.ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
