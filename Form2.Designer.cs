namespace SistemaProtoGuiA
{
    partial class ValidacaoServidor
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
            pnlSecundario = new Panel();
            mskCpf = new MaskedTextBox();
            dateTimePicker2 = new DateTimePicker();
            btnSalavar = new Button();
            dateTimePicker1 = new DateTimePicker();
            grpCargo = new GroupBox();
            radServidor = new RadioButton();
            radCoordenador = new RadioButton();
            grpSexo = new GroupBox();
            radFeminino = new RadioButton();
            radMasculino = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            mskTelefone = new MaskedTextBox();
            pnlSecundario.SuspendLayout();
            grpCargo.SuspendLayout();
            grpSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pnlSecundario
            // 
            pnlSecundario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSecundario.Controls.Add(mskTelefone);
            pnlSecundario.Controls.Add(mskCpf);
            pnlSecundario.Controls.Add(dateTimePicker2);
            pnlSecundario.Controls.Add(btnSalavar);
            pnlSecundario.Controls.Add(dateTimePicker1);
            pnlSecundario.Controls.Add(grpCargo);
            pnlSecundario.Controls.Add(grpSexo);
            pnlSecundario.Controls.Add(numericUpDown1);
            pnlSecundario.Location = new Point(12, 12);
            pnlSecundario.Name = "pnlSecundario";
            pnlSecundario.Size = new Size(572, 301);
            pnlSecundario.TabIndex = 0;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(9, 20);
            mskCpf.Mask = "000\\.000\\.000\\-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(258, 23);
            mskCpf.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(439, 20);
            dateTimePicker2.MaxDate = new DateTime(2025, 9, 30, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(120, 23);
            dateTimePicker2.TabIndex = 6;
            dateTimePicker2.Value = new DateTime(2025, 9, 30, 0, 0, 0, 0);
            // 
            // btnSalavar
            // 
            btnSalavar.Location = new Point(413, 232);
            btnSalavar.Name = "btnSalavar";
            btnSalavar.Size = new Size(146, 49);
            btnSalavar.TabIndex = 5;
            btnSalavar.Text = "Salvar";
            btnSalavar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(10, 243);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // grpCargo
            // 
            grpCargo.Controls.Add(radServidor);
            grpCargo.Controls.Add(radCoordenador);
            grpCargo.Location = new Point(9, 122);
            grpCargo.Name = "grpCargo";
            grpCargo.Size = new Size(257, 64);
            grpCargo.TabIndex = 2;
            grpCargo.TabStop = false;
            grpCargo.Text = "Cargo";
            // 
            // radServidor
            // 
            radServidor.AutoSize = true;
            radServidor.Location = new Point(138, 40);
            radServidor.Name = "radServidor";
            radServidor.Size = new Size(68, 19);
            radServidor.TabIndex = 2;
            radServidor.TabStop = true;
            radServidor.Text = "Servidor";
            radServidor.UseVisualStyleBackColor = true;
            // 
            // radCoordenador
            // 
            radCoordenador.AutoSize = true;
            radCoordenador.Location = new Point(7, 40);
            radCoordenador.Name = "radCoordenador";
            radCoordenador.Size = new Size(95, 19);
            radCoordenador.TabIndex = 1;
            radCoordenador.TabStop = true;
            radCoordenador.Text = "Coordenador";
            radCoordenador.UseVisualStyleBackColor = true;
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(radFeminino);
            grpSexo.Controls.Add(radMasculino);
            grpSexo.Location = new Point(10, 59);
            grpSexo.Name = "grpSexo";
            grpSexo.Size = new Size(257, 57);
            grpSexo.TabIndex = 1;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo";
            // 
            // radFeminino
            // 
            radFeminino.AutoSize = true;
            radFeminino.Location = new Point(6, 32);
            radFeminino.Name = "radFeminino";
            radFeminino.Size = new Size(75, 19);
            radFeminino.TabIndex = 2;
            radFeminino.TabStop = true;
            radFeminino.Tag = "Feminino";
            radFeminino.Text = "Feminino";
            radFeminino.UseVisualStyleBackColor = true;
            radFeminino.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radMasculino
            // 
            radMasculino.AutoSize = true;
            radMasculino.Location = new Point(137, 32);
            radMasculino.Name = "radMasculino";
            radMasculino.Size = new Size(80, 19);
            radMasculino.TabIndex = 1;
            radMasculino.TabStop = true;
            radMasculino.Text = "Masculino";
            radMasculino.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(439, 73);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(9, 204);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(258, 23);
            mskTelefone.TabIndex = 8;
            // 
            // ValidacaoServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 325);
            Controls.Add(pnlSecundario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ValidacaoServidor";
            Text = "ValidacaoServidor";
            Load += Form2_Load;
            pnlSecundario.ResumeLayout(false);
            pnlSecundario.PerformLayout();
            grpCargo.ResumeLayout(false);
            grpCargo.PerformLayout();
            grpSexo.ResumeLayout(false);
            grpSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSecundario;
        private GroupBox grpCargo;
        private GroupBox grpSexo;
        private RadioButton radFeminino;
        private RadioButton radMasculino;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private RadioButton radServidor;
        private RadioButton radCoordenador;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private DateTimePicker dateTimePicker2;
        private Button btnSalavar;
        private MaskedTextBox mskCpf;
        private MaskedTextBox mskTelefone;
    }
}