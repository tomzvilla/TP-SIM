
namespace TP_SIM.Interfaz
{
    partial class tp3_window
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
            this.cmb_distribucion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.param_a = new System.Windows.Forms.NumericUpDown();
            this.param_b = new System.Windows.Forms.NumericUpDown();
            this.param_m = new System.Windows.Forms.NumericUpDown();
            this.param_d = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_intervalo = new System.Windows.Forms.ComboBox();
            this.btn_generar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_d)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_distribucion
            // 
            this.cmb_distribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_distribucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_distribucion.FormattingEnabled = true;
            this.cmb_distribucion.Location = new System.Drawing.Point(169, 75);
            this.cmb_distribucion.Name = "cmb_distribucion";
            this.cmb_distribucion.Size = new System.Drawing.Size(359, 32);
            this.cmb_distribucion.TabIndex = 0;
            this.cmb_distribucion.SelectedIndexChanged += new System.EventHandler(this.cmb_distribucion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distribucion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parámetros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Media:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "B:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cantidad (N):";
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(169, 26);
            this.cantidad.Maximum = new decimal(new int[] {
            1995576265,
            1051280,
            0,
            0});
            this.cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(359, 29);
            this.cantidad.TabIndex = 9;
            this.cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(301, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Desv Est:";
            // 
            // param_a
            // 
            this.param_a.DecimalPlaces = 4;
            this.param_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param_a.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.param_a.Location = new System.Drawing.Point(195, 292);
            this.param_a.Maximum = new decimal(new int[] {
            1995576265,
            1051280,
            0,
            0});
            this.param_a.Minimum = new decimal(new int[] {
            1995576265,
            1051280,
            0,
            -2147483648});
            this.param_a.Name = "param_a";
            this.param_a.Size = new System.Drawing.Size(98, 29);
            this.param_a.TabIndex = 13;
            // 
            // param_b
            // 
            this.param_b.DecimalPlaces = 4;
            this.param_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param_b.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.param_b.Location = new System.Drawing.Point(405, 292);
            this.param_b.Maximum = new decimal(new int[] {
            1995576265,
            1051280,
            0,
            0});
            this.param_b.Minimum = new decimal(new int[] {
            1995576265,
            1051280,
            0,
            -2147483648});
            this.param_b.Name = "param_b";
            this.param_b.Size = new System.Drawing.Size(96, 29);
            this.param_b.TabIndex = 14;
            // 
            // param_m
            // 
            this.param_m.DecimalPlaces = 4;
            this.param_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param_m.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.param_m.Location = new System.Drawing.Point(195, 366);
            this.param_m.Maximum = new decimal(new int[] {
            1995576265,
            1051280,
            0,
            0});
            this.param_m.Name = "param_m";
            this.param_m.Size = new System.Drawing.Size(98, 29);
            this.param_m.TabIndex = 15;
            this.param_m.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // param_d
            // 
            this.param_d.DecimalPlaces = 4;
            this.param_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param_d.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.param_d.Location = new System.Drawing.Point(405, 369);
            this.param_d.Maximum = new decimal(new int[] {
            1995576265,
            1051280,
            0,
            0});
            this.param_d.Minimum = new decimal(new int[] {
            1995576265,
            1051280,
            0,
            -2147483648});
            this.param_d.Name = "param_d";
            this.param_d.Size = new System.Drawing.Size(96, 29);
            this.param_d.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Intervalos:";
            // 
            // cmb_intervalo
            // 
            this.cmb_intervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_intervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_intervalo.FormattingEnabled = true;
            this.cmb_intervalo.Location = new System.Drawing.Point(169, 144);
            this.cmb_intervalo.Name = "cmb_intervalo";
            this.cmb_intervalo.Size = new System.Drawing.Size(359, 32);
            this.cmb_intervalo.TabIndex = 18;
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(204, 460);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(158, 44);
            this.btn_generar.TabIndex = 19;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // tp3_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 545);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.cmb_intervalo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.param_d);
            this.Controls.Add(this.param_m);
            this.Controls.Add(this.param_b);
            this.Controls.Add(this.param_a);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_distribucion);
            this.Name = "tp3_window";
            this.Text = "tp3_window";
            this.Load += new System.EventHandler(this.tp3_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param_d)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_distribucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown param_a;
        private System.Windows.Forms.NumericUpDown param_b;
        private System.Windows.Forms.NumericUpDown param_m;
        private System.Windows.Forms.NumericUpDown param_d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_intervalo;
        private System.Windows.Forms.Button btn_generar;
    }
}