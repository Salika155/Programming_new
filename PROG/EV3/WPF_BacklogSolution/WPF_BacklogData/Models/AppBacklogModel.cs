using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BacklogData.Models
{
    public class AppBacklogModel
    {
        private static AppBacklogModel _app = new AppBacklogModel();
        public static AppBacklogModel Instance => _app;

        //public DatabaseRam Database => DatabaseRam.Instance;
        public DatabaseSQL databaseBBDD => DatabaseSQL.Instance;

        private AppBacklogModel()
        {
        }
    }
}
