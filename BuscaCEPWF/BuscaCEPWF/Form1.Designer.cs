
namespace BuscaCEPWF
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
            this.BuscaCep = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtComplemento2 = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.mask = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Municipio = new System.Windows.Forms.Label();
            this.Complemento2 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.Label();
            this.Complemento = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.Logradouro = new System.Windows.Forms.Label();
            this.maskCep = new System.Windows.Forms.Label();
            this.BuscaCep.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuscaCep
            // 
            this.BuscaCep.Controls.Add(this.txtEstado);
            this.BuscaCep.Controls.Add(this.txtBairro);
            this.BuscaCep.Controls.Add(this.txtMunicipio);
            this.BuscaCep.Controls.Add(this.txtComplemento2);
            this.BuscaCep.Controls.Add(this.txtComplemento);
            this.BuscaCep.Controls.Add(this.txtNumero);
            this.BuscaCep.Controls.Add(this.txtLogradouro);
            this.BuscaCep.Controls.Add(this.mask);
            this.BuscaCep.Controls.Add(this.label8);
            this.BuscaCep.Controls.Add(this.Municipio);
            this.BuscaCep.Controls.Add(this.Complemento2);
            this.BuscaCep.Controls.Add(this.Bairro);
            this.BuscaCep.Controls.Add(this.Complemento);
            this.BuscaCep.Controls.Add(this.Numero);
            this.BuscaCep.Controls.Add(this.Logradouro);
            this.BuscaCep.Controls.Add(this.maskCep);
            this.BuscaCep.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuscaCep.ForeColor = System.Drawing.Color.Purple;
            this.BuscaCep.Location = new System.Drawing.Point(12, 12);
            this.BuscaCep.Name = "BuscaCep";
            this.BuscaCep.Size = new System.Drawing.Size(776, 511);
            this.BuscaCep.TabIndex = 0;
            this.BuscaCep.TabStop = false;
            this.BuscaCep.Text = "BuscaCEP - EvolutionSenai";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(483, 277);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(159, 28);
            this.txtEstado.TabIndex = 15;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(483, 84);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(159, 28);
            this.txtBairro.TabIndex = 14;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(483, 210);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(159, 28);
            this.txtMunicipio.TabIndex = 13;
            // 
            // txtComplemento2
            // 
            this.txtComplemento2.Location = new System.Drawing.Point(484, 145);
            this.txtComplemento2.Name = "txtComplemento2";
            this.txtComplemento2.Size = new System.Drawing.Size(158, 28);
            this.txtComplemento2.TabIndex = 12;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(32, 277);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(166, 28);
            this.txtComplemento.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(32, 210);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(166, 28);
            this.txtNumero.TabIndex = 10;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(32, 145);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(166, 28);
            this.txtLogradouro.TabIndex = 9;
            // 
            // mask
            // 
            this.mask.Location = new System.Drawing.Point(32, 84);
            this.mask.Mask = "00000-000";
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(166, 28);
            this.mask.TabIndex = 8;
            this.mask.Leave += new System.EventHandler(this.mask_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "UF";
            // 
            // Municipio
            // 
            this.Municipio.AutoSize = true;
            this.Municipio.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Municipio.Location = new System.Drawing.Point(485, 188);
            this.Municipio.Name = "Municipio";
            this.Municipio.Size = new System.Drawing.Size(84, 23);
            this.Municipio.TabIndex = 6;
            this.Municipio.Text = "Município";
            // 
            // Complemento2
            // 
            this.Complemento2.AutoSize = true;
            this.Complemento2.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Complemento2.Location = new System.Drawing.Point(484, 123);
            this.Complemento2.Name = "Complemento2";
            this.Complemento2.Size = new System.Drawing.Size(125, 23);
            this.Complemento2.TabIndex = 5;
            this.Complemento2.Text = "Complemento 2";
            // 
            // Bairro
            // 
            this.Bairro.AutoSize = true;
            this.Bairro.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bairro.Location = new System.Drawing.Point(485, 62);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(57, 23);
            this.Bairro.TabIndex = 4;
            this.Bairro.Text = "Bairro";
            // 
            // Complemento
            // 
            this.Complemento.AutoSize = true;
            this.Complemento.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Complemento.Location = new System.Drawing.Point(32, 255);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(112, 23);
            this.Complemento.TabIndex = 3;
            this.Complemento.Text = "Complemento";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Numero.ForeColor = System.Drawing.Color.Purple;
            this.Numero.Location = new System.Drawing.Point(32, 188);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(70, 23);
            this.Numero.TabIndex = 2;
            this.Numero.Text = "Número";
            // 
            // Logradouro
            // 
            this.Logradouro.AutoSize = true;
            this.Logradouro.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logradouro.ForeColor = System.Drawing.Color.Purple;
            this.Logradouro.Location = new System.Drawing.Point(32, 123);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(97, 23);
            this.Logradouro.TabIndex = 1;
            this.Logradouro.Text = "Logradouro";
            // 
            // maskCep
            // 
            this.maskCep.AutoSize = true;
            this.maskCep.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskCep.ForeColor = System.Drawing.Color.Purple;
            this.maskCep.Location = new System.Drawing.Point(32, 62);
            this.maskCep.Name = "maskCep";
            this.maskCep.Size = new System.Drawing.Size(40, 23);
            this.maskCep.TabIndex = 0;
            this.maskCep.Text = "CEP";
            this.maskCep.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.BuscaCep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BuscaCep.ResumeLayout(false);
            this.BuscaCep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BuscaCep;
        private System.Windows.Forms.Label Logradouro;
        private System.Windows.Forms.Label maskCep;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtComplemento2;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.MaskedTextBox mask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Municipio;
        private System.Windows.Forms.Label Complemento2;
        private System.Windows.Forms.Label Bairro;
        private System.Windows.Forms.Label Complemento;
        private System.Windows.Forms.Label Numero;
    }
}

