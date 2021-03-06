
namespace TP_SIM.Runge_Kutta
{
    partial class rk_llegada_ataque
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
            this.txt_iteracion = new System.Windows.Forms.TextBox();
            this.dgv_rk = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dy_dx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_beta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rk)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_iteracion
            // 
            this.txt_iteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iteracion.Location = new System.Drawing.Point(16, 15);
            this.txt_iteracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_iteracion.Name = "txt_iteracion";
            this.txt_iteracion.ReadOnly = true;
            this.txt_iteracion.Size = new System.Drawing.Size(301, 37);
            this.txt_iteracion.TabIndex = 3;
            // 
            // dgv_rk
            // 
            this.dgv_rk.AllowUserToAddRows = false;
            this.dgv_rk.AllowUserToDeleteRows = false;
            this.dgv_rk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y,
            this.dy_dx,
            this.k2,
            this.K3,
            this.K4,
            this.xi1,
            this.yi1});
            this.dgv_rk.Location = new System.Drawing.Point(16, 69);
            this.dgv_rk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_rk.Name = "dgv_rk";
            this.dgv_rk.RowHeadersWidth = 51;
            this.dgv_rk.Size = new System.Drawing.Size(1276, 470);
            this.dgv_rk.TabIndex = 2;
            // 
            // x
            // 
            this.x.HeaderText = "Valor X";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.Width = 125;
            // 
            // y
            // 
            this.y.HeaderText = "Valor y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.Width = 125;
            // 
            // dy_dx
            // 
            this.dy_dx.HeaderText = "dY/dX (K1)";
            this.dy_dx.MinimumWidth = 6;
            this.dy_dx.Name = "dy_dx";
            this.dy_dx.Width = 125;
            // 
            // k2
            // 
            this.k2.HeaderText = "K2";
            this.k2.MinimumWidth = 6;
            this.k2.Name = "k2";
            this.k2.Width = 125;
            // 
            // K3
            // 
            this.K3.HeaderText = "K3";
            this.K3.MinimumWidth = 6;
            this.K3.Name = "K3";
            this.K3.Width = 125;
            // 
            // K4
            // 
            this.K4.HeaderText = "K4";
            this.K4.MinimumWidth = 6;
            this.K4.Name = "K4";
            this.K4.Width = 125;
            // 
            // xi1
            // 
            this.xi1.HeaderText = "Xi+1";
            this.xi1.MinimumWidth = 6;
            this.xi1.Name = "xi1";
            this.xi1.Width = 125;
            // 
            // yi1
            // 
            this.yi1.HeaderText = "Yi+1";
            this.yi1.MinimumWidth = 6;
            this.yi1.Name = "yi1";
            this.yi1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(419, 15);
            this.txt_a.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_a.Name = "txt_a";
            this.txt_a.ReadOnly = true;
            this.txt_a.Size = new System.Drawing.Size(117, 37);
            this.txt_a.TabIndex = 5;
            // 
            // txt_beta
            // 
            this.txt_beta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_beta.Location = new System.Drawing.Point(628, 15);
            this.txt_beta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_beta.Name = "txt_beta";
            this.txt_beta.ReadOnly = true;
            this.txt_beta.Size = new System.Drawing.Size(105, 37);
            this.txt_beta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Beta";
            // 
            // rk_llegada_ataque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 574);
            this.Controls.Add(this.txt_beta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_iteracion);
            this.Controls.Add(this.dgv_rk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "rk_llegada_ataque";
            this.Text = "rk_llegada_ataque";
            this.Load += new System.EventHandler(this.rk_llegada_ataque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_iteracion;
        private System.Windows.Forms.DataGridView dgv_rk;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn dy_dx;
        private System.Windows.Forms.DataGridViewTextBoxColumn k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn K3;
        private System.Windows.Forms.DataGridViewTextBoxColumn K4;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_beta;
        private System.Windows.Forms.Label label2;
    }
}