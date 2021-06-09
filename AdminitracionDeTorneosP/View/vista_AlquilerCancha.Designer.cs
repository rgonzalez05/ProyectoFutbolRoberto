
namespace AdminitracionDeTorneosP.View
{
    partial class vista_AlquilerCancha
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
            this.cbCancha = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Alquilerlist = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.txtFecha_Inicio = new System.Windows.Forms.TextBox();
            this.txtFecha_Final = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArbitro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaApartada = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Alquilerlist)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCancha
            // 
            this.cbCancha.BackColor = System.Drawing.Color.AliceBlue;
            this.cbCancha.FormattingEnabled = true;
            this.cbCancha.Location = new System.Drawing.Point(489, 217);
            this.cbCancha.Name = "cbCancha";
            this.cbCancha.Size = new System.Drawing.Size(153, 24);
            this.cbCancha.TabIndex = 74;
            this.cbCancha.SelectedIndexChanged += new System.EventHandler(this.cbCancha_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label11.Location = new System.Drawing.Point(513, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 28);
            this.label11.TabIndex = 73;
            this.label11.Text = "Canchas";
            // 
            // Alquilerlist
            // 
            this.Alquilerlist.BackgroundColor = System.Drawing.Color.Azure;
            this.Alquilerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Alquilerlist.GridColor = System.Drawing.Color.Azure;
            this.Alquilerlist.Location = new System.Drawing.Point(154, 275);
            this.Alquilerlist.Name = "Alquilerlist";
            this.Alquilerlist.RowHeadersVisible = false;
            this.Alquilerlist.RowHeadersWidth = 51;
            this.Alquilerlist.RowTemplate.Height = 24;
            this.Alquilerlist.Size = new System.Drawing.Size(802, 210);
            this.Alquilerlist.TabIndex = 72;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGuardar.Location = new System.Drawing.Point(492, 491);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(161, 50);
            this.buttonGuardar.TabIndex = 71;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // txtFecha_Inicio
            // 
            this.txtFecha_Inicio.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFecha_Inicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtFecha_Inicio.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha_Inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.txtFecha_Inicio.Location = new System.Drawing.Point(266, 99);
            this.txtFecha_Inicio.Name = "txtFecha_Inicio";
            this.txtFecha_Inicio.Size = new System.Drawing.Size(183, 35);
            this.txtFecha_Inicio.TabIndex = 70;
            // 
            // txtFecha_Final
            // 
            this.txtFecha_Final.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFecha_Final.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha_Final.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.txtFecha_Final.Location = new System.Drawing.Point(475, 100);
            this.txtFecha_Final.Name = "txtFecha_Final";
            this.txtFecha_Final.Size = new System.Drawing.Size(183, 35);
            this.txtFecha_Final.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(281, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 28);
            this.label9.TabIndex = 68;
            this.label9.Text = "Hora del Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(495, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 67;
            this.label6.Text = "Hora del Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(521, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 66;
            this.label5.Text = "Cancha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(394, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 59);
            this.label1.TabIndex = 65;
            this.label1.Text = "Alquiler de Cancha";
            // 
            // cbArbitro
            // 
            this.cbArbitro.BackColor = System.Drawing.Color.AliceBlue;
            this.cbArbitro.FormattingEnabled = true;
            this.cbArbitro.Location = new System.Drawing.Point(696, 217);
            this.cbArbitro.Name = "cbArbitro";
            this.cbArbitro.Size = new System.Drawing.Size(153, 24);
            this.cbArbitro.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(691, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 75;
            this.label4.Text = "Arbitro(Opcional)";
            // 
            // cbCliente
            // 
            this.cbCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(277, 217);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(153, 24);
            this.cbCliente.TabIndex = 83;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(309, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 84;
            this.label7.Text = "Cliente";
            // 
            // txtFechaApartada
            // 
            this.txtFechaApartada.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFechaApartada.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaApartada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.txtFechaApartada.Location = new System.Drawing.Point(688, 99);
            this.txtFechaApartada.Name = "txtFechaApartada";
            this.txtFechaApartada.Size = new System.Drawing.Size(183, 35);
            this.txtFechaApartada.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(708, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 28);
            this.label10.TabIndex = 85;
            this.label10.Text = "Fecha Apartada";
            // 
            // vista_AlquilerCancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 540);
            this.Controls.Add(this.txtFechaApartada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbArbitro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCancha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Alquilerlist);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.txtFecha_Inicio);
            this.Controls.Add(this.txtFecha_Final);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "vista_AlquilerCancha";
            this.Text = "vista_Reporte_AlquilerCancha";
            ((System.ComponentModel.ISupportInitialize)(this.Alquilerlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCancha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView Alquilerlist;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox txtFecha_Inicio;
        private System.Windows.Forms.TextBox txtFecha_Final;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArbitro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaApartada;
        private System.Windows.Forms.Label label10;
    }
}