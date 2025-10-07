namespace SistemaProtoGuiA
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lstUsuarios = new ListBox();
            btnSalvar = new Button();
            cboUsuarios = new ComboBox();
            cboUsuario = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lstUsuarios);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(cboUsuarios);
            panel1.Controls.Add(cboUsuario);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 324);
            panel1.TabIndex = 0;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(33, 230);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.SelectionMode = SelectionMode.MultiSimple;
            lstUsuarios.Size = new Size(320, 49);
            lstUsuarios.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(33, 166);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(190, 33);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboUsuarios
            // 
            cboUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuarios.FormattingEnabled = true;
            cboUsuarios.Location = new Point(33, 92);
            cboUsuarios.Name = "cboUsuarios";
            cboUsuarios.Size = new Size(378, 23);
            cboUsuarios.TabIndex = 1;
            // 
            // cboUsuario
            // 
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Items.AddRange(new object[] { "Ana Zaira", "Beatriz Yana", "Cecilia Xerxes", "Debora Wender", "Eugene Vasconceles" });
            cboUsuario.Location = new Point(29, 24);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(374, 23);
            cboUsuario.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 348);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboUsuario;
        private ComboBox cboUsuarios;
        private Button btnSalvar;
        private ListBox lstUsuarios;
    }
}