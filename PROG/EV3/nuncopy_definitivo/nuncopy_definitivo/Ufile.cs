using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuncopy_definitivo
{
    public class Ufile
    {
        private string? _path;
        private string? _hash;
        private bool _disabled;
        private long _size;

        public string? Path
        {
            get => _path;
            set => _path = value;
        }

        public string? Hash
        {
            get => _hash;
            set => _hash = value;
        }

        public bool Disabled
        {
            get => _disabled;
            set => _disabled = value;
        }

        public long Size
        {
            get => _size;
            set => _size = value;
        }

    }
}
