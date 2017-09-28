using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessGestor
{
    public partial class Listados : Form
    {
        public Listados()
        {
            InitializeComponent();
        }

        private void Listados_Load(object sender, EventArgs e)
        {
            switch (LocalDB.ToQuery)
            {
                case 1:
                    List<LocalDB.ProcessData> list = new List<LocalDB.ProcessData>();
                    list = LocalDB.listWholeUserProcess();

                    foreach (var element in list)
                    {
                        dataGridView1.Rows.Add(element.PID, element.processName, element.timeArrive, element.timeLeft, element.quantum);
                    }
                    break;
                case 2:
                    List<LocalDB.ProcessData> list2 = new List<LocalDB.ProcessData>();
                    list2 = LocalDB.listFiveLessDuration();

                    foreach (var element in list2)
                    {
                        dataGridView1.Rows.Add(element.PID, element.processName, element.timeArrive, element.timeLeft, element.quantum);
                    }
                    break;
                case 3:
                    List<LocalDB.ProcessData> list3 = new List<LocalDB.ProcessData>();
                    list3 = LocalDB.listWholeDuration();

                    foreach (var element in list3)
                    {
                        dataGridView1.Rows.Add(element.PID, element.processName, element.timeArrive, element.timeLeft, element.quantum);
                    }
                    break;
                case 4:
                    List<LocalDB.ProcessData> list4 = new List<LocalDB.ProcessData>();
                    list4 = LocalDB.listEqualDuration();

                    foreach (var element in list4)
                    {
                        dataGridView1.Rows.Add(element.PID, element.processName, element.timeArrive, element.timeLeft, element.quantum);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
