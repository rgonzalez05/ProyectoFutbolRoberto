
namespace AdminitracionDeTorneosP.View
{
    partial class VistaListaJugadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lista_jugadores_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lista_jugadores_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado Jugadores";
            // 
            // lista_jugadores_datagrid
            // 
            this.lista_jugadores_datagrid.AllowUserToAddRows = false;
            this.lista_jugadores_datagrid.AllowUserToDeleteRows = false;
            this.lista_jugadores_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista_jugadores_datagrid.BackgroundColor = System.Drawing.Color.Azure;
            this.lista_jugadores_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lista_jugadores_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.lista_jugadores_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista_jugadores_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.lista_jugadores_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_jugadores_datagrid.EnableHeadersVisualStyles = false;
            this.lista_jugadores_datagrid.GridColor = System.Drawing.Color.Azure;
            this.lista_jugadores_datagrid.Location = new System.Drawing.Point(60, 110);
            this.lista_jugadores_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.lista_jugadores_datagrid.Name = "lista_jugadores_datagrid";
            this.lista_jugadores_datagrid.ReadOnly = true;
            this.lista_jugadores_datagrid.RowHeadersVisible = false;
            this.lista_jugadores_datagrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.lista_jugadores_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.lista_jugadores_datagrid.RowTemplate.Height = 24;
            this.lista_jugadores_datagrid.Size = new System.Drawing.Size(706, 218);
            this.lista_jugadores_datagrid.TabIndex = 1;
            // 
            // VistaListaJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista_jugadores_datagrid);
            this.Controls.Add(this.label1);
            this.Name = "VistaListaJugadores";
            this.Text = "VistaListaJugadores";
            this.Load += new System.EventHandler(this.VistaListaJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_jugadores_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lista_jugadores_datagrid;
    }
}