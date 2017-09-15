namespace Sisveug.Formularios
{
    partial class FormPrincipal
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
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosEntreFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeServiciosPorTecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.solucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.tecnicosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.diagnosticoToolStripMenuItem,
            this.piezasToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.solucionesToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.opcionesToolStripMenuItem.Text = "Basicos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // tecnicosToolStripMenuItem
            // 
            this.tecnicosToolStripMenuItem.Name = "tecnicosToolStripMenuItem";
            this.tecnicosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tecnicosToolStripMenuItem.Text = "tecnicos";
            this.tecnicosToolStripMenuItem.Click += new System.EventHandler(this.tecnicosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.marcasToolStripMenuItem.Text = "marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriasToolStripMenuItem.Text = "categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // diagnosticoToolStripMenuItem
            // 
            this.diagnosticoToolStripMenuItem.Name = "diagnosticoToolStripMenuItem";
            this.diagnosticoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diagnosticoToolStripMenuItem.Text = "diagnostico";
            this.diagnosticoToolStripMenuItem.Click += new System.EventHandler(this.diagnosticoToolStripMenuItem_Click);
            // 
            // piezasToolStripMenuItem
            // 
            this.piezasToolStripMenuItem.Name = "piezasToolStripMenuItem";
            this.piezasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.piezasToolStripMenuItem.Text = "piezas";
            this.piezasToolStripMenuItem.Click += new System.EventHandler(this.piezasToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.equiposToolStripMenuItem.Text = "equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.serviciosToolStripMenuItem.Text = "Operaciones";
            // 
            // ingToolStripMenuItem
            // 
            this.ingToolStripMenuItem.Name = "ingToolStripMenuItem";
            this.ingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ingToolStripMenuItem.Text = "Servicios";
            this.ingToolStripMenuItem.Click += new System.EventHandler(this.ingToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviciosEntreFechasToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.cantidadDeServiciosPorTecnicosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // serviciosEntreFechasToolStripMenuItem
            // 
            this.serviciosEntreFechasToolStripMenuItem.Name = "serviciosEntreFechasToolStripMenuItem";
            this.serviciosEntreFechasToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.serviciosEntreFechasToolStripMenuItem.Text = "Servicios entre fechas";
            this.serviciosEntreFechasToolStripMenuItem.Click += new System.EventHandler(this.serviciosEntreFechasToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // cantidadDeServiciosPorTecnicosToolStripMenuItem
            // 
            this.cantidadDeServiciosPorTecnicosToolStripMenuItem.Name = "cantidadDeServiciosPorTecnicosToolStripMenuItem";
            this.cantidadDeServiciosPorTecnicosToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cantidadDeServiciosPorTecnicosToolStripMenuItem.Text = "Cantidad de servicios por Tecnicos";
            this.cantidadDeServiciosPorTecnicosToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeServiciosPorTecnicosToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.ErrorImage = global::Sisveug.Properties.Resources.BarraIsquierda;
            this.pictureBox1.Image = global::Sisveug.Properties.Resources.BarraIsquierda;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // solucionesToolStripMenuItem
            // 
            this.solucionesToolStripMenuItem.Name = "solucionesToolStripMenuItem";
            this.solucionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solucionesToolStripMenuItem.Text = "Soluciones";
            this.solucionesToolStripMenuItem.Click += new System.EventHandler(this.solucionesToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sisveug.Properties.Resources._3t33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1103, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosEntreFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeServiciosPorTecnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solucionesToolStripMenuItem;
    }
}