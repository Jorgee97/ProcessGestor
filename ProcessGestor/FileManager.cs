using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessGestor
{
    class FileManager
    {
        public void CopyToFile(string namefile, float time, Process process)
        {
            try
            {
                using (FileStream fsSource = new FileStream(@"C:\Users\Jorge\Documents\Lorem.txt", FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[(int)time * 1000];
                    int numBytesToRead = (int)time * 1000;
                    int numBytesRead = 0;

                    while (numBytesToRead > 0)
                    {
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }

                    numBytesToRead = bytes.Length;
                    process.setTimeLeft(numBytesToRead / 5);

                    using (FileStream fsNew = new FileStream(namefile + ".txt", FileMode.Create, FileAccess.Write))
                    {
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }

                    LocalDB.SaveProcessXML(process);
                }

            }
            catch (IOException e)
            {
                if (e.Source != null)
                    File.WriteAllText(@"C:\Users\Jorge\Documents\Visual Studio 2017\Projects\ProcessGestor - Copy\ProcessGestor\Resources\log.txt", e.ToString());
                throw;
            }
        }
    }
}
