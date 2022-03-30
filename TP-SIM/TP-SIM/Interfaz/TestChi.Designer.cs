
namespace TP_SIM.Interfaz
{
    partial class TestChi
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
            this.dgv_chi_cuadrado = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_hipotesis = new System.Windows.Forms.Label();
            this.txt_chi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_chi_ac = new System.Windows.Forms.TextBox();
            this.btn_hipotesis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chi_cuadrado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_chi_cuadrado
            // 
            this.dgv_chi_cuadrado.AllowUserToAddRows = false;
            this.dgv_chi_cuadrado.AllowUserToDeleteRows = false;
            this.dgv_chi_cuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chi_cuadrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.fe,
            this.fo,
            this.chi,
            this.chiAc});
            this.dgv_chi_cuadrado.Location = new System.Drawing.Point(12, 29);
            this.dgv_chi_cuadrado.Name = "dgv_chi_cuadrado";
            this.dgv_chi_cuadrado.Size = new System.Drawing.Size(578, 414);
            this.dgv_chi_cuadrado.TabIndex = 0;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.Name = "intervalo";
            // 
            // fe
            // 
            this.fe.HeaderText = "Frecuencia Esperada";
            this.fe.Name = "fe";
            // 
            // fo
            // 
            this.fo.HeaderText = "Frecuencia Observada";
            this.fo.Name = "fo";
            // 
            // chi
            // 
            this.chi.HeaderText = "Chi Cuadrado";
            this.chi.Name = "chi";
            // 
            // chiAc
            // 
            this.chiAc.HeaderText = "Chi Acumulada";
            this.chiAc.Name = "chiAc";
            // 
            // lbl_hipotesis
            // 
            this.lbl_hipotesis.AutoSize = true;
            this.lbl_hipotesis.Location = new System.Drawing.Point(544, 74);
            this.lbl_hipotesis.Name = "lbl_hipotesis";
            this.lbl_hipotesis.Size = new System.Drawing.Size(0, 13);
            this.lbl_hipotesis.TabIndex = 1;
            // 
            // txt_chi
            // 
            this.txt_chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chi.Location = new System.Drawing.Point(187, 475);
            this.txt_chi.Name = "txt_chi";
            this.txt_chi.Size = new System.Drawing.Size(134, 31);
            this.txt_chi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi Acumulado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chi Tabulado";
            // 
            // txt_chi_ac
            // 
            this.txt_chi_ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chi_ac.Location = new System.Drawing.Point(187, 527);
            this.txt_chi_ac.Name = "txt_chi_ac";
            this.txt_chi_ac.Size = new System.Drawing.Size(134, 31);
            this.txt_chi_ac.TabIndex = 5;
            // 
            // btn_hipotesis
            // 
            this.btn_hipotesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hipotesis.Location = new System.Drawing.Point(372, 487);
            this.btn_hipotesis.Name = "btn_hipotesis";
            this.btn_hipotesis.Size = new System.Drawing.Size(163, 52);
            this.btn_hipotesis.TabIndex = 6;
            this.btn_hipotesis.Text = "Comprobar Hipotesis";
            this.btn_hipotesis.UseVisualStyleBackColor = true;
            this.btn_hipotesis.Click += new System.EventHandler(this.btn_hipotesis_Click);
            // 
            // TestChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 570);
            this.Controls.Add(this.btn_hipotesis);
            this.Controls.Add(this.txt_chi_ac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_chi);
            this.Controls.Add(this.lbl_hipotesis);
            this.Controls.Add(this.dgv_chi_cuadrado);
            this.Name = "TestChi";
            this.Text = "TestChi";
            this.Load += new System.EventHandler(this.TestChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chi_cuadrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chi_cuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiAc;
        private System.Windows.Forms.Label lbl_hipotesis;
        private System.Windows.Forms.TextBox txt_chi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_chi_ac;
        private System.Windows.Forms.Button btn_hipotesis;
    }
}