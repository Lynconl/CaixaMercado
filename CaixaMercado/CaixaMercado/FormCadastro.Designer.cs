namespace CaixaMercado
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBxNomeProduto = new System.Windows.Forms.TextBox();
            this.txtBxCodigoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.bttnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtBxNomeProduto
            // 
            this.txtBxNomeProduto.Location = new System.Drawing.Point(63, 12);
            this.txtBxNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxNomeProduto.Name = "txtBxNomeProduto";
            this.txtBxNomeProduto.Size = new System.Drawing.Size(184, 20);
            this.txtBxNomeProduto.TabIndex = 0;
            this.txtBxNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxCodigoProduto
            // 
            this.txtBxCodigoProduto.Location = new System.Drawing.Point(63, 41);
            this.txtBxCodigoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxCodigoProduto.Name = "txtBxCodigoProduto";
            this.txtBxCodigoProduto.ReadOnly = true;
            this.txtBxCodigoProduto.Size = new System.Drawing.Size(184, 20);
            this.txtBxCodigoProduto.TabIndex = 3;
            this.txtBxCodigoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // txtBxValor
            // 
            this.txtBxValor.Location = new System.Drawing.Point(63, 70);
            this.txtBxValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxValor.Name = "txtBxValor";
            this.txtBxValor.Size = new System.Drawing.Size(184, 20);
            this.txtBxValor.TabIndex = 1;
            this.txtBxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor:";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(10, 98);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(0, 13);
            this.lblPosicao.TabIndex = 6;
            // 
            // bttnCadastrar
            // 
            this.bttnCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnCadastrar.Location = new System.Drawing.Point(30, 110);
            this.bttnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCadastrar.Name = "bttnCadastrar";
            this.bttnCadastrar.Size = new System.Drawing.Size(203, 24);
            this.bttnCadastrar.TabIndex = 2;
            this.bttnCadastrar.Text = "Cadastrar";
            this.bttnCadastrar.UseVisualStyleBackColor = false;
            this.bttnCadastrar.Click += new System.EventHandler(this.bttnCadastrar_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(258, 145);
            this.Controls.Add(this.bttnCadastrar);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.txtBxValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxCodigoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxNomeProduto);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBxNomeProduto;
        private System.Windows.Forms.TextBox txtBxCodigoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Button bttnCadastrar;
    }
}