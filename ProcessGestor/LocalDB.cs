using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProcessGestor
{
    class LocalDB
    {
        public static List<Process> listProcess = new List<Process>();
        public static Queue<Process> queue = new Queue<Process>();
        public static Queue<Thread> queueThread = new Queue<Thread>();
        public static int lastTimeArrive;

        public static List<Process> getListProcess()
        {
            return listProcess;
        }

        public static void SaveProcessXML(Process process)
        {
            XDocument doc = XDocument.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor\ProcessGestor\Resources\UserProcess.xml");
            XElement root = new XElement("Process");
            root.Add(new XAttribute("name", process.getProcessName()));
            root.Add(new XElement("PID", process.getProccessID()),
                    new XElement("Quantum", process.getQuantum()),
                    new XElement("TiempoLlegada", process.getTimeArrive()),
                    new XElement("TiempoFinalizacion", process.getTimeLeft()));
            doc.Element("UserProcess").Add(root);
            doc.Save(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor\ProcessGestor\Resources\UserProcess.xml");
        }

        public static void InformSameTimeLeft()
        {
            XElement doc = XElement.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor\ProcessGestor\Resources\UserProcess.xml");
            var select = from process in doc.Elements("Process") where process.Element("TiempoFinalizacion").Value == "400" select process;

            foreach(var element in select)
            {
                Console.WriteLine("{0}", element);
            }
        }
    }
}
