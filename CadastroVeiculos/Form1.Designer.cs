namespace CadastroVeiculos
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
            label7 = new Label();
            txtPlaca = new TextBox();
            txtMarca = new TextBox();
            txtFab = new TextBox();
            txtPfPj = new TextBox();
            txtDoc = new TextBox();
            txtCliente = new TextBox();
            txtModelo = new TextBox();
            btnCadastrar = new Button();
            btnPesquisar = new Button();
            label8 = new Label();
            lblId = new Label();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 0;
            label1.Text = "Placa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(9, 106);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 1;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(9, 141);
            label3.Name = "label3";
            label3.Size = new Size(67, 16);
            label3.TabIndex = 2;
            label3.Text = "Ano_Fab:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(9, 181);
            label4.Name = "label4";
            label4.Size = new Size(82, 16);
            label4.TabIndex = 3;
            label4.Text = "Ano_Model:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(9, 215);
            label5.Name = "label5";
            label5.Size = new Size(56, 16);
            label5.TabIndex = 4;
            label5.Text = "Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label6.Location = new Point(9, 253);
            label6.Name = "label6";
            label6.Size = new Size(71, 16);
            label6.TabIndex = 5;
            label6.Text = "Tipo_Clie:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label7.Location = new Point(12, 292);
            label7.Name = "label7";
            label7.Size = new Size(83, 16);
            label7.TabIndex = 6;
            label7.Text = "Documento:";
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Arial", 12F);
            txtPlaca.Location = new Point(114, 62);
            txtPlaca.MaxLength = 7;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(256, 26);
            txtPlaca.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Arial", 12F);
            txtMarca.Location = new Point(114, 101);
            txtMarca.MaxLength = 20;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(256, 26);
            txtMarca.TabIndex = 2;
            // 
            // txtFab
            // 
            txtFab.Font = new Font("Arial", 12F);
            txtFab.Location = new Point(114, 136);
            txtFab.MaxLength = 4;
            txtFab.Name = "txtFab";
            txtFab.Size = new Size(256, 26);
            txtFab.TabIndex = 3;
            // 
            // txtPfPj
            // 
            txtPfPj.Font = new Font("Arial", 12F);
            txtPfPj.Location = new Point(114, 248);
            txtPfPj.MaxLength = 20;
            txtPfPj.Name = "txtPfPj";
            txtPfPj.Size = new Size(256, 26);
            txtPfPj.TabIndex = 6;
            // 
            // txtDoc
            // 
            txtDoc.Font = new Font("Arial", 12F);
            txtDoc.Location = new Point(114, 287);
            txtDoc.MaxLength = 14;
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(256, 26);
            txtDoc.TabIndex = 7;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Arial", 12F);
            txtCliente.Location = new Point(114, 210);
            txtCliente.MaxLength = 100;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(256, 26);
            txtCliente.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Arial", 12F);
            txtModelo.Location = new Point(114, 171);
            txtModelo.MaxLength = 4;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(256, 26);
            txtModelo.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(68, 367);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 32);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(229, 367);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(118, 32);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 27);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 10;
            label8.Text = "Funcionário Id:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(114, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 11;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(229, 437);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(118, 32);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(391, 367);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(118, 32);
            btnAtualizar.TabIndex = 13;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(431, 181);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(118, 32);
            btnDeletar.TabIndex = 14;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 481);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(lblId);
            Controls.Add(label8);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtModelo);
            Controls.Add(txtCliente);
            Controls.Add(txtDoc);
            Controls.Add(txtPfPj);
            Controls.Add(txtFab);
            Controls.Add(txtMarca);
            Controls.Add(txtPlaca);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroVeiculos";
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
        private Label label7;
        private TextBox txtPlaca;
        private TextBox txtMarca;
        private TextBox txtFab;
        private TextBox txtPfPj;
        private TextBox txtDoc;
        private TextBox txtCliente;
        private TextBox txtModelo;
        private Button btnCadastrar;
        private Button btnPesquisar;
        private Label label8;
        private Label lblId;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}
