using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sisveug.Reportes;

using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;


namespace Sisveug.Reportes
{
    public partial class FormServiciosXTecnicos : Form
    {
        public FormServiciosXTecnicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fechainicial = txtFecha1.Value.Year + "/" + txtFecha1.Value.Month + "/" + txtFecha1.Value.Day;
            string fechafinal = txtFecha2.Value.Year + "/" + txtFecha2.Value.Month + "/" + txtFecha2.Value.Day;
            ReporteServiciosXtecnico report = new ReporteServiciosXtecnico();
            report.SetDatabaseLogon("root", "123456", "localhost", "sistemav");

            ParameterValues valor1 = new ParameterValues();
            ParameterValues valor2 = new ParameterValues();



            ParameterDiscreteValue fechai = new ParameterDiscreteValue();
            ParameterDiscreteValue fechaf = new ParameterDiscreteValue();

            fechai.Value = fechainicial;
            fechaf.Value = fechafinal;

            valor1.Add(fechai);
            valor2.Add(fechaf);

            report.DataDefinition.ParameterFields["fecha1"].ApplyCurrentValues(valor1);
            report.DataDefinition.ParameterFields["fecha2"].ApplyCurrentValues(valor2);
            this.crystalReportViewer1.ReportSource = report;

        }

        private void txtFecha2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
