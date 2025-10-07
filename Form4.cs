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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            cboProduto.DataSource = new FakeDb().LoadAll();
            lstProduto.DataSource = new FakeDb().LoadAll();
        }
        private void BtnExibir_Click(object sender, EventArgs e)
        {
            var selecionados = lstProduto.SelectedItems;

            //List<Produto> selecionados
            //    = (List<Produto>)lstProduto.SelectedItems.Cast<Produto>();
            //    = lstProduto.SelectedItems.Cast<Produto>().ToList();

            StringBuilder sb = new StringBuilder();
            foreach (Produto item in selecionados)
            {
                sb.AppendLine(item.ToString());
            }
            MessageBox.Show(sb.ToString());
        }

    }
}
