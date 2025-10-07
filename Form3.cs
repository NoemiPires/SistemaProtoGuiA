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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            List<Usuario> usuarios = new List<Usuario>();

            Usuario usuarioTemporario;

            // #1
            usuarioTemporario = new Usuario() { Nome = "Ana Zaia", Ativo = false };
            cboUsuarios.Items.Add(usuarioTemporario);
            lstUsuarios.Items.Add(usuarioTemporario);

            // #2
            usuarioTemporario = new Usuario() { Nome = "Beatriz Yana", Ativo = true };
            cboUsuarios.Items.Add(usuarioTemporario);
            lstUsuarios.Items.Add(usuarioTemporario);

            // #3
            usuarioTemporario = new Usuario() { Nome = "Cecilia Xerxes", Ativo = false };
            cboUsuarios.Items.Add(usuarioTemporario);
            lstUsuarios.Items.Add(usuarioTemporario);

            // Permite que uma das opções venha pre selecionada
            cboUsuarios.SelectedIndex = 1;
            lstUsuarios.SelectedIndex = 1;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuarioSelecionado
                = (Usuario)cboUsuarios.SelectedItem;

            MessageBox.Show(usuarioSelecionado.ToString() + "\n ");
        }
    }
}
