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

                ltReady.Items.Add("PID: " + process.getProccessID() + " - Nombre: " + process.getProcessName() + " - Quantum: " + process.getQuantum());
                process.setRowIndex(ltReady.Items.Count - 1);

                LocalDB.SaveProcessXML(process);

                txtNameProcess.Text = "";
                txtTLlegada.Text = "";
                txtPID.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PeekChangeState()
        {
            ltWait.Items.Clear();
            ltWait.Update();
            if (LocalDB.queue.Count > 0)
            {
                Process process = LocalDB.queue.Peek();

                process.setState("Ejecutando");
                Console.WriteLine("Peeking {0}", process.getProcessName());

                for (int i = 1; i < LocalDB.queue.Count; i++)
                {
                    process = LocalDB.queue.ElementAt(i);

                    ltWait.Items.Add("PID: " + process.getProccessID() + " - Nombre: " + process.getProcessName() + " - Quantum: " + process.getQuantum());
                    ltWait.Update();
                    ltReady.Items.Clear();
                }
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

                if (workingProcess.Name == process.getProcessName() && process.isDone() == false)
                {
                    ltRunning.Items.Add("PID: " + process.getProccessID() + " - Nombre: " + process.getProcessName() + " - Quantum: " + process.getQuantum());
                    ltRunning.Update();

                    workingProcess.Start();

                    // Timer for set the value of process state to "Terminado"
                    Thread.Sleep((int)process.getQuantum() * 1000); // Simulando quantum
                    ltRunning.Items.Clear();
                    ltEnd.Items.Add("PID: " + process.getProccessID() + " - Nombre: " + process.getProcessName() + " - Quantum: " + process.getQuantum());
                    ltEnd.Update();
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


        private void txtNameProcess_Enter(object sender, EventArgs e)
        {
            txtPID.Text = LocalDB.NewPid().ToString();
        }

        private void loadXML_Click(object sender, EventArgs e)
        {
            try
            {
                List<LocalDB.ProcessData> list5 = new List<LocalDB.ProcessData>();
                list5 = LocalDB.listLoadXml();

                foreach (var element in list5)
                {
                    Process process = new Process(element.PID, element.quantum, element.processName, "Listo");
                    LocalDB.listProcess.Add(process);

                    LocalDB.queue.Enqueue(process);
                    ltReady.Items.Add("PID: " + process.getProccessID() + " - Nombre: " + process.getProcessName() + " - Quantum: " + process.getQuantum());
                    process.setRowIndex(ltReady.Items.Count - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
