
namespace TP_SIM
{
    partial class tp1_window
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_intervalos = new System.Windows.Forms.ComboBox();
            this.qnt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seed = new System.Windows.Forms.NumericUpDown();
            this.nud_k = new System.Windows.Forms.NumericUpDown();
            this.nud_g = new System.Windows.Forms.NumericUpDown();
            this.nud_c = new System.Windows.Forms.NumericUpDown();
            this.btn_generar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_generador = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_c)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_intervalos
            // 
            this.cmb_intervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_intervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_intervalos.FormattingEnabled = true;
            this.cmb_intervalos.Location = new System.Drawing.Point(227, 262);
            this.cmb_intervalos.Name = "cmb_intervalos";
            this.cmb_intervalos.Size = new System.Drawing.Size(251, 32);
            this.cmb_intervalos.TabIndex = 5;
            // 
            // qnt
            // 
            this.qnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qnt.Location = new System.Drawing.Point(226, 71);
            this.qnt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.qnt.Name = "qnt";
            this.qnt.Size = new System.Drawing.Size(252, 29);
            this.qnt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad Números:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Parámetro K:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Parámetro G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Parámetro C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Semilla:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Intervalos:";
            // 
            // seed
            // 
            this.seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seed.Location = new System.Drawing.Point(226, 106);
            this.seed.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(252, 29);
            this.seed.TabIndex = 18;
            // 
            // nud_k
            // 
            this.nud_k.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_k.Location = new System.Drawing.Point(227, 140);
            this.nud_k.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_k.Name = "nud_k";
            this.nud_k.Size = new System.Drawing.Size(251, 29);
            this.nud_k.TabIndex = 19;
            // 
            // nud_g
            // 
            this.nud_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_g.Location = new System.Drawing.Point(227, 179);
            this.nud_g.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_g.Name = "nud_g";
            this.nud_g.Size = new System.Drawing.Size(251, 29);
            this.nud_g.TabIndex = 20;
            // 
            // nud_c
            // 
            this.nud_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_c.Location = new System.Drawing.Point(227, 220);
            this.nud_c.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_c.Name = "nud_c";
            this.nud_c.Size = new System.Drawing.Size(251, 29);
            this.nud_c.TabIndex = 21;
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.Transparent;
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(171, 328);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(187, 37);
            this.btn_generar.TabIndex = 22;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Generador:";
            // 
            // cmb_generador
            // 
            this.cmb_generador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_generador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_generador.FormattingEnabled = true;
            this.cmb_generador.Location = new System.Drawing.Point(227, 26);
            this.cmb_generador.Name = "cmb_generador";
            this.cmb_generador.Size = new System.Drawing.Size(251, 32);
            this.cmb_generador.TabIndex = 24;
            this.cmb_generador.SelectedValueChanged += new System.EventHandler(this.cmb_generador_SelectedValueChanged);
            // 
            // tp1_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 408);
            this.Controls.Add(this.cmb_generador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.nud_c);
            this.Controls.Add(this.nud_g);
            this.Controls.Add(this.nud_k);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qnt);
            this.Controls.Add(this.cmb_intervalos);
            this.Name = "tp1_window";
            this.Text = "SIM - TP1";
            this.Load += new System.EventHandler(this.tp1_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_intervalos;
        private System.Windows.Forms.NumericUpDown qnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown seed;
        private System.Windows.Forms.NumericUpDown nud_k;
        private System.Windows.Forms.NumericUpDown nud_g;
        private System.Windows.Forms.NumericUpDown nud_c;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_generador;
    }
}

