using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuncopy_definitivo
{
    public class FileReader
    {
        public static bool CompareFiles(Ufile file1, Ufile file2)
        {
            if (file1.Size != file2.Size && file1.Hash != file2.Hash)
            {
                return false;
            }
            return true;
        }
    }
}
