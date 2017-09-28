using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcessGestor
{
    public partial class MenorDuracion : Form
    {
        public MenorDuracion()
        {
            InitializeComponent();
        }

        private void MenorDuracion_Load(object sender, EventArgs e)
        {
            List<LocalDB.dataToManage> list = new List<LocalDB.dataToManage>();
            list = LocalDB.listLessDuration();

            int[] tiempo = new int[5];
            string[] title = new string[5];

            for (short i = 0; i < list.Count; i++)
            {
                tiempo[i] = list[i].tiempoFinalizacion;
                title[i] = list[i].nombreProcess;
            }

            Chart chart1 = new Chart
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Add(chart1);
            chart1.ChartAreas.Add(new ChartArea("MainArea"));
            Series series = new Series("Menor uso de CPU");
            chart1.Series.Add(series);

            series.Points.DataBindXY(title, "Proceso", tiempo, "TiempoFinalizacion");
        }
    }
}
