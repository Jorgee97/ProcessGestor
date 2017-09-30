using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ProcessGestor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPID.Text != "" && txtNameProcess.Text != "" && txtTLlegada.Text != "")
            {
                Process process = new Process(int.Parse(txtPID.Text), float.Parse(txtTLlegada.Text), txtNameProcess.Text, "Listo");
                LocalDB.listProcess.Add(process);

                LocalDB.queue.Enqueue(process);

                dataGridView1.Rows.Add(process.getProccessID(), process.getProcessName(), process.getTimeArrive(), process.getQuantum(), process.getState());
                process.setRowIndex(dataGridView1.Rows.Count - 1);

                txtNameProcess.Text = "";
                txtTLlegada.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PeekChangeState()
        {
            if (LocalDB.queue.Count > 0)
            {
                Process process = LocalDB.queue.Peek();

                process.setState("Ejecutando");
                Console.WriteLine("Peeking {0}", process.getProcessName());
            }
            Console.WriteLine("Exiting peek...");
        }

        private void RoundRobin()
        {
            /* Having in mind that round robin's uses FIFO standard i'm gonna follow that on my next code */
            while (LocalDB.queue.Count != 0)
            {
                PeekChangeState();
                Process process = LocalDB.queue.Dequeue();
                Thread workingProcess = LocalDB.queueThread.Dequeue();
                Console.WriteLine("{0}", process.getState());
                if (workingProcess.Name == process.getProcessName() && process.isDone() == false)
                {
                    Thread.Sleep(1000);
                    dataGridView1.Rows[process.getRowIndex()].Cells[4].Value = process.getState();
                    workingProcess.Start();
 
                    // Timer for set the value of process state to "Terminado"
                    System.Threading.Timer timer = new System.Threading.Timer((object state) => { dataGridView1.Rows[process.getRowIndex()].Cells[4].Value = "Terminado"; }, null, (int)process.getQuantum() * 1000, Timeout.Infinite);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (LocalDB.queue.Count > 0)
                RoundRobin();
            else
                MessageBox.Show("No hay procesos pendientes, por favor añada uno.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void procesosConMayorDuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MayorDuracion();
            form.Show();
        }

        private void procesosConMenorDuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MenorDuracion();
            form.Show();
        }

        private void procesosCreadosPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDB.ToQuery = 1;
            Form form = new Listados();
            form.Show();
        }

        private void cincoMenoresTiemposDeDuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDB.ToQuery = 2;
            Form form = new Listados();
            form.Show();
        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDB.ToQuery = 3;
            Form form = new Listados();
            form.Show();
        }

        private void igualDuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDB.ToQuery = 4;
            Form form = new Listados();
            form.Show();
        }

        private void txtPID_Enter(object sender, EventArgs e)
        {
            Random random = new Random();
            txtPID.Text = random.Next(1, 20).ToString();
        }
    }
}
