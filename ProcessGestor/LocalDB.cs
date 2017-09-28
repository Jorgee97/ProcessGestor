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
            Console.WriteLine("Caling process");
            XDocument doc = XDocument.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
            XElement root = new XElement("Process");
            root.Add(new XAttribute("name", process.getProcessName()));
            root.Add(new XElement("PID", process.getProccessID()),
                    new XElement("Quantum", process.getQuantum()),
                    new XElement("TiempoLlegada", process.getTimeArrive()),
                    new XElement("TiempoFinalizacion", process.getTimeLeft()));
            doc.Element("UserProcess").Add(root);
            doc.Save(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
        }

        public static void InformSameTimeLeft()
        {
            XElement doc = XElement.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
            var select = from process in doc.Elements("Process") where process.Element("TiempoFinalizacion").Value == process.Element("TiempoFinalizacion").Value orderby process.Element("TiempoFinalizacion").Value ascending select process;

            foreach(var element in select)
            {
                Console.WriteLine("{0}", element.Element("TiempoFinalizacion").Value);
            }
        }

        public static List<dataToManage> listGreatDuration()
        {
            List<dataToManage> list = new List<dataToManage>();
            XElement doc = XElement.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
            var select = (from process in doc.Elements("Process") orderby process.Element("TiempoFinalizacion").Value descending select process).Take(5);

            foreach (var element in select)
            {
                list.Add(new dataToManage { nombreProcess=element.FirstAttribute.Value, tiempoFinalizacion=int.Parse(element.Element("TiempoFinalizacion").Value) });
            }

            return list;
        }


        public class dataToManage
        {
            public string nombreProcess { get; set; }
            public int tiempoFinalizacion { get; set; }
        }
    }
}
