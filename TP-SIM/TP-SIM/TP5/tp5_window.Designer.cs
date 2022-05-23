
namespace TP_SIM.TP5
{
    partial class tp5_window
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
            this.label1 = new System.Windows.Forms.Label();
            this.n_mecanicos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.n_lavadores = new System.Windows.Forms.NumericUpDown();
            this.num_iteraciones = new System.Windows.Forms.NumericUpDown();
            this.fila_desde = new System.Windows.Forms.NumericUpDown();
            this.p_probabilidades = new System.Windows.Forms.Panel();
            this.exp_media_lavado = new System.Windows.Forms.NumericUpDown();
            this.exp_media_mantenimiento = new System.Windows.Forms.NumericUpDown();
            this.lambda_p = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.filas_a_mostrar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.n_mecanicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_lavadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_iteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fila_desde)).BeginInit();
            this.p_probabilidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_media_lavado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_media_mantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda_p)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filas_a_mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mecanicos";
            // 
            // n_mecanicos
            // 
            this.n_mecanicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_mecanicos.Location = new System.Drawing.Point(218, 10);
            this.n_mecanicos.Maximum = new decimal(new int[] {
            -905992047,
            126,
            0,
            0});
            this.n_mecanicos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_mecanicos.Name = "n_mecanicos";
            this.n_mecanicos.Size = new System.Drawing.Size(120, 29);
            this.n_mecanicos.TabIndex = 1;
            this.n_mecanicos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lavadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Iteraciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fila Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Probabilidad Llegada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Media Poisson";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tiempo mantenimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Media Exp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Media Exp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tiempo Lavado";
            // 
            // n_lavadores
            // 
            this.n_lavadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_lavadores.Location = new System.Drawing.Point(218, 60);
            this.n_lavadores.Maximum = new decimal(new int[] {
            -905992047,
            126,
            0,
            0});
            this.n_lavadores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_lavadores.Name = "n_lavadores";
            this.n_lavadores.Size = new System.Drawing.Size(120, 29);
            this.n_lavadores.TabIndex = 11;
            this.n_lavadores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_iteraciones
            // 
            this.num_iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_iteraciones.Location = new System.Drawing.Point(218, 110);
            this.num_iteraciones.Maximum = new decimal(new int[] {
            -905992047,
            126,
            0,
            0});
            this.num_iteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_iteraciones.Name = "num_iteraciones";
            this.num_iteraciones.Size = new System.Drawing.Size(120, 29);
            this.num_iteraciones.TabIndex = 12;
            this.num_iteraciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fila_desde
            // 
            this.fila_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fila_desde.Location = new System.Drawing.Point(218, 159);
            this.fila_desde.Maximum = new decimal(new int[] {
            -905992047,
            126,
            0,
            0});
            this.fila_desde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fila_desde.Name = "fila_desde";
            this.fila_desde.Size = new System.Drawing.Size(120, 29);
            this.fila_desde.TabIndex = 13;
            this.fila_desde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // p_probabilidades
            // 
            this.p_probabilidades.Controls.Add(this.exp_media_lavado);
            this.p_probabilidades.Controls.Add(this.exp_media_mantenimiento);
            this.p_probabilidades.Controls.Add(this.lambda_p);
            this.p_probabilidades.Controls.Add(this.label5);
            this.p_probabilidades.Controls.Add(this.label6);
            this.p_probabilidades.Controls.Add(this.label9);
            this.p_probabilidades.Controls.Add(this.label7);
            this.p_probabilidades.Controls.Add(this.label10);
            this.p_probabilidades.Controls.Add(this.label8);
            this.p_probabilidades.Location = new System.Drawing.Point(390, 12);
            this.p_probabilidades.Name = "p_probabilidades";
            this.p_probabilidades.Size = new System.Drawing.Size(384, 278);
            this.p_probabilidades.TabIndex = 14;
            this.p_probabilidades.Visible = false;
            // 
            // exp_media_lavado
            // 
            this.exp_media_lavado.DecimalPlaces = 2;
            this.exp_media_lavado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_media_lavado.Location = new System.Drawing.Point(175, 231);
            this.exp_media_lavado.Maximum = new decimal(new int[] {
            -905992047,
            126,
            0,
            0});
            this.exp_media_lavado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.exp_media_lavado.Name = "exp_media_lavado";
            this.exp_media_lavado.Size = new System.Drawing.Size(120, 29);
            this.exp_media_lavado.TabIndex = 17;
            this.exp_media_lavado.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // exp_media_mantenimiento
            // 
            this.exp_media_mantenimiento.DecimalPlaces = 2;
            this.exp_media_mantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_media_mantenimiento.Location = new System.Drawing.Point(175, 154);
            this.exp_media_mantenimiento.Maximum = new decimal(new int[] {
            -905992047,
            126,
            0,
            0});
            this.exp_media_mantenimiento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.exp_media_mantenimiento.Name = "exp_media_mantenimiento";
            this.exp_media_mantenimiento.Size = new System.Drawing.Size(120, 29);
            this.exp_media_mantenimiento.TabIndex = 16;
            this.exp_media_mantenimiento.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lambda_p
            // 
            this.lambda_p.DecimalPlaces = 2;
            this.lambda_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lambda_p.Location = new System.Drawing.Point(175, 50);
            this.lambda_p.Maximum = new decimal(new int[] {
            -905992047,
            126,
            0,
            0});
            this.lambda_p.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lambda_p.Name = "lambda_p";
            this.lambda_p.Size = new System.Drawing.Size(120, 29);
            this.lambda_p.TabIndex = 15;
            this.lambda_p.Value = new decimal(new int[] {
            66,
            0,
            0,
            131072});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(218, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 47);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cambiar P()";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filas_a_mostrar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.n_mecanicos);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fila_desde);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.num_iteraciones);
            this.panel1.Controls.Add(this.n_lavadores);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 335);
            this.panel1.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nro Filas";
            // 
            // filas_a_mostrar
            // 
            this.filas_a_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filas_a_mostrar.Location = new System.Drawing.Point(218, 210);
            this.filas_a_mostrar.Maximum = new decimal(new int[] {
            -905992047,
            126,
            0,
            0});
            this.filas_a_mostrar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.filas_a_mostrar.Name = "filas_a_mostrar";
            this.filas_a_mostrar.Size = new System.Drawing.Size(120, 29);
            this.filas_a_mostrar.TabIndex = 18;
            this.filas_a_mostrar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tp5_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(787, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_probabilidades);
            this.Name = "tp5_window";
            this.Text = "tp5_window";
            ((System.ComponentModel.ISupportInitialize)(this.n_mecanicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_lavadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_iteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fila_desde)).EndInit();
            this.p_probabilidades.ResumeLayout(false);
            this.p_probabilidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_media_lavado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_media_mantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda_p)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filas_a_mostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown n_mecanicos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown n_lavadores;
        private System.Windows.Forms.NumericUpDown num_iteraciones;
        private System.Windows.Forms.NumericUpDown fila_desde;
        private System.Windows.Forms.Panel p_probabilidades;
        private System.Windows.Forms.NumericUpDown exp_media_lavado;
        private System.Windows.Forms.NumericUpDown exp_media_mantenimiento;
        private System.Windows.Forms.NumericUpDown lambda_p;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown filas_a_mostrar;
        private System.Windows.Forms.Label label11;
    }
}