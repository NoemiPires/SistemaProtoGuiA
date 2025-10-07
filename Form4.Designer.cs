namespace SistemaProtoGuiA
{
    partial class Form4
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
            pnlProdutos = new Panel();
            lstProduto = new ListBox();
            cboProduto = new ComboBox();
            btnExibir_Click = new Button();
            pnlProdutos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlProdutos
            // 
            pnlProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProdutos.Controls.Add(btnExibir_Click);
            pnlProdutos.Controls.Add(lstProduto);
            pnlProdutos.Controls.Add(cboProduto);
            pnlProdutos.Location = new Point(12, 12);
            pnlProdutos.Name = "pnlProdutos";
            pnlProdutos.Size = new Size(447, 286);
            pnlProdutos.TabIndex = 0;
            // 
            // lstProduto
            // 
            lstProduto.FormattingEnabled = true;
            lstProduto.ItemHeight = 15;
            lstProduto.Location = new Point(12, 57);
            lstProduto.Name = "lstProduto";
            lstProduto.Size = new Size(410, 94);
            lstProduto.TabIndex = 1;
            // 
            // cboProduto
            // 
            cboProduto.FormattingEnabled = true;
            cboProduto.Location = new Point(12, 15);
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(410, 23);
            cboProduto.TabIndex = 0;
            // 
            // btnExibir_Click
            // 
            btnExibir_Click.Location = new Point(284, 216);
            btnExibir_Click.Name = "btnExibir_Click";
            btnExibir_Click.Size = new Size(141, 60);
            btnExibir_Click.TabIndex = 2;
            btnExibir_Click.Text = "Exibir";
            btnExibir_Click.UseVisualStyleBackColor = true;
            btnExibir_Click.Click += this.BtnExibir_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 310);
            Controls.Add(pnlProdutos);
            Name = "Form4";
            Text = "Form4";
            pnlProdutos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProdutos;
        private ComboBox cboProduto;
        private ListBox lstProduto;
        private Button btnExibir_Click;
    }
}