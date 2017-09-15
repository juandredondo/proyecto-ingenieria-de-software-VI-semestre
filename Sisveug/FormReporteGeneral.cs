using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
namespace Sisveug
{
    public partial class FormReporteGeneral : Form
    {
        public FormReporteGeneral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fechainicial = dateFecha1.Value.Year + "/" + dateFecha1.Value.Month + "/" + dateFecha1.Value.Day;
            string fechafinal = dateFecha2.Value.Year + "/" + dateFecha2.Value.Month + "/" + dateFecha2.Value.Day;
            ReporteGeneral report = new ReporteGeneral();
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
