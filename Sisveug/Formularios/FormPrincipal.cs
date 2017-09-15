using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sisveug.FormOperaciones;
using Sisveug.Reportes;

namespace Sisveug.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes abrir = new FormClientes();
            abrir.ShowDialog();
        }

        private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTecnicos abrir = new FormTecnicos();
            abrir.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarcas abrir = new FormMarcas();
            abrir.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorias abrir = new FormCategorias();
            abrir.ShowDialog();
        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiagnostico abrir = new FormDiagnostico();
            abrir.ShowDialog();
        }

        private void piezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPiezas abrir = new FormPiezas();
            abrir.ShowDialog();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEquipos abrir = new FormEquipos();
            abrir.ShowDialog();
        }

        private void ingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServicio Abrircervicio = new FormServicio();
            Abrircervicio.ShowDialog();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void serviciosEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaGeneral llamarform = new FormConsultaGeneral();
            llamarform.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactura llamarform = new FormFactura();
            llamarform.ShowDialog();
        }

        private void cantidadDeServiciosPorTecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServiciosXTecnicos llamarform = new FormServiciosXTecnicos();
            llamarform.ShowDialog();

        }

        private void solucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSoluciones llamarForm = new FormSoluciones();
            llamarForm.ShowDialog();
        }
    }
}
