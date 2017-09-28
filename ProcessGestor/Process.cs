using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessGestor
{
    class Process
    {
        private Thread thread;
        private FileManager fileManager = new FileManager();

        private int processID;
        private string processName;
        private float timeQuantum;
        private int timeArrive;
        private float timeLeft;
        private string state;
        private bool done = false;

        public bool isDone() { return done; }
        public string getState() { return state; }
        public void setState(string v) { state = v; }
        public void setTimeLeft(float v) { timeLeft = v; }
        public float getTimeLeft() { return timeLeft; }
        public int rowIndex;
        public void setRowIndex(int v) { rowIndex = v; }
        public int getRowIndex() { return rowIndex; }

        public Process (int processID, float quantum, string name, string state)
        {
            this.processID = processID;
            this.timeQuantum = quantum;
            this.processName = name;
            this.state = state;

            thread = new Thread(() => processCopyToFile(timeQuantum))
            {
                Name = name
            };

            LocalDB.queueThread.Enqueue(thread);
            setTimeArrive(LocalDB.queue);
        }

        public void processCopyToFile(float quantum)
        {
            Console.WriteLine("ID Proceso {0} Con nombre {1} Tiempo de llegada {2} Copiando informacion.", getProccessID(), getProcessName(), getTimeArrive());
            fileManager.CopyToFile(getProcessName(), quantum, this);
            done = true;
            thread.Abort();
        }

        public int getProccessID()
        {
            return processID;
        }

        public string getProcessName()
        {
            return processName;
        }

        public float getQuantum()
        {
            return timeQuantum;
        }

        public int getTimeArrive()
        {
            return timeArrive;
        }

        public void setTimeArrive(Queue<Process> queue)
        {
            if (queue.Count == 0)
            {
                timeArrive = 0;
                LocalDB.lastTimeArrive = timeArrive;
            }
            else
            {
                timeArrive = LocalDB.lastTimeArrive + 1;
                LocalDB.lastTimeArrive = timeArrive;
            }
        }
    }
}
