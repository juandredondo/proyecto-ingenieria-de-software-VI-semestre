namespace Sisveug.Formularios
{
    partial class FormPiezas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPiezas));
            this.label10 = new System.Windows.Forms.Label();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Drglistamarca = new System.Windows.Forms.DataGridView();
            this.Drglistacategorias = new System.Windows.Forms.DataGridView();
            this.Drglistapiezas = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txtmarca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txtcategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txtvunitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtcantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtidpiezas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtreferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistamarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistacategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistapiezas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 27);
            this.label10.TabIndex = 45;
            this.label10.Text = "PIEZAS";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnBuscarCliente.FlatAppearance.BorderSize = 2;
            this.BtnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarCliente.Image")));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(404, 240);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(31, 29);
            this.BtnBuscarCliente.TabIndex = 10;
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Drglistamarca);
            this.groupBox5.Controls.Add(this.Drglistacategorias);
            this.groupBox5.Controls.Add(this.Drglistapiezas);
            this.groupBox5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox5.Location = new System.Drawing.Point(463, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(503, 257);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos";
            // 
            // Drglistamarca
            // 
            this.Drglistamarca.AllowUserToAddRows = false;
            this.Drglistamarca.AllowUserToDeleteRows = false;
            this.Drglistamarca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drglistamarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drglistamarca.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Drglistamarca.Location = new System.Drawing.Point(6, 24);
            this.Drglistamarca.MultiSelect = false;
            this.Drglistamarca.Name = "Drglistamarca";
            this.Drglistamarca.ReadOnly = true;
            this.Drglistamarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Drglistamarca.Size = new System.Drawing.Size(487, 231);
            this.Drglistamarca.TabIndex = 40;
            this.Drglistamarca.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Drglistamarca_CellMouseDoubleClick);
            this.Drglistamarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Drglistamarca_CellContentClick);
            // 
            // Drglistacategorias
            // 
            this.Drglistacategorias.AllowUserToAddRows = false;
            this.Drglistacategorias.AllowUserToDeleteRows = false;
            this.Drglistacategorias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drglistacategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drglistacategorias.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Drglistacategorias.Location = new System.Drawing.Point(6, 24);
            this.Drglistacategorias.MultiSelect = false;
            this.Drglistacategorias.Name = "Drglistacategorias";
            this.Drglistacategorias.ReadOnly = true;
            this.Drglistacategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Drglistacategorias.Size = new System.Drawing.Size(487, 231);
            this.Drglistacategorias.TabIndex = 39;
            this.Drglistacategorias.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Drglistacategorias_CellMouseDoubleClick);
            // 
            // Drglistapiezas
            // 
            this.Drglistapiezas.AllowUserToAddRows = false;
            this.Drglistapiezas.AllowUserToDeleteRows = false;
            this.Drglistapiezas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drglistapiezas.ContextMenuStrip = this.contextMenuStrip1;
            this.Drglistapiezas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drglistapiezas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Drglistapiezas.Location = new System.Drawing.Point(10, 24);
            this.Drglistapiezas.MultiSelect = false;
            this.Drglistapiezas.Name = "Drglistapiezas";
            this.Drglistapiezas.ReadOnly = true;
            this.Drglistapiezas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Drglistapiezas.Size = new System.Drawing.Size(483, 227);
            this.Drglistapiezas.TabIndex = 38;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txtmarca);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Txtcategoria);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Txtvunitario);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Txtcantidad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Txtidpiezas);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Txtreferencia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(18, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 251);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información De Las Piezas";
            // 
            // Txtmarca
            // 
            this.Txtmarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtmarca.Enabled = false;
            this.Txtmarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtmarca.Location = new System.Drawing.Point(127, 187);
            this.Txtmarca.Name = "Txtmarca";
            this.Txtmarca.Size = new System.Drawing.Size(236, 22);
            this.Txtmarca.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Id Marca:";
            // 
            // Txtcategoria
            // 
            this.Txtcategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtcategoria.Enabled = false;
            this.Txtcategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcategoria.Location = new System.Drawing.Point(127, 156);
            this.Txtcategoria.Name = "Txtcategoria";
            this.Txtcategoria.Size = new System.Drawing.Size(236, 22);
            this.Txtcategoria.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Id Categoria:";
            // 
            // Txtvunitario
            // 
            this.Txtvunitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtvunitario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtvunitario.Location = new System.Drawing.Point(127, 124);
            this.Txtvunitario.Name = "Txtvunitario";
            this.Txtvunitario.Size = new System.Drawing.Size(236, 22);
            this.Txtvunitario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor Unitario:";
            // 
            // Txtcantidad
            // 
            this.Txtcantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtcantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcantidad.Location = new System.Drawing.Point(128, 89);
            this.Txtcantidad.Name = "Txtcantidad";
            this.Txtcantidad.Size = new System.Drawing.Size(236, 22);
            this.Txtcantidad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad:";
            // 
            // Txtidpiezas
            // 
            this.Txtidpiezas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtidpiezas.Enabled = false;
            this.Txtidpiezas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtidpiezas.Location = new System.Drawing.Point(127, 27);
            this.Txtidpiezas.Name = "Txtidpiezas";
            this.Txtidpiezas.Size = new System.Drawing.Size(236, 22);
            this.Txtidpiezas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id Pieza :";
            // 
            // Txtreferencia
            // 
            this.Txtreferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtreferencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtreferencia.Location = new System.Drawing.Point(127, 56);
            this.Txtreferencia.Name = "Txtreferencia";
            this.Txtreferencia.Size = new System.Drawing.Size(236, 22);
            this.Txtreferencia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Referencia:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelarBtn.FlatAppearance.BorderSize = 2;
            this.CancelarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelarBtn.Image")));
            this.CancelarBtn.Location = new System.Drawing.Point(451, 387);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(40, 43);
            this.CancelarBtn.TabIndex = 57;
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GuardarBtn.FlatAppearance.BorderSize = 2;
            this.GuardarBtn.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBtn.Image")));
            this.GuardarBtn.Location = new System.Drawing.Point(360, 387);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(40, 43);
            this.GuardarBtn.TabIndex = 58;
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalirBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SalirBtn.FlatAppearance.BorderSize = 2;
            this.SalirBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalirBtn.Image")));
            this.SalirBtn.Location = new System.Drawing.Point(503, 387);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(40, 43);
            this.SalirBtn.TabIndex = 59;
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(404, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 29);
            this.button4.TabIndex = 62;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(403, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 43);
            this.button5.TabIndex = 64;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbuscar.Location = new System.Drawing.Point(636, 65);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(169, 20);
            this.Txtbuscar.TabIndex = 65;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(508, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Buscar:";
            // 
            // FormPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sisveug.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1037, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox5);
            this.Name = "FormPiezas";
            this.Text = "FormPiezas";
            this.Load += new System.EventHandler(this.FormPiezas_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPiezas_FormClosing);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Drglistamarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistacategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistapiezas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button BtnBuscarCliente;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox Txtvunitario;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox Txtcantidad;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox Txtidpiezas;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox Txtreferencia;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button CancelarBtn;
        internal System.Windows.Forms.Button GuardarBtn;
        internal System.Windows.Forms.Button SalirBtn;
        internal System.Windows.Forms.DataGridView Drglistapiezas;
        internal System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox Txtmarca;
        public System.Windows.Forms.TextBox Txtcategoria;
        internal System.Windows.Forms.DataGridView Drglistamarca;
        internal System.Windows.Forms.DataGridView Drglistacategorias;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        internal System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Txtbuscar;
        private System.Windows.Forms.Label label1;
    }
}