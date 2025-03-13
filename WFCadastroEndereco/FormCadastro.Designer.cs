namespace WFCadastroEndereco
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            btnSalvar = new Button();
            lblCep = new Label();
            lblLinha = new Label();
            mtbCep = new MaskedTextBox();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            cbxUf = new ComboBox();
            lblBairro = new Label();
            lblUf = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            chkSemNumero = new CheckBox();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(40, 21);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(40, 53);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(461, 23);
            txtNomeCompleto.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(402, 399);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(99, 39);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(40, 104);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 9;
            lblCep.Text = "Cep";
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(48, 85);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(453, 1);
            lblLinha.TabIndex = 11;
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(40, 122);
            mtbCep.Mask = "00000-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(123, 23);
            mtbCep.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(40, 179);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 13;
            lblLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(40, 197);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(194, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(40, 245);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 15;
            lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(40, 263);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(194, 23);
            txtComplemento.TabIndex = 5;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(252, 181);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 17;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(250, 199);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(133, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(320, 263);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(181, 23);
            txtBairro.TabIndex = 6;
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(380, 323);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(121, 23);
            cbxUf.TabIndex = 8;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(320, 245);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 21;
            lblBairro.Text = "Bairro";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(380, 305);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 22;
            lblUf.Text = "UF";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(40, 323);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(263, 23);
            txtCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(40, 305);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 24;
            lblCidade.Text = "Cidade";
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(402, 201);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(104, 19);
            chkSemNumero.TabIndex = 4;
            chkSemNumero.Text = "Sem Numero ?";
            chkSemNumero.UseVisualStyleBackColor = true;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkSemNumero);
            Controls.Add(lblCidade);
            Controls.Add(txtCidade);
            Controls.Add(lblUf);
            Controls.Add(lblBairro);
            Controls.Add(cbxUf);
            Controls.Add(txtBairro);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtLogradouro);
            Controls.Add(lblLogradouro);
            Controls.Add(mtbCep);
            Controls.Add(lblLinha);
            Controls.Add(lblCep);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnSalvar;
        private Label lblCep;
        private Label lblLinha;
        private MaskedTextBox mtbCep;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private ComboBox cbxUf;
        private Label lblBairro;
        private Label lblUf;
        private TextBox txtCidade;
        private Label lblCidade;
        private CheckBox chkSemNumero;
    }
}