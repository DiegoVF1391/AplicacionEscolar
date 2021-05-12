
namespace TAP2021_U1T_Escuela
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.comBoxCarrera = new System.Windows.Forms.ComboBox();
            this.numSemestre = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de Control";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRegistrar.Location = new System.Drawing.Point(148, 520);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 43);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Semestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contraseña";
            // 
            // txtNoControl
            // 
            this.txtNoControl.Location = new System.Drawing.Point(83, 73);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(273, 28);
            this.txtNoControl.TabIndex = 6;
            this.txtNoControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 28);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(169, 384);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(187, 28);
            this.txtContrasena.TabIndex = 10;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comBoxCarrera
            // 
            this.comBoxCarrera.FormattingEnabled = true;
            this.comBoxCarrera.Location = new System.Drawing.Point(148, 231);
            this.comBoxCarrera.Name = "comBoxCarrera";
            this.comBoxCarrera.Size = new System.Drawing.Size(208, 25);
            this.comBoxCarrera.TabIndex = 11;
            this.comBoxCarrera.SelectedIndexChanged += new System.EventHandler(this.comBoxCarrera_SelectedIndexChanged);
            // 
            // numSemestre
            // 
            this.numSemestre.Location = new System.Drawing.Point(163, 290);
            this.numSemestre.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSemestre.Name = "numSemestre";
            this.numSemestre.Size = new System.Drawing.Size(193, 28);
            this.numSemestre.TabIndex = 12;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefono ";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(169, 335);
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '*';
            this.txtTel.Size = new System.Drawing.Size(187, 28);
            this.txtTel.TabIndex = 14;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 573);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numSemestre);
            this.Controls.Add(this.comBoxCarrera);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSemestre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.ComboBox comBoxCarrera;
        private System.Windows.Forms.NumericUpDown numSemestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
    }
}