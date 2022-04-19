
namespace TP_SIM.Interfaz
{
    partial class TestKS
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
            this.btn_hipotesis = new System.Windows.Forms.Button();
            this.txt_ks_tab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ks = new System.Windows.Forms.TextBox();
            this.lbl_hipotesis = new System.Windows.Forms.Label();
            this.dgv_ks = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ks)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hipotesis
            // 
            this.btn_hipotesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hipotesis.Location = new System.Drawing.Point(656, 464);
            this.btn_hipotesis.Name = "btn_hipotesis";
            this.btn_hipotesis.Size = new System.Drawing.Size(174, 65);
            this.btn_hipotesis.TabIndex = 13;
            this.btn_hipotesis.Text = "Comprobar Hipotesis";
            this.btn_hipotesis.UseVisualStyleBackColor = true;
            this.btn_hipotesis.Click += new System.EventHandler(this.btn_hipotesis_Click);
            // 
            // txt_ks_tab
            // 
            this.txt_ks_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ks_tab.Location = new System.Drawing.Point(494, 504);
            this.txt_ks_tab.Name = "txt_ks_tab";
            this.txt_ks_tab.Size = new System.Drawing.Size(134, 31);
            this.txt_ks_tab.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "KS Tabulado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "KS Calculado";
            // 
            // txt_ks
            // 
            this.txt_ks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ks.Location = new System.Drawing.Point(494, 452);
            this.txt_ks.Name = "txt_ks";
            this.txt_ks.Size = new System.Drawing.Size(134, 31);
            this.txt_ks.TabIndex = 9;
            // 
            // lbl_hipotesis
            // 
            this.lbl_hipotesis.AutoSize = true;
            this.lbl_hipotesis.Location = new System.Drawing.Point(643, 6);
            this.lbl_hipotesis.Name = "lbl_hipotesis";
            this.lbl_hipotesis.Size = new System.Drawing.Size(0, 13);
            this.lbl_hipotesis.TabIndex = 8;
            // 
            // dgv_ks
            // 
            this.dgv_ks.AllowUserToAddRows = false;
            this.dgv_ks.AllowUserToDeleteRows = false;
            this.dgv_ks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.fe,
            this.fo,
            this.po,
            this.Pe,
            this.poac,
            this.peac,
            this.c});
            this.dgv_ks.Location = new System.Drawing.Point(25, 12);
            this.dgv_ks.Name = "dgv_ks";
            this.dgv_ks.Size = new System.Drawing.Size(1204, 424);
            this.dgv_ks.TabIndex = 7;
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
            // po
            // 
            this.po.HeaderText = "Probabilidad Observada";
            this.po.Name = "po";
            // 
            // Pe
            // 
            this.Pe.HeaderText = "Probabilidad Esperada";
            this.Pe.Name = "Pe";
            // 
            // poac
            // 
            this.poac.HeaderText = "Po (AC)";
            this.poac.Name = "poac";
            // 
            // peac
            // 
            this.peac.HeaderText = "Pe(AC)";
            this.peac.Name = "peac";
            // 
            // c
            // 
            this.c.HeaderText = "|Po(AC) - Pe(AC)|";
            this.c.Name = "c";
            // 
            // TestKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 560);
            this.Controls.Add(this.btn_hipotesis);
            this.Controls.Add(this.txt_ks_tab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ks);
            this.Controls.Add(this.lbl_hipotesis);
            this.Controls.Add(this.dgv_ks);
            this.Name = "TestKS";
            this.Text = "TestKS";
            this.Load += new System.EventHandler(this.TestKS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hipotesis;
        private System.Windows.Forms.TextBox txt_ks_tab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ks;
        private System.Windows.Forms.Label lbl_hipotesis;
        private System.Windows.Forms.DataGridView dgv_ks;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn po;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn poac;
        private System.Windows.Forms.DataGridViewTextBoxColumn peac;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
    }
}