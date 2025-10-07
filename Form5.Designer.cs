namespace SistemaProtoGuiA
{
    partial class Form5
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
            btnTransferir = new Button();
            lstAlfabeto2 = new ListBox();
            lstAlfabeto = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnTransferir);
            panel1.Controls.Add(lstAlfabeto2);
            panel1.Controls.Add(lstAlfabeto);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 280);
            panel1.TabIndex = 0;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(331, 231);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(81, 36);
            btnTransferir.TabIndex = 2;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferirLetras;
            // 
            // lstAlfabeto2
            // 
            lstAlfabeto2.FormattingEnabled = true;
            lstAlfabeto2.ItemHeight = 15;
            lstAlfabeto2.Items.AddRange(new object[] { "F", "G", "H" });
            lstAlfabeto2.Location = new Point(260, 34);
            lstAlfabeto2.Name = "lstAlfabeto2";
            lstAlfabeto2.SelectionMode = SelectionMode.MultiExtended;
            lstAlfabeto2.Size = new Size(152, 154);
            lstAlfabeto2.TabIndex = 1;
            // 
            // lstAlfabeto
            // 
            lstAlfabeto.FormattingEnabled = true;
            lstAlfabeto.ItemHeight = 15;
            lstAlfabeto.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F" });
            lstAlfabeto.Location = new Point(34, 34);
            lstAlfabeto.Name = "lstAlfabeto";
            lstAlfabeto.SelectionMode = SelectionMode.MultiExtended;
            lstAlfabeto.Size = new Size(152, 154);
            lstAlfabeto.TabIndex = 0;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 304);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lstAlfabeto2;
        private ListBox lstAlfabeto;
        private Button btnTransferir;
    }
}