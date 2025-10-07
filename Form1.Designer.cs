namespace SistemaProtoGuiA
{
    partial class pnlPricipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlPricipal));
            pnlPrincipal = new Panel();
            lblAlerta = new Label();
            txtNome = new TextBox();
            btnSalvar = new Button();
            chkAtivo = new CheckBox();
            lblNome = new Label();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.BorderStyle = BorderStyle.FixedSingle;
            pnlPrincipal.Controls.Add(lblAlerta);
            pnlPrincipal.Controls.Add(txtNome);
            pnlPrincipal.Controls.Add(btnSalvar);
            pnlPrincipal.Controls.Add(chkAtivo);
            pnlPrincipal.Controls.Add(lblNome);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(756, 232);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblAlerta
            // 
            lblAlerta.AutoSize = true;
            lblAlerta.Font = new Font("Pent-Up Rage", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlerta.ForeColor = Color.Red;
            lblAlerta.Location = new Point(13, 196);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(130, 20);
            lblAlerta.TabIndex = 4;
            lblAlerta.Text = "Digite um Nome válido";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Pent-Up Rage", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(89, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(666, 30);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += textNome_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Pent-Up Rage", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(660, 117);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 30);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Pent-Up Rage", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAtivo.Location = new Point(89, 117);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(64, 27);
            chkAtivo.TabIndex = 1;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Pent-Up Rage", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(15, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(54, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome: ";
            lblNome.Click += label1_Click;
            // 
            // pnlPricipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 256);
            Controls.Add(pnlPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "pnlPricipal";
            Text = "Cadastro de Pessoa";
            WindowState = FormWindowState.Minimized;
            Load += pnlPricipal_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Label lblNome;
        private TextBox txtNome;
        private Button btnSalvar;
        private CheckBox chkAtivo;
        private Label lblAlerta;
    }
}
