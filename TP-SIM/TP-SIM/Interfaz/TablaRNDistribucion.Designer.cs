
namespace TP_SIM.Interfaz
{
    partial class TablaRNDistribucion
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
            this.dgv_rnd_distribucion = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_histograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rnd_distribucion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_rnd_distribucion
            // 
            this.dgv_rnd_distribucion.AllowUserToAddRows = false;
            this.dgv_rnd_distribucion.AllowUserToResizeRows = false;
            this.dgv_rnd_distribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rnd_distribucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.valor});
            this.dgv_rnd_distribucion.Location = new System.Drawing.Point(40, 25);
            this.dgv_rnd_distribucion.Name = "dgv_rnd_distribucion";
            this.dgv_rnd_distribucion.Size = new System.Drawing.Size(311, 441);
            this.dgv_rnd_distribucion.TabIndex = 0;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "iteracion";
            this.iteracion.Name = "iteracion";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // btn_histograma
            // 
            this.btn_histograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_histograma.Location = new System.Drawing.Point(40, 490);
            this.btn_histograma.Name = "btn_histograma";
            this.btn_histograma.Size = new System.Drawing.Size(311, 42);
            this.btn_histograma.TabIndex = 1;
            this.btn_histograma.Text = "Histograma";
            this.btn_histograma.UseVisualStyleBackColor = true;
            this.btn_histograma.Click += new System.EventHandler(this.btn_histograma_Click);
            // 
            // TablaRNDistribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 560);
            this.Controls.Add(this.btn_histograma);
            this.Controls.Add(this.dgv_rnd_distribucion);
            this.Name = "TablaRNDistribucion";
            this.Text = "TablaRNDistribucion";
            this.Load += new System.EventHandler(this.TablaRNDistribucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rnd_distribucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rnd_distribucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.Button btn_histograma;
    }
}