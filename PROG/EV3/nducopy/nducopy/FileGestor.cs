using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nducopy
{
    public class FileGestor
    {
        public string[] ReadFile(string path)
        {
            //esto podria hacerlo con un contains para hacerlo yo mas manual
            if (!File.Exists(path))
                return null;

            List<string> lines = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (true)
                    {
                        string? s = sr.ReadLine();
                        if (s != null)
                            lines.Add(s);
                        break;
                    }
                    sr.Close();
                    return lines.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
