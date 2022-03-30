
namespace TP_SIM.Interfaz
{
    partial class Histograma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv_histograma = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fesperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fobservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frelativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_media = new System.Windows.Forms.Label();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.lbl_varianza = new System.Windows.Forms.Label();
            this.txt_varianza = new System.Windows.Forms.TextBox();
            this.ch_frecuenciaEsperada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_desviacion = new System.Windows.Forms.TextBox();
            this.btn_chi_cuadrado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_histograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_histograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_frecuenciaEsperada)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_histograma
            // 
            this.dgv_histograma.AllowUserToAddRows = false;
            this.dgv_histograma.AllowUserToResizeRows = false;
            this.dgv_histograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_histograma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.marcaClase,
            this.fesperada,
            this.fobservada,
            this.frelativa,
            this.facumulada});
            this.dgv_histograma.Location = new System.Drawing.Point(12, 28);
            this.dgv_histograma.Name = "dgv_histograma";
            this.dgv_histograma.Size = new System.Drawing.Size(644, 461);
            this.dgv_histograma.TabIndex = 0;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.Name = "intervalo";
            // 
            // marcaClase
            // 
            this.marcaClase.HeaderText = "Marca de Clase";
            this.marcaClase.Name = "marcaClase";
            // 
            // fesperada
            // 
            this.fesperada.HeaderText = "Frecuencia Esperada";
            this.fesperada.Name = "fesperada";
            // 
            // fobservada
            // 
            this.fobservada.HeaderText = "Frecuencia Observada";
            this.fobservada.Name = "fobservada";
            // 
            // frelativa
            // 
            this.frelativa.HeaderText = "Frecuencia Relativa";
            this.frelativa.Name = "frelativa";
            // 
            // facumulada
            // 
            this.facumulada.HeaderText = "Frecuencia Acumulada";
            this.facumulada.Name = "facumulada";
            // 
            // ch_histograma
            // 
            chartArea3.BorderWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.ch_histograma.ChartAreas.Add(chartArea3);
            this.ch_histograma.Location = new System.Drawing.Point(690, 106);
            this.ch_histograma.Name = "ch_histograma";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Randoms";
            this.ch_histograma.Series.Add(series3);
            this.ch_histograma.Size = new System.Drawing.Size(404, 358);
            this.ch_histograma.TabIndex = 1;
            this.ch_histograma.Text = "chart1";
            this.ch_histograma.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_media.Location = new System.Drawing.Point(12, 516);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(71, 25);
            this.lbl_media.TabIndex = 2;
            this.lbl_media.Text = "Media";
            // 
            // txt_media
            // 
            this.txt_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_media.Location = new System.Drawing.Point(94, 510);
            this.txt_media.Name = "txt_media";
            this.txt_media.ReadOnly = true;
            this.txt_media.Size = new System.Drawing.Size(222, 31);
            this.txt_media.TabIndex = 3;
            // 
            // lbl_varianza
            // 
            this.lbl_varianza.AutoSize = true;
            this.lbl_varianza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_varianza.Location = new System.Drawing.Point(338, 513);
            this.lbl_varianza.Name = "lbl_varianza";
            this.lbl_varianza.Size = new System.Drawing.Size(97, 25);
            this.lbl_varianza.TabIndex = 4;
            this.lbl_varianza.Text = "Varianza";
            this.lbl_varianza.Click += new System.EventHandler(this.lbl_varianza_Click);
            // 
            // txt_varianza
            // 
            this.txt_varianza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_varianza.Location = new System.Drawing.Point(441, 510);
            this.txt_varianza.Name = "txt_varianza";
            this.txt_varianza.ReadOnly = true;
            this.txt_varianza.Size = new System.Drawing.Size(215, 31);
            this.txt_varianza.TabIndex = 5;
            // 
            // ch_frecuenciaEsperada
            // 
            chartArea4.BorderWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.ch_frecuenciaEsperada.ChartAreas.Add(chartArea4);
            this.ch_frecuenciaEsperada.Location = new System.Drawing.Point(1123, 106);
            this.ch_frecuenciaEsperada.Name = "ch_frecuenciaEsperada";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Randoms";
            this.ch_frecuenciaEsperada.Series.Add(series4);
            this.ch_frecuenciaEsperada.Size = new System.Drawing.Size(404, 358);
            this.ch_frecuenciaEsperada.TabIndex = 6;
            this.ch_frecuenciaEsperada.Text = "ch_frecuenciaEsperada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1215, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Frecuencias Esperadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(769, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Frecuencias Observadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desviación Estandar";
            // 
            // txt_desviacion
            // 
            this.txt_desviacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desviacion.Location = new System.Drawing.Point(239, 558);
            this.txt_desviacion.Name = "txt_desviacion";
            this.txt_desviacion.ReadOnly = true;
            this.txt_desviacion.Size = new System.Drawing.Size(215, 31);
            this.txt_desviacion.TabIndex = 10;
            // 
            // btn_chi_cuadrado
            // 
            this.btn_chi_cuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chi_cuadrado.Location = new System.Drawing.Point(822, 506);
            this.btn_chi_cuadrado.Name = "btn_chi_cuadrado";
            this.btn_chi_cuadrado.Size = new System.Drawing.Size(160, 77);
            this.btn_chi_cuadrado.TabIndex = 11;
            this.btn_chi_cuadrado.Text = "Test de Chi Cuadrado";
            this.btn_chi_cuadrado.UseVisualStyleBackColor = true;
            this.btn_chi_cuadrado.Click += new System.EventHandler(this.btn_chi_cuadrado_Click);
            // 
            // Histograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 605);
            this.Controls.Add(this.btn_chi_cuadrado);
            this.Controls.Add(this.txt_desviacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_frecuenciaEsperada);
            this.Controls.Add(this.txt_varianza);
            this.Controls.Add(this.lbl_varianza);
            this.Controls.Add(this.txt_media);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.ch_histograma);
            this.Controls.Add(this.dgv_histograma);
            this.Name = "Histograma";
            this.Text = "Histograma";
            this.Load += new System.EventHandler(this.Histograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_histograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_histograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_frecuenciaEsperada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_histograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn fesperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fobservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn frelativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn facumulada;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_histograma;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.Label lbl_varianza;
        private System.Windows.Forms.TextBox txt_varianza;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_frecuenciaEsperada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_desviacion;
        private System.Windows.Forms.Button btn_chi_cuadrado;
    }
}