
namespace AdminitracionDeTorneosP.View
{
    partial class vista_Reporte_Bitacora
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
            this.label11 = new System.Windows.Forms.Label();
            this.Ingresolist = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.txtFecha_Inicio = new System.Windows.Forms.TextBox();
            this.txtFecha_Final = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ingresolist)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label11.Location = new System.Drawing.Point(531, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 28);
            this.label11.TabIndex = 63;
            this.label11.Text = "Bitácora";
            // 
            // Ingresolist
            // 
            this.Ingresolist.BackgroundColor = System.Drawing.Color.Azure;
            this.Ingresolist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ingresolist.GridColor = System.Drawing.Color.Azure;
            this.Ingresolist.Location = new System.Drawing.Point(153, 272);
            this.Ingresolist.Name = "Ingresolist";
            this.Ingresolist.RowHeadersVisible = false;
            this.Ingresolist.RowHeadersWidth = 51;
            this.Ingresolist.RowTemplate.Height = 24;
            this.Ingresolist.Size = new System.Drawing.Size(802, 210);
            this.Ingresolist.TabIndex = 62;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscar.Location = new System.Drawing.Point(491, 488);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(161, 50);
            this.buttonBuscar.TabIndex = 59;
            this.buttonBuscar.Text = "Busqueda";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // txtFecha_Inicio
            // 
            this.txtFecha_Inicio.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFecha_Inicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtFecha_Inicio.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha_Inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.txtFecha_Inicio.Location = new System.Drawing.Point(491, 122);
            this.txtFecha_Inicio.Name = "txtFecha_Inicio";
            this.txtFecha_Inicio.Size = new System.Drawing.Size(183, 35);
            this.txtFecha_Inicio.TabIndex = 58;
            // 
            // txtFecha_Final
            // 
            this.txtFecha_Final.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFecha_Final.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha_Final.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.txtFecha_Final.Location = new System.Drawing.Point(717, 122);
            this.txtFecha_Final.Name = "txtFecha_Final";
            this.txtFecha_Final.Size = new System.Drawing.Size(183, 35);
            this.txtFecha_Final.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(506, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 53;
            this.label9.Text = "Fecha del Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(737, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 28);
            this.label6.TabIndex = 51;
            this.label6.Text = "Fecha del Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(308, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 50;
            this.label5.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(484, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 59);
            this.label1.TabIndex = 48;
            this.label1.Text = "Bitácora";
            // 
            // cbUsuario
            // 
            this.cbUsuario.BackColor = System.Drawing.Color.AliceBlue;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(276, 132);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(153, 24);
            this.cbUsuario.TabIndex = 64;
            // 
            // vista_Reporte_Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 534);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Ingresolist);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.txtFecha_Inicio);
            this.Controls.Add(this.txtFecha_Final);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "vista_Reporte_Bitacora";
            this.Text = "vista_Reporte_Bitacora";
            ((System.ComponentModel.ISupportInitialize)(this.Ingresolist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView Ingresolist;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox txtFecha_Inicio;
        private System.Windows.Forms.TextBox txtFecha_Final;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsuario;
    }
}