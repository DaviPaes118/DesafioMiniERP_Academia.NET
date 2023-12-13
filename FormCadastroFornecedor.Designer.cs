namespace MiniERP
{
    partial class FormCadastroFornecedor
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
            label_Titulo = new Label();
            label_CadastrarFornecedor = new Label();
            listView_FornecedorCadastrado = new ListView();
            label_nomeFornecedor = new Label();
            textBox_nomeFornecedor = new TextBox();
            label_CNPJ = new Label();
            maskedTextBox_CNPJ = new MaskedTextBox();
            button_ConfirmarCadastroFornecedor = new Button();
            Button_LimpaCamposFornecedor = new Button();
            button_CancelaFornecedor = new Button();
            columnHeader_IDFornecedor = new ColumnHeader();
            columnHeader_NomeFornecedor = new ColumnHeader();
            columnHeader_CNPJFornecedor = new ColumnHeader();
            SuspendLayout();
            // 
            // label_Titulo
            // 
            label_Titulo.Dock = DockStyle.Top;
            label_Titulo.Font = new Font("Cambria", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.ImageAlign = ContentAlignment.TopCenter;
            label_Titulo.Location = new Point(0, 0);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(777, 61);
            label_Titulo.TabIndex = 10;
            label_Titulo.Text = "MINI ERP";
            label_Titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_CadastrarFornecedor
            // 
            label_CadastrarFornecedor.AutoSize = true;
            label_CadastrarFornecedor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_CadastrarFornecedor.Location = new Point(251, 61);
            label_CadastrarFornecedor.Name = "label_CadastrarFornecedor";
            label_CadastrarFornecedor.Size = new Size(282, 30);
            label_CadastrarFornecedor.TabIndex = 11;
            label_CadastrarFornecedor.Text = "CADASTRAR FORNECEDOR\r\n";
            // 
            // listView_FornecedorCadastrado
            // 
            listView_FornecedorCadastrado.BackColor = SystemColors.ControlLightLight;
            listView_FornecedorCadastrado.Columns.AddRange(new ColumnHeader[] { columnHeader_IDFornecedor, columnHeader_NomeFornecedor, columnHeader_CNPJFornecedor });
            listView_FornecedorCadastrado.LabelWrap = false;
            listView_FornecedorCadastrado.Location = new Point(406, 137);
            listView_FornecedorCadastrado.Name = "listView_FornecedorCadastrado";
            listView_FornecedorCadastrado.Size = new Size(359, 301);
            listView_FornecedorCadastrado.TabIndex = 13;
            listView_FornecedorCadastrado.UseCompatibleStateImageBehavior = false;
            listView_FornecedorCadastrado.View = View.Details;
            // 
            // label_nomeFornecedor
            // 
            label_nomeFornecedor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_nomeFornecedor.Location = new Point(12, 137);
            label_nomeFornecedor.Name = "label_nomeFornecedor";
            label_nomeFornecedor.Size = new Size(71, 23);
            label_nomeFornecedor.TabIndex = 14;
            label_nomeFornecedor.Text = "Nome:";
            // 
            // textBox_nomeFornecedor
            // 
            textBox_nomeFornecedor.Location = new Point(89, 139);
            textBox_nomeFornecedor.Name = "textBox_nomeFornecedor";
            textBox_nomeFornecedor.Size = new Size(286, 23);
            textBox_nomeFornecedor.TabIndex = 15;
            textBox_nomeFornecedor.KeyPress += textBox_nomeFornecedor_KeyPress;
            // 
            // label_CNPJ
            // 
            label_CNPJ.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_CNPJ.Location = new Point(12, 240);
            label_CNPJ.Name = "label_CNPJ";
            label_CNPJ.Size = new Size(50, 23);
            label_CNPJ.TabIndex = 16;
            label_CNPJ.Text = "CNPJ: ";
            // 
            // maskedTextBox_CNPJ
            // 
            maskedTextBox_CNPJ.BeepOnError = true;
            maskedTextBox_CNPJ.BorderStyle = BorderStyle.None;
            maskedTextBox_CNPJ.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            maskedTextBox_CNPJ.Location = new Point(89, 243);
            maskedTextBox_CNPJ.Mask = "00,000,000/0000-00";
            maskedTextBox_CNPJ.Name = "maskedTextBox_CNPJ";
            maskedTextBox_CNPJ.Size = new Size(286, 18);
            maskedTextBox_CNPJ.TabIndex = 17;
            maskedTextBox_CNPJ.KeyPress += maskedTextBox_CNPJ_KeyPress;
            // 
            // button_ConfirmarCadastroFornecedor
            // 
            button_ConfirmarCadastroFornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_ConfirmarCadastroFornecedor.Location = new Point(89, 328);
            button_ConfirmarCadastroFornecedor.Name = "button_ConfirmarCadastroFornecedor";
            button_ConfirmarCadastroFornecedor.Size = new Size(97, 26);
            button_ConfirmarCadastroFornecedor.TabIndex = 18;
            button_ConfirmarCadastroFornecedor.Text = "CADASTRAR";
            button_ConfirmarCadastroFornecedor.UseVisualStyleBackColor = true;
            button_ConfirmarCadastroFornecedor.Click += button_ConfirmarCadastroFornecedor_Click;
            // 
            // Button_LimpaCamposFornecedor
            // 
            Button_LimpaCamposFornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_LimpaCamposFornecedor.Location = new Point(202, 328);
            Button_LimpaCamposFornecedor.Name = "Button_LimpaCamposFornecedor";
            Button_LimpaCamposFornecedor.Size = new Size(72, 26);
            Button_LimpaCamposFornecedor.TabIndex = 19;
            Button_LimpaCamposFornecedor.Text = "LIMPAR";
            Button_LimpaCamposFornecedor.UseVisualStyleBackColor = true;
            Button_LimpaCamposFornecedor.Click += Button_LimpaCamposFornecedor_Click;
            // 
            // button_CancelaFornecedor
            // 
            button_CancelaFornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_CancelaFornecedor.Location = new Point(293, 328);
            button_CancelaFornecedor.Name = "button_CancelaFornecedor";
            button_CancelaFornecedor.Size = new Size(82, 26);
            button_CancelaFornecedor.TabIndex = 20;
            button_CancelaFornecedor.Text = "CANCELAR";
            button_CancelaFornecedor.UseVisualStyleBackColor = true;
            button_CancelaFornecedor.Click += button_CancelaFornecedor_Click;
            // 
            // columnHeader_IDFornecedor
            // 
            columnHeader_IDFornecedor.Text = "ID";
            columnHeader_IDFornecedor.Width = 50;
            // 
            // columnHeader_NomeFornecedor
            // 
            columnHeader_NomeFornecedor.Text = "Nome";
            columnHeader_NomeFornecedor.Width = 150;
            // 
            // columnHeader_CNPJFornecedor
            // 
            columnHeader_CNPJFornecedor.Text = "CNPJ";
            columnHeader_CNPJFornecedor.Width = 150;
            // 
            // FormCadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(button_CancelaFornecedor);
            Controls.Add(Button_LimpaCamposFornecedor);
            Controls.Add(button_ConfirmarCadastroFornecedor);
            Controls.Add(maskedTextBox_CNPJ);
            Controls.Add(label_CNPJ);
            Controls.Add(textBox_nomeFornecedor);
            Controls.Add(label_nomeFornecedor);
            Controls.Add(listView_FornecedorCadastrado);
            Controls.Add(label_CadastrarFornecedor);
            Controls.Add(label_Titulo);
            Name = "FormCadastroFornecedor";
            Text = "WF_CadastroFornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Titulo;
        private Label label_CadastrarFornecedor;
        protected ListView listView_FornecedorCadastrado;
        private Label label_nomeFornecedor;
        private TextBox textBox_nomeFornecedor;
        private Label label_CNPJ;
        private MaskedTextBox maskedTextBox_CNPJ;
        private Button button_ConfirmarCadastroFornecedor;
        private Button Button_LimpaCamposFornecedor;
        private Button button_CancelaFornecedor;
        private ColumnHeader columnHeader_IDFornecedor;
        private ColumnHeader columnHeader_NomeFornecedor;
        private ColumnHeader columnHeader_CNPJFornecedor;
    }
}