namespace MiniERP
{
    partial class FormCadastroCliente
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
            label_nomeCliente = new Label();
            textBox_nomeCliente = new TextBox();
            label_CPF = new Label();
            maskedTextBox_CPF = new MaskedTextBox();
            button_ConfirmarCadastro = new Button();
            Button_LimpaCampos = new Button();
            button_CancelaCliente = new Button();
            label_Titulo = new Label();
            label1 = new Label();
            listView_Cadastrados = new ListView();
            columnHeader_Id = new ColumnHeader();
            columnHeader_Nome = new ColumnHeader();
            columnHeader_CPF = new ColumnHeader();
            SuspendLayout();
            // 
            // label_nomeCliente
            // 
            label_nomeCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_nomeCliente.Location = new Point(12, 145);
            label_nomeCliente.Name = "label_nomeCliente";
            label_nomeCliente.Size = new Size(71, 23);
            label_nomeCliente.TabIndex = 0;
            label_nomeCliente.Text = "Nome:";
            // 
            // textBox_nomeCliente
            // 
            textBox_nomeCliente.Location = new Point(89, 145);
            textBox_nomeCliente.Name = "textBox_nomeCliente";
            textBox_nomeCliente.Size = new Size(286, 23);
            textBox_nomeCliente.TabIndex = 1;
            textBox_nomeCliente.KeyPress += textBox_nomeCliente_KeyPress;
            // 
            // label_CPF
            // 
            label_CPF.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_CPF.Location = new Point(12, 205);
            label_CPF.Name = "label_CPF";
            label_CPF.Size = new Size(50, 23);
            label_CPF.TabIndex = 2;
            label_CPF.Text = "CPF: ";
            // 
            // maskedTextBox_CPF
            // 
            maskedTextBox_CPF.BeepOnError = true;
            maskedTextBox_CPF.BorderStyle = BorderStyle.None;
            maskedTextBox_CPF.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            maskedTextBox_CPF.Location = new Point(89, 208);
            maskedTextBox_CPF.Mask = "000,000,000-00";
            maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            maskedTextBox_CPF.Size = new Size(286, 18);
            maskedTextBox_CPF.TabIndex = 3;
            maskedTextBox_CPF.KeyPress += maskedTextBox_CPF_KeyPress;
            // 
            // button_ConfirmarCadastro
            // 
            button_ConfirmarCadastro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_ConfirmarCadastro.Location = new Point(89, 285);
            button_ConfirmarCadastro.Name = "button_ConfirmarCadastro";
            button_ConfirmarCadastro.Size = new Size(97, 26);
            button_ConfirmarCadastro.TabIndex = 6;
            button_ConfirmarCadastro.Text = "CADASTRAR";
            button_ConfirmarCadastro.UseVisualStyleBackColor = true;
            button_ConfirmarCadastro.Click += button_ConfirmarCadastro_Click;
            // 
            // Button_LimpaCampos
            // 
            Button_LimpaCampos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_LimpaCampos.Location = new Point(202, 285);
            Button_LimpaCampos.Name = "Button_LimpaCampos";
            Button_LimpaCampos.Size = new Size(72, 26);
            Button_LimpaCampos.TabIndex = 7;
            Button_LimpaCampos.Text = "LIMPAR";
            Button_LimpaCampos.UseVisualStyleBackColor = true;
            Button_LimpaCampos.Click += Button_LimpaCampos_Click;
            // 
            // button_CancelaCliente
            // 
            button_CancelaCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_CancelaCliente.Location = new Point(293, 285);
            button_CancelaCliente.Name = "button_CancelaCliente";
            button_CancelaCliente.Size = new Size(82, 26);
            button_CancelaCliente.TabIndex = 8;
            button_CancelaCliente.Text = "CANCELAR";
            button_CancelaCliente.UseVisualStyleBackColor = true;
            button_CancelaCliente.Click += button_CancelaCliente_Click;
            // 
            // label_Titulo
            // 
            label_Titulo.Dock = DockStyle.Top;
            label_Titulo.Font = new Font("Cambria", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Titulo.ImageAlign = ContentAlignment.TopCenter;
            label_Titulo.Location = new Point(0, 0);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(790, 61);
            label_Titulo.TabIndex = 9;
            label_Titulo.Text = "MINI ERP";
            label_Titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(275, 61);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 10;
            label1.Text = "CADASTRAR CLIENTE";
            // 
            // listView_Cadastrados
            // 
            listView_Cadastrados.Columns.AddRange(new ColumnHeader[] { columnHeader_Id, columnHeader_Nome, columnHeader_CPF });
            listView_Cadastrados.FullRowSelect = true;
            listView_Cadastrados.Location = new Point(410, 145);
            listView_Cadastrados.MultiSelect = false;
            listView_Cadastrados.Name = "listView_Cadastrados";
            listView_Cadastrados.Size = new Size(368, 293);
            listView_Cadastrados.TabIndex = 11;
            listView_Cadastrados.UseCompatibleStateImageBehavior = false;
            listView_Cadastrados.View = View.Details;
            // 
            // columnHeader_Id
            // 
            columnHeader_Id.Text = "ID";
            // 
            // columnHeader_Nome
            // 
            columnHeader_Nome.Text = "Nome";
            columnHeader_Nome.Width = 150;
            // 
            // columnHeader_CPF
            // 
            columnHeader_CPF.Text = "CPF";
            columnHeader_CPF.Width = 150;
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(listView_Cadastrados);
            Controls.Add(label1);
            Controls.Add(label_Titulo);
            Controls.Add(button_CancelaCliente);
            Controls.Add(Button_LimpaCampos);
            Controls.Add(button_ConfirmarCadastro);
            Controls.Add(maskedTextBox_CPF);
            Controls.Add(label_CPF);
            Controls.Add(textBox_nomeCliente);
            Controls.Add(label_nomeCliente);
            Name = "FormCadastroCliente";
            Text = "FormCadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nomeCliente;
        private TextBox textBox_nomeCliente;
        private Label label_CPF;
        private MaskedTextBox maskedTextBox_CPF;
        private Button button_ConfirmarCadastro;
        private Button Button_LimpaCampos;
        private Button button_CancelaCliente;
        private Label label_Titulo;
        private Label label1;
        private ListView listView_Cadastrados;
        private ColumnHeader columnHeader_Id;
        private ColumnHeader columnHeader_Nome;
        private ColumnHeader columnHeader_CPF;
    }
}