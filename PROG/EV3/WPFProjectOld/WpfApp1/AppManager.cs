using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class AppManager
    {
        public static AppManager Instance { get; } = new AppManager();

        public void RunApp() 
        {

        }
        private AppManager() 
        { 
        }


    }
}
