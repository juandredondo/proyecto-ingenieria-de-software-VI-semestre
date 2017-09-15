namespace Sisveug.Formularios
{
    partial class FormDiagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiagnostico));
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtiddiagnostico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtnombrediagnostico = new System.Windows.Forms.TextBox();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Drglistadiagnosticos = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistadiagnosticos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(83, 410);
            this.PictureBox2.TabIndex = 68;
            this.PictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(21, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 43);
            this.button1.TabIndex = 79;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(21, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 39);
            this.button2.TabIndex = 78;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(21, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 34);
            this.button5.TabIndex = 75;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnguardar.FlatAppearance.BorderSize = 2;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(21, 138);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(41, 36);
            this.btnguardar.TabIndex = 74;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 80;
            this.label1.Text = "Diagnosticos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txtiddiagnostico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txtnombrediagnostico);
            this.groupBox1.Location = new System.Drawing.Point(147, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 239);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del diagnostico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion:";
            // 
            // Txtiddiagnostico
            // 
            this.Txtiddiagnostico.Enabled = false;
            this.Txtiddiagnostico.Location = new System.Drawing.Point(101, 19);
            this.Txtiddiagnostico.Name = "Txtiddiagnostico";
            this.Txtiddiagnostico.Size = new System.Drawing.Size(206, 20);
            this.Txtiddiagnostico.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IdDiagnostico";
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
            // Txtnombrediagnostico
            // 
            this.Txtnombrediagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtnombrediagnostico.Location = new System.Drawing.Point(101, 60);
            this.Txtnombrediagnostico.MaxLength = 50;
            this.Txtnombrediagnostico.Name = "Txtnombrediagnostico";
            this.Txtnombrediagnostico.Size = new System.Drawing.Size(206, 20);
            this.Txtnombrediagnostico.TabIndex = 2;
            this.Txtnombrediagnostico.TextChanged += new System.EventHandler(this.Txtnombrediagnostico_TextChanged);
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.Location = new System.Drawing.Point(643, 119);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(120, 20);
            this.Txtbuscar.TabIndex = 83;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Drglistadiagnosticos);
            this.groupBox2.Location = new System.Drawing.Point(479, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 195);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnosticos Ingresados";
            // 
            // Drglistadiagnosticos
            // 
            this.Drglistadiagnosticos.AllowUserToAddRows = false;
            this.Drglistadiagnosticos.AllowUserToDeleteRows = false;
            this.Drglistadiagnosticos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drglistadiagnosticos.ContextMenuStrip = this.contextMenuStrip1;
            this.Drglistadiagnosticos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drglistadiagnosticos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Drglistadiagnosticos.Location = new System.Drawing.Point(77, 19);
            this.Drglistadiagnosticos.MultiSelect = false;
            this.Drglistadiagnosticos.Name = "Drglistadiagnosticos";
            this.Drglistadiagnosticos.ReadOnly = true;
            this.Drglistadiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Drglistadiagnosticos.Size = new System.Drawing.Size(343, 154);
            this.Drglistadiagnosticos.TabIndex = 48;
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 122);
            this.richTextBox1.MaxLength = 98;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 111);
            this.richTextBox1.TabIndex = 84;
            this.richTextBox1.Text = "";
            // 
            // FormDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sisveug.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1071, 410);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.PictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FormDiagnostico";
            this.Text = "FormDiagnostico";
            this.Load += new System.EventHandler(this.FormDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Drglistadiagnosticos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtiddiagnostico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtnombrediagnostico;
        private System.Windows.Forms.TextBox Txtbuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView Drglistadiagnosticos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}