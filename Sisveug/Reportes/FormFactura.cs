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
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string fechainicial = txtIdServicio.Text;

            ReporteFactura report = new ReporteFactura();
            report.SetDatabaseLogon("root", "123456", "localhost", "sistemav");

            ParameterValues valor1 = new ParameterValues();




            ParameterDiscreteValue fechai = new ParameterDiscreteValue();


            fechai.Value = fechainicial;


            valor1.Add(fechai);


            report.DataDefinition.ParameterFields["idservicio"].ApplyCurrentValues(valor1);

            this.crystalReportViewer1.ReportSource = report;
        }
    }
}
