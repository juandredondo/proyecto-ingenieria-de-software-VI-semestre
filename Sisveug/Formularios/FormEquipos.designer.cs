namespace Sisveug.Formularios
{
    partial class FormEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipos));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtserie = new System.Windows.Forms.TextBox();
            this.Txtidequipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtnombreequipo = new System.Windows.Forms.TextBox();
            this.Drglistaequipo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistaequipo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(23, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 43);
            this.button1.TabIndex = 86;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(23, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 39);
            this.button2.TabIndex = 85;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(23, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 34);
            this.button5.TabIndex = 82;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnguardar.FlatAppearance.BorderSize = 2;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(23, 152);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(41, 36);
            this.btnguardar.TabIndex = 81;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button6_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(83, 432);
            this.PictureBox2.TabIndex = 80;
            this.PictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txtserie);
            this.groupBox1.Controls.Add(this.Txtidequipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txtnombreequipo);
            this.groupBox1.Location = new System.Drawing.Point(129, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 138);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del equipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial:";
            // 
            // Txtserie
            // 
            this.Txtserie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtserie.Location = new System.Drawing.Point(123, 88);
            this.Txtserie.MaxLength = 45;
            this.Txtserie.Name = "Txtserie";
            this.Txtserie.Size = new System.Drawing.Size(181, 20);
            this.Txtserie.TabIndex = 8;
            // 
            // Txtidequipo
            // 
            this.Txtidequipo.Location = new System.Drawing.Point(123, 18);
            this.Txtidequipo.Name = "Txtidequipo";
            this.Txtidequipo.Size = new System.Drawing.Size(181, 20);
            this.Txtidequipo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IdEquipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre De Equipo:";
            // 
            // Txtnombreequipo
            // 
            this.Txtnombreequipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombreequipo.Location = new System.Drawing.Point(123, 57);
            this.Txtnombreequipo.MaxLength = 45;
            this.Txtnombreequipo.Name = "Txtnombreequipo";
            this.Txtnombreequipo.Size = new System.Drawing.Size(181, 20);
            this.Txtnombreequipo.TabIndex = 2;
            // 
            // Drglistaequipo
            // 
            this.Drglistaequipo.AllowUserToAddRows = false;
            this.Drglistaequipo.AllowUserToDeleteRows = false;
            this.Drglistaequipo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drglistaequipo.ContextMenuStrip = this.contextMenuStrip1;
            this.Drglistaequipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drglistaequipo.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Drglistaequipo.Location = new System.Drawing.Point(38, 26);
            this.Drglistaequipo.MultiSelect = false;
            this.Drglistaequipo.Name = "Drglistaequipo";
            this.Drglistaequipo.ReadOnly = true;
            this.Drglistaequipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Drglistaequipo.Size = new System.Drawing.Size(398, 163);
            this.Drglistaequipo.TabIndex = 48;
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
            this.groupBox2.Controls.Add(this.Drglistaequipo);
            this.groupBox2.Location = new System.Drawing.Point(461, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 208);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnosticos Ingresados";
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.Location = new System.Drawing.Point(647, 150);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(120, 20);
            this.Txtbuscar.TabIndex = 85;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 84;
            this.label1.Text = "Equipos";
            // 
            // FormEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sisveug.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1025, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormEquipos";
            this.Text = "FormEquipos";
            this.Load += new System.EventHandler(this.FormEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistaequipo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button btnguardar;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtserie;
        private System.Windows.Forms.TextBox Txtidequipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtnombreequipo;
        internal System.Windows.Forms.DataGridView Drglistaequipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}