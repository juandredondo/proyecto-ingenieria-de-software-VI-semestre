namespace Sisveug.Formularios
{
    partial class FormMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarcas));
            this.label1 = new System.Windows.Forms.Label();
            this.Drglistamarcas = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txtidmarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtnombremarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistamarcas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Marcas";
            // 
            // Drglistamarcas
            // 
            this.Drglistamarcas.AllowUserToAddRows = false;
            this.Drglistamarcas.AllowUserToDeleteRows = false;
            this.Drglistamarcas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drglistamarcas.ContextMenuStrip = this.contextMenuStrip1;
            this.Drglistamarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drglistamarcas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Drglistamarcas.Location = new System.Drawing.Point(77, 19);
            this.Drglistamarcas.MultiSelect = false;
            this.Drglistamarcas.Name = "Drglistamarcas";
            this.Drglistamarcas.ReadOnly = true;
            this.Drglistamarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Drglistamarcas.Size = new System.Drawing.Size(343, 154);
            this.Drglistamarcas.TabIndex = 48;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Drglistamarcas);
            this.groupBox2.Location = new System.Drawing.Point(448, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 195);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marcas Ingresadas ";
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.Location = new System.Drawing.Point(631, 134);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(120, 20);
            this.Txtbuscar.TabIndex = 58;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalirBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SalirBtn.FlatAppearance.BorderSize = 2;
            this.SalirBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalirBtn.Image")));
            this.SalirBtn.Location = new System.Drawing.Point(-175, 278);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(41, 43);
            this.SalirBtn.TabIndex = 54;
            this.SalirBtn.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(-175, 241);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(41, 39);
            this.BtnCancelar.TabIndex = 53;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnNuevo.FlatAppearance.BorderSize = 2;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(-175, 96);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(41, 37);
            this.BtnNuevo.TabIndex = 52;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEliminar.FlatAppearance.BorderSize = 2;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(-175, 168);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(41, 37);
            this.BtnEliminar.TabIndex = 51;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEditar.FlatAppearance.BorderSize = 2;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(-175, 133);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(41, 34);
            this.BtnEditar.TabIndex = 50;
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGuardar.FlatAppearance.BorderSize = 2;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(-175, 205);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(41, 36);
            this.BtnGuardar.TabIndex = 49;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(22, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 43);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(22, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 39);
            this.button2.TabIndex = 64;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(22, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 34);
            this.button5.TabIndex = 61;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(22, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 36);
            this.button6.TabIndex = 60;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(83, 399);
            this.PictureBox2.TabIndex = 66;
            this.PictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Txtidmarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txtnombremarca);
            this.groupBox1.Location = new System.Drawing.Point(136, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 101);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la marca";
            // 
            // Txtidmarca
            // 
            this.Txtidmarca.Enabled = false;
            this.Txtidmarca.Location = new System.Drawing.Point(101, 19);
            this.Txtidmarca.Name = "Txtidmarca";
            this.Txtidmarca.Size = new System.Drawing.Size(181, 20);
            this.Txtidmarca.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IdMarca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // Txtnombremarca
            // 
            this.Txtnombremarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombremarca.Location = new System.Drawing.Point(101, 57);
            this.Txtnombremarca.MaxLength = 45;
            this.Txtnombremarca.Name = "Txtnombremarca";
            this.Txtnombremarca.Size = new System.Drawing.Size(181, 20);
            this.Txtnombremarca.TabIndex = 2;
            // 
            // FormMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sisveug.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1030, 399);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.PictureBox2);
            this.Name = "FormMarcas";
            this.Text = "FormMarcas";
            this.Load += new System.EventHandler(this.FormMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Drglistamarcas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView Drglistamarcas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txtbuscar;
        internal System.Windows.Forms.Button SalirBtn;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Button BtnNuevo;
        internal System.Windows.Forms.Button BtnEliminar;
        internal System.Windows.Forms.Button BtnEditar;
        internal System.Windows.Forms.Button BtnGuardar;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtidmarca;
        public System.Windows.Forms.TextBox Txtnombremarca;
    }
}