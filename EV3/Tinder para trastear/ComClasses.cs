using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tinder;

namespace Tinder_para_trastear
{
    public class ComClasses
    {
        
        public class EchoResponse
        {
            public string message { get; set; }
        }

        public class GetAllUsersRequest
        {
            public string? filter { get; set; }
        }

        public class GetAllUsersResponse
        {
            public List<User>? users { get; set; }
        }
    }
}
