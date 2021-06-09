
namespace AdminitracionDeTorneosP.View
{
    partial class listadoArbitros
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
            this.label4 = new System.Windows.Forms.Label();
            this.ListArbitros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListArbitros)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(185, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 60);
            this.label4.TabIndex = 22;
            this.label4.Text = "Listado de Arbitros";
            // 
            // ListArbitros
            // 
            this.ListArbitros.AllowUserToAddRows = false;
            this.ListArbitros.AllowUserToDeleteRows = false;
            this.ListArbitros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListArbitros.BackgroundColor = System.Drawing.Color.Azure;
            this.ListArbitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListArbitros.Location = new System.Drawing.Point(47, 122);
            this.ListArbitros.Margin = new System.Windows.Forms.Padding(4);
            this.ListArbitros.Name = "ListArbitros";
            this.ListArbitros.ReadOnly = true;
            this.ListArbitros.RowHeadersVisible = false;
            this.ListArbitros.RowHeadersWidth = 51;
            this.ListArbitros.Size = new System.Drawing.Size(701, 255);
            this.ListArbitros.TabIndex = 23;
            // 
            // listadoArbitros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListArbitros);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "listadoArbitros";
            this.Text = "listadoArbitros";
            ((System.ComponentModel.ISupportInitialize)(this.ListArbitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ListArbitros;
    }
}