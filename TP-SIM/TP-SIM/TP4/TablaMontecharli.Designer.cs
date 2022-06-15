
namespace TP_SIM.TP4
{
    partial class TablaMontecharli
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
            this.dgv_montecarlo = new System.Windows.Forms.DataGridView();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegada_barcos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcos_descargados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcos_sin_descargar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcos_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_muelle_vacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contador_retraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcos_retrasados_ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_descarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_noche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_muelle_vacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total_ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_por_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_prom_barcos_semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porc_dias_vacios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porc_ocupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_montecarlo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_montecarlo
            // 
            this.dgv_montecarlo.AllowUserToAddRows = false;
            this.dgv_montecarlo.AllowUserToDeleteRows = false;
            this.dgv_montecarlo.AllowUserToResizeRows = false;
            this.dgv_montecarlo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_montecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_montecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.rnd1,
            this.llegada_barcos,
            this.rnd2,
            this.barcos_descargados,
            this.barcos_sin_descargar,
            this.barcos_total,
            this.dias_muelle_vacio,
            this.contador_retraso,
            this.barcos_retrasados_ac,
            this.costo_descarga,
            this.costo_noche,
            this.costo_muelle_vacio,
            this.costo_total,
            this.costo_total_ac,
            this.costo_por_dia,
            this.cant_prom_barcos_semana,
            this.porc_dias_vacios,
            this.porc_ocupacion});
            this.dgv_montecarlo.Location = new System.Drawing.Point(32, 38);
            this.dgv_montecarlo.Name = "dgv_montecarlo";
            this.dgv_montecarlo.ReadOnly = true;
            this.dgv_montecarlo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_montecarlo.Size = new System.Drawing.Size(1193, 510);
            this.dgv_montecarlo.TabIndex = 0;
            this.dgv_montecarlo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_montecarlo_CellContentClick);
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            // 
            // rnd1
            // 
            this.rnd1.HeaderText = "RND1";
            this.rnd1.Name = "rnd1";
            this.rnd1.ReadOnly = true;
            // 
            // llegada_barcos
            // 
            this.llegada_barcos.HeaderText = "Llegada Barcos";
            this.llegada_barcos.Name = "llegada_barcos";
            this.llegada_barcos.ReadOnly = true;
            // 
            // rnd2
            // 
            this.rnd2.HeaderText = "RND2";
            this.rnd2.Name = "rnd2";
            this.rnd2.ReadOnly = true;
            // 
            // barcos_descargados
            // 
            this.barcos_descargados.HeaderText = "Barcos Descargados";
            this.barcos_descargados.Name = "barcos_descargados";
            this.barcos_descargados.ReadOnly = true;
            // 
            // barcos_sin_descargar
            // 
            this.barcos_sin_descargar.HeaderText = "Barcos S/Descargar";
            this.barcos_sin_descargar.Name = "barcos_sin_descargar";
            this.barcos_sin_descargar.ReadOnly = true;
            // 
            // barcos_total
            // 
            this.barcos_total.HeaderText = "Total Barcos";
            this.barcos_total.Name = "barcos_total";
            this.barcos_total.ReadOnly = true;
            // 
            // dias_muelle_vacio
            // 
            this.dias_muelle_vacio.HeaderText = "Contador Muelle Vacio";
            this.dias_muelle_vacio.Name = "dias_muelle_vacio";
            this.dias_muelle_vacio.ReadOnly = true;
            // 
            // contador_retraso
            // 
            this.contador_retraso.HeaderText = "Barcos Retrasados";
            this.contador_retraso.Name = "contador_retraso";
            this.contador_retraso.ReadOnly = true;
            // 
            // barcos_retrasados_ac
            // 
            this.barcos_retrasados_ac.HeaderText = "Barcos Retrasados (AC)";
            this.barcos_retrasados_ac.Name = "barcos_retrasados_ac";
            this.barcos_retrasados_ac.ReadOnly = true;
            // 
            // costo_descarga
            // 
            this.costo_descarga.HeaderText = "Costo Descarga";
            this.costo_descarga.Name = "costo_descarga";
            this.costo_descarga.ReadOnly = true;
            // 
            // costo_noche
            // 
            this.costo_noche.HeaderText = "Costo x Noche";
            this.costo_noche.Name = "costo_noche";
            this.costo_noche.ReadOnly = true;
            // 
            // costo_muelle_vacio
            // 
            this.costo_muelle_vacio.HeaderText = "Costo Muelle Vacio";
            this.costo_muelle_vacio.Name = "costo_muelle_vacio";
            this.costo_muelle_vacio.ReadOnly = true;
            // 
            // costo_total
            // 
            this.costo_total.HeaderText = "Costo Total";
            this.costo_total.Name = "costo_total";
            this.costo_total.ReadOnly = true;
            // 
            // costo_total_ac
            // 
            this.costo_total_ac.HeaderText = "Costo Total (AC)";
            this.costo_total_ac.Name = "costo_total_ac";
            this.costo_total_ac.ReadOnly = true;
            // 
            // costo_por_dia
            // 
            this.costo_por_dia.HeaderText = "Costo Dia Promedio";
            this.costo_por_dia.Name = "costo_por_dia";
            this.costo_por_dia.ReadOnly = true;
            // 
            // cant_prom_barcos_semana
            // 
            this.cant_prom_barcos_semana.HeaderText = "Promedio Barcos/Semana";
            this.cant_prom_barcos_semana.Name = "cant_prom_barcos_semana";
            this.cant_prom_barcos_semana.ReadOnly = true;
            // 
            // porc_dias_vacios
            // 
            this.porc_dias_vacios.HeaderText = "% dias vacio";
            this.porc_dias_vacios.Name = "porc_dias_vacios";
            this.porc_dias_vacios.ReadOnly = true;
            // 
            // porc_ocupacion
            // 
            this.porc_ocupacion.HeaderText = "% de Ocupacion";
            this.porc_ocupacion.Name = "porc_ocupacion";
            this.porc_ocupacion.ReadOnly = true;
            // 
            // TablaMontecharli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 583);
            this.Controls.Add(this.dgv_montecarlo);
            this.Name = "TablaMontecharli";
            this.Text = "TablaMontecharli";
            this.Load += new System.EventHandler(this.TablaMontecharli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_montecarlo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_montecarlo;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegada_barcos;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcos_descargados;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcos_sin_descargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcos_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_muelle_vacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn contador_retraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcos_retrasados_ac;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_descarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_noche;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_muelle_vacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total_ac;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_por_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_prom_barcos_semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn porc_dias_vacios;
        private System.Windows.Forms.DataGridViewTextBoxColumn porc_ocupacion;
    }
}