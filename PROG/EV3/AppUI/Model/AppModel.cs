using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AppModel
    {
        private static AppModel _app = new AppModel();
        public static AppModel Instance => _app;

        public Database Database => Database.Instance;

        private AppModel()
        {
        }

        
    }
}
