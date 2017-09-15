using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sisveug.Reportes;

using MySql.Data;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace Sisveug.Reportes
{
    public partial class FormConsultaGeneral : Form
    {
        public FormConsultaGeneral()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //esto va en el boton generar

            string fechainicial = txtFecha1.Value.Year + "/" + txtFecha1.Value.Month + "/" + txtFecha1.Value.Day;
            string fechafinal = txtFecha2.Value.Year + "/" + txtFecha2.Value.Month + "/" + txtFecha2.Value.Day;
            ReporteConsultaGeneral report = new ReporteConsultaGeneral();
            report.SetDatabaseLogon("root", "123456", "localhost", "sistemav");

            ParameterValues valor1 = new ParameterValues();
            ParameterValues valor2 = new ParameterValues();



            ParameterDiscreteValue fechai = new ParameterDiscreteValue();
            ParameterDiscreteValue fechaf = new ParameterDiscreteValue();

            fechai.Value = fechainicial;
            fechaf.Value = fechafinal;

            valor1.Add(fechai);
            valor2.Add(fechaf);

            report.DataDefinition.ParameterFields["fechaInicial"].ApplyCurrentValues(valor1);
            report.DataDefinition.ParameterFields["fechaFinal"].ApplyCurrentValues(valor2);
            this.crystalReportViewer1.ReportSource = report;
        }
    }
}
