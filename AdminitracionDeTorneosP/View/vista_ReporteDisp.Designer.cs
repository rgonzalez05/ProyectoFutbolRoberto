
namespace AdminitracionDeTorneosP.View
{
    partial class vista_ReporteDisp
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbCancha = new System.Windows.Forms.ComboBox();
            this.txtFecha_Final = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.listDisponibilidad = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFecha_Inicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listDisponibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(291, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 91;
            this.label2.Text = "Cancha";
            // 
            // cbCancha
            // 
            this.cbCancha.BackColor = System.Drawing.Color.Azure;
            this.cbCancha.FormattingEnabled = true;
            this.cbCancha.Location = new System.Drawing.Point(257, 143);
            this.cbCancha.Margin = new System.Windows.Forms.Padding(4);
            this.cbCancha.Name = "cbCancha";
            this.cbCancha.Size = new System.Drawing.Size(160, 24);
            this.cbCancha.TabIndex = 90;
            // 
            // txtFecha_Final
            // 
            this.txtFecha_Final.BackColor = System.Drawing.Color.Azure;
            this.txtFecha_Final.Location = new System.Drawing.Point(813, 143);
            this.txtFecha_Final.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha_Final.Name = "txtFecha_Final";
            this.txtFecha_Final.Size = new System.Drawing.Size(156, 22);
            this.txtFecha_Final.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(834, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 88;
            this.label1.Text = "Fecha Final";
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBusca.Location = new System.Drawing.Point(539, 453);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(156, 60);
            this.btnBusca.TabIndex = 87;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // listDisponibilidad
            // 
            this.listDisponibilidad.BackgroundColor = System.Drawing.Color.Azure;
            this.listDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDisponibilidad.Location = new System.Drawing.Point(150, 201);
            this.listDisponibilidad.Margin = new System.Windows.Forms.Padding(4);
            this.listDisponibilidad.Name = "listDisponibilidad";
            this.listDisponibilidad.RowHeadersWidth = 51;
            this.listDisponibilidad.Size = new System.Drawing.Size(909, 228);
            this.listDisponibilidad.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(331, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(539, 59);
            this.label9.TabIndex = 85;
            this.label9.Text = "Disponibilidad de Cancha";
            // 
            // txtFecha_Inicio
            // 
            this.txtFecha_Inicio.BackColor = System.Drawing.Color.Azure;
            this.txtFecha_Inicio.Location = new System.Drawing.Point(539, 145);
            this.txtFecha_Inicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha_Inicio.Name = "txtFecha_Inicio";
            this.txtFecha_Inicio.Size = new System.Drawing.Size(156, 22);
            this.txtFecha_Inicio.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(562, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 83;
            this.label7.Text = "Fecha Inicio";
            // 
            // vista_ReporteDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCancha);
            this.Controls.Add(this.txtFecha_Final);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.listDisponibilidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFecha_Inicio);
            this.Controls.Add(this.label7);
            this.Name = "vista_ReporteDisp";
            this.Text = "vista_ReporteDisp";
            ((System.ComponentModel.ISupportInitialize)(this.listDisponibilidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCancha;
        private System.Windows.Forms.TextBox txtFecha_Final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DataGridView listDisponibilidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFecha_Inicio;
        private System.Windows.Forms.Label label7;
    }
}