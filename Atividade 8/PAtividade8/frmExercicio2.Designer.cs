
namespace PAtividade8
{
    partial class frmExercicio2
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
            this.lblN = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.txtNumeroH = new System.Windows.Forms.TextBox();
            this.btnCalcularH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblN.Location = new System.Drawing.Point(109, 102);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(22, 21);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "N";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblH.Location = new System.Drawing.Point(109, 148);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(21, 21);
            this.lblH.TabIndex = 1;
            this.lblH.Text = "H";
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroN.Location = new System.Drawing.Point(167, 99);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(136, 29);
            this.txtNumeroN.TabIndex = 2;
            // 
            // txtNumeroH
            // 
            this.txtNumeroH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroH.Location = new System.Drawing.Point(167, 145);
            this.txtNumeroH.Name = "txtNumeroH";
            this.txtNumeroH.ReadOnly = true;
            this.txtNumeroH.Size = new System.Drawing.Size(136, 29);
            this.txtNumeroH.TabIndex = 3;
            // 
            // btnCalcularH
            // 
            this.btnCalcularH.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularH.Location = new System.Drawing.Point(287, 266);
            this.btnCalcularH.Name = "btnCalcularH";
            this.btnCalcularH.Size = new System.Drawing.Size(183, 72);
            this.btnCalcularH.TabIndex = 4;
            this.btnCalcularH.Text = "Calcular H";
            this.btnCalcularH.UseVisualStyleBackColor = true;
            this.btnCalcularH.Click += new System.EventHandler(this.btnCalcularH_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularH);
            this.Controls.Add(this.txtNumeroH);
            this.Controls.Add(this.txtNumeroN);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblN);
            this.Name = "frmExercicio2";
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.TextBox txtNumeroH;
        private System.Windows.Forms.Button btnCalcularH;
    }
}