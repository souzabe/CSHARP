namespace WinFormsApp1
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
            btnCadastrar = new Button();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtRM = new TextBox();
            lblCodigo = new Label();
            lblNome = new Label();
            lblRM = new Label();
            dgvAluno = new DataGridView();
            lblCEP = new Label();
            txtCEP = new TextBox();
            lblRua = new Label();
            txtRua = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAluno).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(212, 270);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(254, 62);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(254, 91);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // txtRM
            // 
            txtRM.Location = new Point(254, 120);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(100, 23);
            txtRM.TabIndex = 3;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(150, 70);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(98, 15);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Código do Aluno";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(150, 99);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(150, 128);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(25, 15);
            lblRM.TabIndex = 6;
            lblRM.Text = "RM";
            // 
            // dgvAluno
            // 
            dgvAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAluno.Location = new Point(124, 299);
            dgvAluno.Name = "dgvAluno";
            dgvAluno.Size = new Size(240, 150);
            dgvAluno.TabIndex = 7;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(150, 159);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(28, 15);
            lblCEP.TabIndex = 8;
            lblCEP.Text = "CEP";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(254, 151);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 9;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(150, 188);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(27, 15);
            lblRua.TabIndex = 10;
            lblRua.Text = "Rua";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(254, 180);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(100, 23);
            txtRua.TabIndex = 11;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(150, 218);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 12;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(254, 210);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(395, 151);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtRua);
            Controls.Add(lblRua);
            Controls.Add(txtCEP);
            Controls.Add(lblCEP);
            Controls.Add(dgvAluno);
            Controls.Add(lblRM);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Controls.Add(txtRM);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(btnCadastrar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtRM;
        private Label lblCodigo;
        private Label lblNome;
        private Label lblRM;
        private DataGridView dgvAluno;
        private Label lblCEP;
        private TextBox txtCEP;
        private Label lblRua;
        private TextBox txtRua;
        private Label lblBairro;
        private TextBox txtBairro;
        private Button btnBuscar;
    }
}
