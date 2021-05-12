
namespace TAP2021_U1T2_Aplicación_Escolar
{
    partial class FormReticula
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
            this.labelR = new System.Windows.Forms.Label();
            this.tablaR = new System.Windows.Forms.DataGridView();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaR)).BeginInit();
            this.SuspendLayout();
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.ForeColor = System.Drawing.Color.LightGreen;
            this.labelR.Location = new System.Drawing.Point(345, 9);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(137, 26);
            this.labelR.TabIndex = 0;
            this.labelR.Text = "RETÍCULA";
            // 
            // tablaR
            // 
            this.tablaR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semestre,
            this.Asignatura1,
            this.Asignatura2,
            this.Asignatura3,
            this.Asignatura4,
            this.Asignatura5,
            this.Asignatura6});
            this.tablaR.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaR.Location = new System.Drawing.Point(35, 57);
            this.tablaR.Name = "tablaR";
            this.tablaR.Size = new System.Drawing.Size(1085, 654);
            this.tablaR.TabIndex = 1;
            // 
            // Semestre
            // 
            this.Semestre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Semestre.HeaderText = "Semestre ";
            this.Semestre.Name = "Semestre";
            this.Semestre.Width = 79;
            // 
            // Asignatura1
            // 
            this.Asignatura1.HeaderText = "Asignatura1";
            this.Asignatura1.Name = "Asignatura1";
            // 
            // Asignatura2
            // 
            this.Asignatura2.HeaderText = "Asignatura2";
            this.Asignatura2.Name = "Asignatura2";
            // 
            // Asignatura3
            // 
            this.Asignatura3.HeaderText = "Asignatura3";
            this.Asignatura3.Name = "Asignatura3";
            // 
            // Asignatura4
            // 
            this.Asignatura4.HeaderText = "Asignatura4";
            this.Asignatura4.Name = "Asignatura4";
            // 
            // Asignatura5
            // 
            this.Asignatura5.HeaderText = "Asignatura5";
            this.Asignatura5.Name = "Asignatura5";
            // 
            // Asignatura6
            // 
            this.Asignatura6.HeaderText = "Asignatura6";
            this.Asignatura6.Name = "Asignatura6";
            // 
            // FormReticula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1171, 723);
            this.Controls.Add(this.tablaR);
            this.Controls.Add(this.labelR);
            this.Name = "FormReticula";
            this.Text = "FormReticula";
            this.Load += new System.EventHandler(this.FormReticula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.DataGridView tablaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura6;
    }
}