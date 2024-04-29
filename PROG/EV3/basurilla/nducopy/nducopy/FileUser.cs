using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nducopy
{
    public class FileUser
    {
        public string? Path { get; set; }
        public string? Hash { get; set; }
        public bool Disabled { get; set; }
        public long Size { get; set; }
        public string Name { get; set; }
        //public bool IsDuplicate { get; set; }

        public FileUser(string path)
        {
            Path = path;
            Name = System.IO.Path.GetFileName(path);
            Size = 0;
            Disabled = false;
            Hash = null;
            //IsDuplicate = false;
        }
    }
}
