using System;
using SistemaProtoGuiA;

namespace SistemaProtoGuiA
{
    public partial class pnlPricipal : Form
    {
        public pnlPricipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                lblAlerta.Visible = true;
                txtNome.Focus();
                txtNome.SelectAll();
                return;
            }

            Usuario usuario = new Usuario();

            usuario.Nome = txtNome.Text;
            usuario.Ativo = chkAtivo.Checked;

            UsuarioRepository.SaveOrUpdate(usuario);
            MessageBox.Show("Nome: " + usuario.Nome + "\nAtivo: " + usuario.Ativo);
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            lblAlerta.Visible = false;
        }

        private void pnlPricipal_Load(object sender, EventArgs e)
        {
            lblAlerta.Visible = false;

        }
    }
}
