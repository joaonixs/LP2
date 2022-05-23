
namespace PAtividade8
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
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTexto1.Location = new System.Drawing.Point(138, 133);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(58, 21);
            this.lblTexto1.TabIndex = 0;
            this.lblTexto1.Text = "Texto 1";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTexto2.Location = new System.Drawing.Point(138, 219);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(58, 21);
            this.lblTexto2.TabIndex = 1;
            this.lblTexto2.Text = "Texto 2";
            // 
            // txtTexto1
            // 
            this.txtTexto1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTexto1.Location = new System.Drawing.Point(196, 130);
            this.txtTexto1.MaxLength = 50;
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(413, 29);
            this.txtTexto1.TabIndex = 2;
            // 
            // txtTexto2
            // 
            this.txtTexto2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTexto2.Location = new System.Drawing.Point(196, 216);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.ReadOnly = true;
            this.txtTexto2.Size = new System.Drawing.Size(413, 29);
            this.txtTexto2.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.Location = new System.Drawing.Point(305, 309);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(165, 47);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtTexto2);
            this.Controls.Add(this.txtTexto1);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.lblTexto1);
            this.Name = "frmExercicio3";
            this.Text = "Exercício 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.TextBox txtTexto1;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.Button btnVerificar;
    }
}