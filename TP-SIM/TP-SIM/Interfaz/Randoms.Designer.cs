
namespace TP_SIM.Interfaz
{
    partial class TablaRandoms
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
            this.dgv_random = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorIntermedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorXi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorRND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_random)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_random
            // 
            this.dgv_random.AllowUserToAddRows = false;
            this.dgv_random.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_random.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.valorIntermedio,
            this.valorXi,
            this.valorRND});
            this.dgv_random.Location = new System.Drawing.Point(12, 12);
            this.dgv_random.Name = "dgv_random";
            this.dgv_random.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_random.Size = new System.Drawing.Size(462, 291);
            this.dgv_random.TabIndex = 0;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "Iteración";
            this.iteracion.Name = "iteracion";
            // 
            // valorIntermedio
            // 
            this.valorIntermedio.HeaderText = "ai*Xi + C";
            this.valorIntermedio.Name = "valorIntermedio";
            // 
            // valorXi
            // 
            this.valorXi.HeaderText = "Xi+1";
            this.valorXi.Name = "valorXi";
            // 
            // valorRND
            // 
            this.valorRND.HeaderText = "Random";
            this.valorRND.Name = "valorRND";
            // 
            // TablaRandoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 338);
            this.Controls.Add(this.dgv_random);
            this.Name = "TablaRandoms";
            this.Text = "Randoms";
            this.Load += new System.EventHandler(this.Randoms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_random)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_random;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorIntermedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorXi;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorRND;
    }
}