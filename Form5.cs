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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnTransferirLetras(object sender, EventArgs e)
        {
            var selecionados = lstAlfabeto.SelectedItems;

            foreach (var item in selecionados)
            {
                lstAlfabeto2.Items.Add(item);
                lstAlfabeto.Items.Remove(item);
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
