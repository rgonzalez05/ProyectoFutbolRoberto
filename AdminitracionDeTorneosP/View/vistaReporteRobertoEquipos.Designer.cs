
namespace AdminitracionDeTorneosP.View
{
    partial class vistaReporteRobertoEquipos
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
            this.Equiposlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Equiposlist)).BeginInit();
            this.SuspendLayout();
            // 
            // Equiposlist
            // 
            this.Equiposlist.BackgroundColor = System.Drawing.Color.Azure;
            this.Equiposlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Equiposlist.GridColor = System.Drawing.Color.Azure;
            this.Equiposlist.Location = new System.Drawing.Point(61, 61);
            this.Equiposlist.Name = "Equiposlist";
            this.Equiposlist.RowHeadersVisible = false;
            this.Equiposlist.RowHeadersWidth = 51;
            this.Equiposlist.RowTemplate.Height = 24;
            this.Equiposlist.Size = new System.Drawing.Size(1057, 409);
            this.Equiposlist.TabIndex = 63;
            // 
            // vistaReporteRobertoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 538);
            this.Controls.Add(this.Equiposlist);
            this.Name = "vistaReporteRobertoEquipos";
            this.Text = "vistaReporteRobertoEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.Equiposlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Equiposlist;
    }
}