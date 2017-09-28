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
        public static int ToQuery;

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

        public static List<dataToManage> listGreatDuration()
        {
            List<dataToManage> list = new List<dataToManage>();
            XElement doc = XElement.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
            var select = (from process in doc.Elements("Process") orderby process.Element("TiempoFinalizacion").Value descending select process).Take(5);

            foreach (var element in select)
            {
                list.Add(new dataToManage { nombreProcess = element.FirstAttribute.Value, tiempoFinalizacion = int.Parse(element.Element("TiempoFinalizacion").Value) });
            }

            return list;
        }

        public static List<dataToManage> listLessDuration()
        {
            List<dataToManage> list = new List<dataToManage>();
            XElement doc = XElement.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
            var select = (from process in doc.Elements("Process") orderby process.Element("TiempoFinalizacion").Value ascending select process).Take(5);

            foreach (var element in select)
            {
                list.Add(new dataToManage { nombreProcess = element.FirstAttribute.Value, tiempoFinalizacion = int.Parse(element.Element("TiempoFinalizacion").Value) });
            }

            return list;
        }

        public static List<ProcessData> listFiveLessDuration()
        {
            List<ProcessData> list = new List<ProcessData>();
            XElement doc = XElement.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
            var select = (from process in doc.Elements("Process") orderby process.Element("TiempoFinalizacion").Value ascending select process).Take(5);

            foreach (var element in select)
            {
                list.Add(new ProcessData
                {
                    PID = int.Parse(element.Element("PID").Value),
                    processName = element.FirstAttribute.Value,
                    quantum = int.Parse(element.Element("Quantum").Value),
                    timeArrive = int.Parse(element.Element("TiempoLlegada").Value),
                    timeLeft = int.Parse(element.Element("TiempoFinalizacion").Value)
                });
            }

            return list;
        }

        public static List<ProcessData> listWholeDuration()
        {
            List<ProcessData> list = new List<ProcessData>();
            XElement doc = XElement.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
            var select = from process in doc.Elements("Process") orderby process.Element("TiempoFinalizacion").Value ascending select process;

            foreach (var element in select)
            {
                list.Add(new ProcessData
                {
                    PID = int.Parse(element.Element("PID").Value),
                    processName = element.FirstAttribute.Value,
                    quantum = int.Parse(element.Element("Quantum").Value),
                    timeArrive = int.Parse(element.Element("TiempoLlegada").Value),
                    timeLeft = int.Parse(element.Element("TiempoFinalizacion").Value)
                });
            }

            return list;
        }

        public static List<ProcessData> listEqualDuration()
        {
            List<ProcessData> list = new List<ProcessData>();
            XElement doc = XElement.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
            //var select = from process in doc.Elements("Process") orderby process.Element("TiempoFinalizacion").Value ascending select process;
            var select = from process in doc.Elements("Process") group process by process.Element("TiempoFinalizacion").Value into g select new
                    {
                        timeLeft = g.Key,
                        timeCount = g.Count()
                    };                
            
            foreach (var item in select)
            {
                var query = from process in doc.Elements("Process") where process.Element("TiempoFinalizacion").Value == item.timeLeft && item.timeCount > 1 select process;

                foreach (var element in query)
                {
                    list.Add(new ProcessData
                    {
                        PID = int.Parse(element.Element("PID").Value),
                        processName = element.FirstAttribute.Value,
                        quantum = int.Parse(element.Element("Quantum").Value),
                        timeArrive = int.Parse(element.Element("TiempoLlegada").Value),
                        timeLeft = int.Parse(element.Element("TiempoFinalizacion").Value)
                    });
                }
            }

            return list;
        }
        
        public static List<ProcessData> listWholeUserProcess()
        {
            List<ProcessData> list = new List<ProcessData>();
            XElement doc = XElement.Load(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\UserProcess.xml");
            var select = from process in doc.Elements("Process") select process;

            foreach (var element in select)
            {
                list.Add(new ProcessData
                {
                    PID = int.Parse(element.Element("PID").Value),
                    processName = element.FirstAttribute.Value,
                    quantum = int.Parse(element.Element("Quantum").Value),
                    timeArrive = int.Parse(element.Element("TiempoLlegada").Value),
                    timeLeft = int.Parse(element.Element("TiempoFinalizacion").Value)
                });
            }

            return list;
        }

        public class ProcessData
        {
            public int PID { get; set; }
            public string processName { get; set; }
            public int timeArrive { get; set; }
            public int quantum { get; set; }
            public int timeLeft { get; set; }
        }

        public class dataToManage
        {
            public string nombreProcess { get; set; }
            public int tiempoFinalizacion { get; set; }
        }
    }
}
