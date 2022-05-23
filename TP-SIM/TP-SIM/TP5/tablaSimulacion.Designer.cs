
namespace TP_SIM.TP5
{
    partial class tablaSimulacion
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
            this.dgv_colas = new System.Windows.Forms.DataGridView();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tllegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tproxllegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_colas
            // 
            this.dgv_colas.AllowUserToAddRows = false;
            this.dgv_colas.AllowUserToDeleteRows = false;
            this.dgv_colas.AllowUserToResizeRows = false;
            this.dgv_colas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_colas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_colas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.evento,
            this.rnd1,
            this.tllegada,
            this.tproxllegada,
            this.rnd2,
            this.tmantenimiento});
            this.dgv_colas.Location = new System.Drawing.Point(12, 12);
            this.dgv_colas.Name = "dgv_colas";
            this.dgv_colas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_colas.Size = new System.Drawing.Size(1412, 506);
            this.dgv_colas.TabIndex = 0;
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.Width = 56;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.Width = 66;
            // 
            // rnd1
            // 
            this.rnd1.HeaderText = "RND";
            this.rnd1.Name = "rnd1";
            this.rnd1.Width = 56;
            // 
            // tllegada
            // 
            this.tllegada.HeaderText = "T llegada";
            this.tllegada.Name = "tllegada";
            this.tllegada.Width = 76;
            // 
            // tproxllegada
            // 
            this.tproxllegada.HeaderText = "T Prox Llegada";
            this.tproxllegada.Name = "tproxllegada";
            this.tproxllegada.Width = 104;
            // 
            // rnd2
            // 
            this.rnd2.HeaderText = "RND";
            this.rnd2.Name = "rnd2";
            this.rnd2.Width = 56;
            // 
            // tmantenimiento
            // 
            this.tmantenimiento.HeaderText = "T Mantenimiento";
            this.tmantenimiento.Name = "tmantenimiento";
            this.tmantenimiento.Width = 111;
            // 
            // tablaSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 530);
            this.Controls.Add(this.dgv_colas);
            this.Name = "tablaSimulacion";
            this.Text = "tablaSimulacion";
            this.Load += new System.EventHandler(this.tablaSimulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_colas;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tllegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tproxllegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmantenimiento;
    }
}