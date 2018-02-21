namespace Prueba3
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaPreviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navegador1 = new Navegador.Navegador();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.mantenimientoDeReportesToolStripMenuItem,
            this.listadoDeReportesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistaPreviaToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // vistaPreviaToolStripMenuItem
            // 
            this.vistaPreviaToolStripMenuItem.Name = "vistaPreviaToolStripMenuItem";
            this.vistaPreviaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.vistaPreviaToolStripMenuItem.Text = "Vista Previa";
            this.vistaPreviaToolStripMenuItem.Click += new System.EventHandler(this.vistaPreviaToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // mantenimientoDeReportesToolStripMenuItem
            // 
            this.mantenimientoDeReportesToolStripMenuItem.Name = "mantenimientoDeReportesToolStripMenuItem";
            this.mantenimientoDeReportesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.mantenimientoDeReportesToolStripMenuItem.Text = "Mantenimiento de Reportes";
            this.mantenimientoDeReportesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeReportesToolStripMenuItem_Click);
            // 
            // listadoDeReportesToolStripMenuItem
            // 
            this.listadoDeReportesToolStripMenuItem.Name = "listadoDeReportesToolStripMenuItem";
            this.listadoDeReportesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.listadoDeReportesToolStripMenuItem.Text = "Listado de Reportes";
            this.listadoDeReportesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeReportesToolStripMenuItem_Click_1);
            // 
            // navegador1
            // 
            this.navegador1.IdApp = 0;
            this.navegador1.Location = new System.Drawing.Point(52, 27);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(559, 47);
            this.navegador1.sNombreBD = "reporte2";
            this.navegador1.sNombreTabla = null;
            this.navegador1.sPass = "12345";
            this.navegador1.sResult = null;
            this.navegador1.sServidor = "localhost";
            this.navegador1.sUsuario = "root";
            this.navegador1.TabIndex = 1;
            this.navegador1.VistaReporte = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 358);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaPreviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeReportesToolStripMenuItem;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeReportesToolStripMenuItem;
    }
}

