namespace Ejercicio_I02___Registrate
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.radNb = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.chkJavaScript = new System.Windows.Forms.CheckBox();
            this.chkCplusplus = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.lstPaises = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.nudEdad);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblEdad);
            this.gbDatos.Controls.Add(this.lblDireccion);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Location = new System.Drawing.Point(33, 39);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(272, 166);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Detalles del usuario";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(112, 117);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(100, 23);
            this.nudEdad.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(112, 72);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(32, 119);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(32, 72);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.radNb);
            this.gbGenero.Controls.Add(this.radFemale);
            this.gbGenero.Controls.Add(this.radMale);
            this.gbGenero.Location = new System.Drawing.Point(362, 39);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(161, 116);
            this.gbGenero.TabIndex = 1;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // radNb
            // 
            this.radNb.AutoSize = true;
            this.radNb.Location = new System.Drawing.Point(21, 72);
            this.radNb.Name = "radNb";
            this.radNb.Size = new System.Drawing.Size(81, 19);
            this.radNb.TabIndex = 2;
            this.radNb.TabStop = true;
            this.radNb.Text = "No binario";
            this.radNb.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(21, 47);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(78, 19);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Femenino";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(21, 22);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(80, 19);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Masculíno";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.chkJavaScript);
            this.gbCursos.Controls.Add(this.chkCplusplus);
            this.gbCursos.Controls.Add(this.chkCSharp);
            this.gbCursos.Location = new System.Drawing.Point(362, 174);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(161, 114);
            this.gbCursos.TabIndex = 2;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // chkJavaScript
            // 
            this.chkJavaScript.AutoSize = true;
            this.chkJavaScript.Location = new System.Drawing.Point(21, 75);
            this.chkJavaScript.Name = "chkJavaScript";
            this.chkJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chkJavaScript.TabIndex = 2;
            this.chkJavaScript.Text = "JavaScript";
            this.chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkCplusplus
            // 
            this.chkCplusplus.AutoSize = true;
            this.chkCplusplus.Location = new System.Drawing.Point(21, 50);
            this.chkCplusplus.Name = "chkCplusplus";
            this.chkCplusplus.Size = new System.Drawing.Size(50, 19);
            this.chkCplusplus.TabIndex = 1;
            this.chkCplusplus.Text = "C++";
            this.chkCplusplus.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(21, 22);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(41, 19);
            this.chkCSharp.TabIndex = 0;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // lstPaises
            // 
            this.lstPaises.FormattingEnabled = true;
            this.lstPaises.ItemHeight = 15;
            this.lstPaises.Location = new System.Drawing.Point(33, 237);
            this.lstPaises.Name = "lstPaises";
            this.lstPaises.Size = new System.Drawing.Size(256, 94);
            this.lstPaises.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(33, 219);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Location = new System.Drawing.Point(415, 305);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 26);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 353);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lstPaises);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbDatos);
            this.Name = "Form1";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbDatos;
        private GroupBox gbGenero;
        private GroupBox gbCursos;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblDireccion;
        private Label lblNombre;
        private ListBox lstPaises;
        private NumericUpDown nudEdad;
        private RadioButton radNb;
        private RadioButton radFemale;
        private RadioButton radMale;
        private CheckBox chkJavaScript;
        private CheckBox chkCplusplus;
        private CheckBox chkCSharp;
        private Label lblPais;
        private Button btnIngresar;
    }
}