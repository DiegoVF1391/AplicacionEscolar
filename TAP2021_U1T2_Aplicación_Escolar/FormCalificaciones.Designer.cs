
namespace TAP2021_U1T2_Aplicación_Escolar
{
    partial class FormCalificaciones
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
            this.tablaC = new System.Windows.Forms.DataGridView();
            this.labelCalificaciones = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSemestre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaC)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaC
            // 
            this.tablaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.tablaC.Location = new System.Drawing.Point(21, 96);
            this.tablaC.Name = "tablaC";
            this.tablaC.Size = new System.Drawing.Size(474, 179);
            this.tablaC.TabIndex = 0;
            // 
            // labelCalificaciones
            // 
            this.labelCalificaciones.AutoSize = true;
            this.labelCalificaciones.Location = new System.Drawing.Point(147, 30);
            this.labelCalificaciones.Name = "labelCalificaciones";
            this.labelCalificaciones.Size = new System.Drawing.Size(93, 13);
            this.labelCalificaciones.TabIndex = 1;
            this.labelCalificaciones.Text = "Calificaciones de: ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Materia";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Calificacion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // labelSemestre
            // 
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.Location = new System.Drawing.Point(147, 58);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(73, 13);
            this.labelSemestre.TabIndex = 2;
            this.labelSemestre.Text = "labelSemestre";
            // 
            // FormCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 318);
            this.Controls.Add(this.labelSemestre);
            this.Controls.Add(this.labelCalificaciones);
            this.Controls.Add(this.tablaC);
            this.Name = "FormCalificaciones";
            this.Text = "FormCalificaciones";
            this.Load += new System.EventHandler(this.FormCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaC;
        private System.Windows.Forms.Label labelCalificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label labelSemestre;
    }
}