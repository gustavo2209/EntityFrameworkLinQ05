
namespace EntityFrameworkLinQ05
{
    partial class ReporteProdStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteProdStock));
            this.dgvReporte01 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte01)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporte01
            // 
            this.dgvReporte01.AllowUserToAddRows = false;
            this.dgvReporte01.AllowUserToDeleteRows = false;
            this.dgvReporte01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporte01.Location = new System.Drawing.Point(0, 0);
            this.dgvReporte01.Name = "dgvReporte01";
            this.dgvReporte01.ReadOnly = true;
            this.dgvReporte01.Size = new System.Drawing.Size(381, 423);
            this.dgvReporte01.TabIndex = 0;
            // 
            // ReporteProdStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntityFrameworkLinQ05.Properties.Resources.back08;
            this.ClientSize = new System.Drawing.Size(381, 423);
            this.Controls.Add(this.dgvReporte01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReporteProdStock";
            this.Text = "Reporte Productos y Stock";
            this.Load += new System.EventHandler(this.ReporteProdStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporte01;
    }
}