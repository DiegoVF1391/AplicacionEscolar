
namespace TAP2021_U1T2_Aplicación_Escolar
{
    partial class FormHorario
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
            this.tablaH = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHorario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaH)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaH
            // 
            this.tablaH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.tablaH.Location = new System.Drawing.Point(27, 68);
            this.tablaH.Name = "tablaH";
            this.tablaH.Size = new System.Drawing.Size(956, 529);
            this.tablaH.TabIndex = 0;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lunes ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Martes";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Miercoles ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jueves ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Viernes ";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorario.ForeColor = System.Drawing.Color.LightGreen;
            this.labelHorario.Location = new System.Drawing.Point(335, 23);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(83, 25);
            this.labelHorario.TabIndex = 1;
            this.labelHorario.Text = "Horario";
            // 
            // FormHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1019, 640);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.tablaH);
            this.Name = "FormHorario";
            this.Text = "FormHorario";
            this.Load += new System.EventHandler(this.FormHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label labelHorario;
    }
}