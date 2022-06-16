
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
            this.cola_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_prox_atk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ataque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_fin_ataque_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_fin_ataque_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_remanente = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cola_llegada,
            this.t_prox_atk,
            this.rnd4,
            this.ataque,
            this.t_fin_ataque_c,
            this.t_fin_ataque_s,
            this.rnd2,
            this.tmantenimiento,
            this.t_remanente});
            this.dgv_colas.Location = new System.Drawing.Point(12, 12);
            this.dgv_colas.Name = "dgv_colas";
            this.dgv_colas.ReadOnly = true;
            this.dgv_colas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_colas.Size = new System.Drawing.Size(1412, 506);
            this.dgv_colas.TabIndex = 0;
            this.dgv_colas.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv_colas_ColumnAdded);
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Width = 56;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Width = 66;
            // 
            // rnd1
            // 
            this.rnd1.HeaderText = "RND";
            this.rnd1.Name = "rnd1";
            this.rnd1.ReadOnly = true;
            this.rnd1.Width = 56;
            // 
            // tllegada
            // 
            this.tllegada.HeaderText = "T llegada";
            this.tllegada.Name = "tllegada";
            this.tllegada.ReadOnly = true;
            this.tllegada.Width = 76;
            // 
            // tproxllegada
            // 
            this.tproxllegada.HeaderText = "T Prox Llegada";
            this.tproxllegada.Name = "tproxllegada";
            this.tproxllegada.ReadOnly = true;
            this.tproxllegada.Width = 96;
            // 
            // cola_llegada
            // 
            this.cola_llegada.HeaderText = "Cola Llegada";
            this.cola_llegada.Name = "cola_llegada";
            this.cola_llegada.ReadOnly = true;
            this.cola_llegada.Width = 87;
            // 
            // t_prox_atk
            // 
            this.t_prox_atk.HeaderText = "T Prox Ataque";
            this.t_prox_atk.Name = "t_prox_atk";
            this.t_prox_atk.ReadOnly = true;
            this.t_prox_atk.Width = 92;
            // 
            // rnd4
            // 
            this.rnd4.HeaderText = "RND";
            this.rnd4.Name = "rnd4";
            this.rnd4.ReadOnly = true;
            this.rnd4.Width = 56;
            // 
            // ataque
            // 
            this.ataque.HeaderText = "Ataque A";
            this.ataque.Name = "ataque";
            this.ataque.ReadOnly = true;
            this.ataque.Width = 70;
            // 
            // t_fin_ataque_c
            // 
            this.t_fin_ataque_c.HeaderText = "T Fin Atk Cliente";
            this.t_fin_ataque_c.Name = "t_fin_ataque_c";
            this.t_fin_ataque_c.ReadOnly = true;
            this.t_fin_ataque_c.Width = 101;
            // 
            // t_fin_ataque_s
            // 
            this.t_fin_ataque_s.HeaderText = "T Fin Atk Servidor";
            this.t_fin_ataque_s.Name = "t_fin_ataque_s";
            this.t_fin_ataque_s.ReadOnly = true;
            this.t_fin_ataque_s.Width = 107;
            // 
            // rnd2
            // 
            this.rnd2.HeaderText = "RND";
            this.rnd2.Name = "rnd2";
            this.rnd2.ReadOnly = true;
            this.rnd2.Width = 56;
            // 
            // tmantenimiento
            // 
            this.tmantenimiento.HeaderText = "T Mantenimiento";
            this.tmantenimiento.Name = "tmantenimiento";
            this.tmantenimiento.ReadOnly = true;
            this.tmantenimiento.Width = 102;
            // 
            // t_remanente
            // 
            this.t_remanente.HeaderText = "Tiempo Restante";
            this.t_remanente.Name = "t_remanente";
            this.t_remanente.ReadOnly = true;
            this.t_remanente.Width = 104;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_prox_atk;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ataque;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_fin_ataque_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_fin_ataque_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_remanente;
    }
}