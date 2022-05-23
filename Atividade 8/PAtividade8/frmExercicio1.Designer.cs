
namespace PAtividade8
{
    partial class frmExercicio1
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
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnQuantidadeR = new System.Windows.Forms.Button();
            this.btnQuatidadePares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtTexto.Location = new System.Drawing.Point(69, 45);
            this.rtxtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtTexto.MaxLength = 100;
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(547, 230);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContar.Location = new System.Drawing.Point(69, 283);
            this.btnContar.Margin = new System.Windows.Forms.Padding(4);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(157, 65);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Contar Espaços em Branco";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnQuantidadeR
            // 
            this.btnQuantidadeR.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuantidadeR.Location = new System.Drawing.Point(264, 283);
            this.btnQuantidadeR.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuantidadeR.Name = "btnQuantidadeR";
            this.btnQuantidadeR.Size = new System.Drawing.Size(157, 65);
            this.btnQuantidadeR.TabIndex = 2;
            this.btnQuantidadeR.Text = "Quantidade de \"R\"";
            this.btnQuantidadeR.UseVisualStyleBackColor = true;
            this.btnQuantidadeR.Click += new System.EventHandler(this.btnQuantidadeR_Click);
            // 
            // btnQuatidadePares
            // 
            this.btnQuatidadePares.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuatidadePares.Location = new System.Drawing.Point(459, 283);
            this.btnQuatidadePares.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuatidadePares.Name = "btnQuatidadePares";
            this.btnQuatidadePares.Size = new System.Drawing.Size(157, 65);
            this.btnQuatidadePares.TabIndex = 3;
            this.btnQuatidadePares.Text = "Quantidade de Pares de Letras";
            this.btnQuatidadePares.UseVisualStyleBackColor = true;
            this.btnQuatidadePares.Click += new System.EventHandler(this.btnQuatidadePares_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 393);
            this.Controls.Add(this.btnQuatidadePares);
            this.Controls.Add(this.btnQuantidadeR);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.rtxtTexto);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExercicio1";
            this.Text = "Exercício 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnQuantidadeR;
        private System.Windows.Forms.Button btnQuatidadePares;
    }
}