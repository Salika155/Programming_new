using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nducopy
{
    public class FileUser
    {
        public string Path { get; set; }
        public string Hash { get; set; }
        public bool Disabled { get; set; }
        public long Size { get; set; }
    }
}
