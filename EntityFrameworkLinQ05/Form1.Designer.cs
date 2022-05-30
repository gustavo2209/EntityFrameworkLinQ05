
namespace EntityFrameworkLinQ05
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosYStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosYStocksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasXProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasXProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.comprasVentasToolStripMenuItem,
            this.productosYStocksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.retirarProductoToolStripMenuItem,
            this.actualizarDatosDeProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // retirarProductoToolStripMenuItem
            // 
            this.retirarProductoToolStripMenuItem.Name = "retirarProductoToolStripMenuItem";
            this.retirarProductoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.retirarProductoToolStripMenuItem.Text = "Retirar Producto";
            this.retirarProductoToolStripMenuItem.Click += new System.EventHandler(this.retirarProductoToolStripMenuItem_Click);
            // 
            // actualizarDatosDeProductoToolStripMenuItem
            // 
            this.actualizarDatosDeProductoToolStripMenuItem.Name = "actualizarDatosDeProductoToolStripMenuItem";
            this.actualizarDatosDeProductoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.actualizarDatosDeProductoToolStripMenuItem.Text = "Actualizar datos de Producto";
            this.actualizarDatosDeProductoToolStripMenuItem.Click += new System.EventHandler(this.actualizarDatosDeProductoToolStripMenuItem_Click);
            // 
            // comprasVentasToolStripMenuItem
            // 
            this.comprasVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompraToolStripMenuItem,
            this.nuevaVentaToolStripMenuItem});
            this.comprasVentasToolStripMenuItem.Name = "comprasVentasToolStripMenuItem";
            this.comprasVentasToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.comprasVentasToolStripMenuItem.Text = "Compras / Ventas";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaCompraToolStripMenuItem.Text = "Nueva Compra";
            this.nuevaCompraToolStripMenuItem.Click += new System.EventHandler(this.nuevaCompraToolStripMenuItem_Click);
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // productosYStocksToolStripMenuItem
            // 
            this.productosYStocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosYStocksToolStripMenuItem1,
            this.ventasXProductoToolStripMenuItem,
            this.comprasXProductoToolStripMenuItem});
            this.productosYStocksToolStripMenuItem.Name = "productosYStocksToolStripMenuItem";
            this.productosYStocksToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.productosYStocksToolStripMenuItem.Text = "Reportes";
            // 
            // productosYStocksToolStripMenuItem1
            // 
            this.productosYStocksToolStripMenuItem1.Name = "productosYStocksToolStripMenuItem1";
            this.productosYStocksToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.productosYStocksToolStripMenuItem1.Text = "Productos y Stocks";
            // 
            // ventasXProductoToolStripMenuItem
            // 
            this.ventasXProductoToolStripMenuItem.Name = "ventasXProductoToolStripMenuItem";
            this.ventasXProductoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ventasXProductoToolStripMenuItem.Text = "Ventas X Producto";
            // 
            // comprasXProductoToolStripMenuItem
            // 
            this.comprasXProductoToolStripMenuItem.Name = "comprasXProductoToolStripMenuItem";
            this.comprasXProductoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.comprasXProductoToolStripMenuItem.Text = "Compras X Producto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntityFrameworkLinQ05.Properties.Resources.back08;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ventas y Compras de Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosYStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosYStocksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasXProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasXProductoToolStripMenuItem;
    }
}

