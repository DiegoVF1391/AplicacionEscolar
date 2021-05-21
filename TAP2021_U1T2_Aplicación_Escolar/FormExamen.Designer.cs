
namespace TAP2021_U1T2_Aplicación_Escolar
{
    partial class FormExamen
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
            this.labelMateria = new System.Windows.Forms.Label();
            this.pregunta1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMateria.Location = new System.Drawing.Point(183, 9);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(201, 24);
            this.labelMateria.TabIndex = 0;
            this.labelMateria.Text = "Nombre de Materia: ";
            // 
            // pregunta1
            // 
            this.pregunta1.AutoSize = true;
            this.pregunta1.Location = new System.Drawing.Point(24, 97);
            this.pregunta1.Name = "pregunta1";
            this.pregunta1.Size = new System.Drawing.Size(62, 13);
            this.pregunta1.TabIndex = 1;
            this.pregunta1.Text = "Pregunta 1:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Seleccionar Respuesta: ";
            // 
            // FormExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 609);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pregunta1);
            this.Controls.Add(this.labelMateria);
            this.Name = "FormExamen";
            this.Text = "FormExamen";
            this.Load += new System.EventHandler(this.FormExamen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label pregunta1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}