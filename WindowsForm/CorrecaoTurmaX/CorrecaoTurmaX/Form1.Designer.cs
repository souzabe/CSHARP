namespace CorrecaoTurmaX
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            txtCategoria = new TextBox();
            btnCadastrar = new Button();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 55);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 91);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 124);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 164);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 225);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(159, 268);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(299, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 6;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(299, 91);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(299, 124);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 8;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(299, 164);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(194, 331);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(570, 77);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(196, 163);
            dgvProdutos.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 573);
            Controls.Add(dgvProdutos);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCategoria);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private TextBox txtCategoria;
        private Button btnCadastrar;
        private DataGridView dgvProdutos;
    }
}
