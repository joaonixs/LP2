
namespace PAtividade9
{
    partial class frmExercicio3
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
            this.btnResposta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResposta
            // 
            this.btnResposta.Location = new System.Drawing.Point(287, 139);
            this.btnResposta.Name = "btnResposta";
            this.btnResposta.Size = new System.Drawing.Size(156, 76);
            this.btnResposta.TabIndex = 0;
            this.btnResposta.Text = "Resposta";
            this.btnResposta.UseVisualStyleBackColor = true;
            this.btnResposta.Click += new System.EventHandler(this.btnResposta_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResposta);
            this.Name = "frmExercicio3";
            this.Text = "Exercício 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResposta;
    }
}