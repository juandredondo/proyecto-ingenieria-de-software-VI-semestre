namespace Sisveug.Formularios
{
    partial class FormSoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoluciones));
            this.label1 = new System.Windows.Forms.Label();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txtidpiezas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DrgSoluciones = new System.Windows.Forms.DataGridView();
            this.Drglistacategorias = new System.Windows.Forms.DataGridView();
            this.Drglistapiezas = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrgSoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistacategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistapiezas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(518, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "Buscar:";
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbuscar.Location = new System.Drawing.Point(646, 100);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(169, 20);
            this.Txtbuscar.TabIndex = 76;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(413, 422);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 43);
            this.button5.TabIndex = 75;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelarBtn.FlatAppearance.BorderSize = 2;
            this.CancelarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelarBtn.Image")));
            this.CancelarBtn.Location = new System.Drawing.Point(461, 422);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(40, 43);
            this.CancelarBtn.TabIndex = 71;
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GuardarBtn.FlatAppearance.BorderSize = 2;
            this.GuardarBtn.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBtn.Image")));
            this.GuardarBtn.Location = new System.Drawing.Point(370, 422);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(40, 43);
            this.GuardarBtn.TabIndex = 72;
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalirBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SalirBtn.FlatAppearance.BorderSize = 2;
            this.SalirBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalirBtn.Image")));
            this.SalirBtn.Location = new System.Drawing.Point(513, 422);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(40, 43);
            this.SalirBtn.TabIndex = 73;
            this.SalirBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txtidpiezas);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtReferencia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(28, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 97);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            // 
            // Txtidpiezas
            // 
            this.Txtidpiezas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            // txtReferencia
            // 
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(127, 56);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(236, 22);
            this.txtReferencia.TabIndex = 5;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(402, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 27);
            this.label10.TabIndex = 68;
            this.label10.Text = "Soluciones";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DrgSoluciones);
            this.groupBox5.Controls.Add(this.Drglistacategorias);
            this.groupBox5.Controls.Add(this.Drglistapiezas);
            this.groupBox5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox5.Location = new System.Drawing.Point(473, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(503, 257);
            this.groupBox5.TabIndex = 69;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos";
            // 
            // DrgSoluciones
            // 
            this.DrgSoluciones.AllowUserToAddRows = false;
            this.DrgSoluciones.AllowUserToDeleteRows = false;
            this.DrgSoluciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DrgSoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrgSoluciones.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DrgSoluciones.Location = new System.Drawing.Point(6, 24);
            this.DrgSoluciones.MultiSelect = false;
            this.DrgSoluciones.Name = "DrgSoluciones";
            this.DrgSoluciones.ReadOnly = true;
            this.DrgSoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DrgSoluciones.Size = new System.Drawing.Size(487, 231);
            this.DrgSoluciones.TabIndex = 40;
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
            // 
            // Drglistapiezas
            // 
            this.Drglistapiezas.AllowUserToAddRows = false;
            this.Drglistapiezas.AllowUserToDeleteRows = false;
            this.Drglistapiezas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // FormSoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox5);
            this.Name = "FormSoluciones";
            this.Text = "FormSoluciones";
            this.Load += new System.EventHandler(this.FormSoluciones_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrgSoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistacategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drglistapiezas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtbuscar;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button CancelarBtn;
        internal System.Windows.Forms.Button GuardarBtn;
        internal System.Windows.Forms.Button SalirBtn;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox Txtidpiezas;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtReferencia;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.DataGridView DrgSoluciones;
        internal System.Windows.Forms.DataGridView Drglistacategorias;
        internal System.Windows.Forms.DataGridView Drglistapiezas;
    }
}