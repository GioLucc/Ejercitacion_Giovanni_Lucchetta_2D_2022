namespace Ejercicio_I01____Hola__Windows_Forms_
{
    partial class FormMensaje
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(58, 127);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(70, 21);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.Location = new System.Drawing.Point(58, 45);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(64, 25);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Titulo";
            // 
            // FormMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 255);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblMensaje);
            this.Name = "FormMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMensaje;
        private Label lblBienvenida;
    }
}