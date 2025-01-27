namespace microondas.UI
{
    partial class CadastroProgramaForm
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
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.txtCaractere = new System.Windows.Forms.TextBox();
            this.txtInstrucoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numTempo = new System.Windows.Forms.NumericUpDown();
            this.numPotencia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotencia)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(394, 373);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(114, 23);
            this.botaoSalvar.TabIndex = 0;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(274, 373);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(114, 23);
            this.botaoCancelar.TabIndex = 1;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(274, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(234, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(273, 147);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(234, 20);
            this.txtAlimento.TabIndex = 3;
            // 
            // txtCaractere
            // 
            this.txtCaractere.Location = new System.Drawing.Point(274, 287);
            this.txtCaractere.Name = "txtCaractere";
            this.txtCaractere.Size = new System.Drawing.Size(234, 20);
            this.txtCaractere.TabIndex = 6;
            // 
            // txtInstrucoes
            // 
            this.txtInstrucoes.Location = new System.Drawing.Point(274, 338);
            this.txtInstrucoes.Name = "txtInstrucoes";
            this.txtInstrucoes.Size = new System.Drawing.Size(234, 20);
            this.txtInstrucoes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Potência";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Simbolo(Caracter)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Instruções";
            // 
            // numTempo
            // 
            this.numTempo.Location = new System.Drawing.Point(275, 194);
            this.numTempo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTempo.Name = "numTempo";
            this.numTempo.Size = new System.Drawing.Size(233, 20);
            this.numTempo.TabIndex = 14;
            // 
            // numPotencia
            // 
            this.numPotencia.Location = new System.Drawing.Point(275, 239);
            this.numPotencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPotencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPotencia.Name = "numPotencia";
            this.numPotencia.Size = new System.Drawing.Size(233, 20);
            this.numPotencia.TabIndex = 15;
            this.numPotencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CadastroProgramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numPotencia);
            this.Controls.Add(this.numTempo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstrucoes);
            this.Controls.Add(this.txtCaractere);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoSalvar);
            this.Name = "CadastroProgramaForm";
            this.Text = "CadastroProgramaForm";
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.TextBox txtCaractere;
        private System.Windows.Forms.TextBox txtInstrucoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTempo;
        private System.Windows.Forms.NumericUpDown numPotencia;
    }
}