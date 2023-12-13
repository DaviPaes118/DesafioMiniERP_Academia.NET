namespace MiniERP
{
    partial class Form1
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
            label_Titulo = new Label();
            button_cadastroCliente = new Button();
            button_cadastroFornecedor = new Button();
            button_cadastrarProduto = new Button();
            button_emitirNota = new Button();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.Dock = DockStyle.Top;
            label_Titulo.Font = new Font("Cambria", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.ImageAlign = ContentAlignment.TopCenter;
            label_Titulo.Location = new Point(0, 0);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(800, 61);
            label_Titulo.TabIndex = 0;
            label_Titulo.Text = "MINI ERP";
            label_Titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // button_cadastroCliente
            // 
            button_cadastroCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_cadastroCliente.Location = new Point(12, 154);
            button_cadastroCliente.Name = "button_cadastroCliente";
            button_cadastroCliente.Size = new Size(132, 130);
            button_cadastroCliente.TabIndex = 1;
            button_cadastroCliente.Text = "Cadastrar Cliente";
            button_cadastroCliente.UseVisualStyleBackColor = true;
            button_cadastroCliente.Click += button_cadastroCliente_Click;
            // 
            // button_cadastroFornecedor
            // 
            button_cadastroFornecedor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_cadastroFornecedor.Location = new Point(218, 154);
            button_cadastroFornecedor.Name = "button_cadastroFornecedor";
            button_cadastroFornecedor.Size = new Size(135, 130);
            button_cadastroFornecedor.TabIndex = 2;
            button_cadastroFornecedor.Text = "Cadastrar Fornecedor";
            button_cadastroFornecedor.UseVisualStyleBackColor = true;
            button_cadastroFornecedor.Click += button_cadastroFornecedor_Click;
            // 
            // button_cadastrarProduto
            // 
            button_cadastrarProduto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_cadastrarProduto.Location = new Point(432, 154);
            button_cadastrarProduto.Name = "button_cadastrarProduto";
            button_cadastrarProduto.Size = new Size(135, 130);
            button_cadastrarProduto.TabIndex = 3;
            button_cadastrarProduto.Text = "Cadastrar Produto";
            button_cadastrarProduto.UseVisualStyleBackColor = true;
            button_cadastrarProduto.Click += button_cadastrarProduto_Click;
            // 
            // button_emitirNota
            // 
            button_emitirNota.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_emitirNota.Location = new Point(653, 154);
            button_emitirNota.Name = "button_emitirNota";
            button_emitirNota.Size = new Size(135, 130);
            button_emitirNota.TabIndex = 4;
            button_emitirNota.Text = "Emitir Nota";
            button_emitirNota.UseVisualStyleBackColor = true;
            button_emitirNota.Click += button_emitirNota_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 376);
            Controls.Add(button_emitirNota);
            Controls.Add(button_cadastrarProduto);
            Controls.Add(button_cadastroFornecedor);
            Controls.Add(button_cadastroCliente);
            Controls.Add(label_Titulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label_Titulo;
        private Button button_cadastroCliente;
        private Button button_cadastroFornecedor;
        private Button button_cadastrarProduto;
        private Button button_emitirNota;
    }
}