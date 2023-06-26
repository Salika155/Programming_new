using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tinder;

namespace Tinder_para_trastear
{
    class AppData
    {
        Model m = new Model ();
        //aqui va el singleton

        public class Singleton
        {
            private static Singleton instance = null;
            public string mensaje = "";
            protected Singleton()
            {
                mensaje = "";
            }

            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                        instance = new Singleton();
                    return instance;
                }
            }
        }

        private AppData()
        {

        }

        public void LaunchServer()
        {
            if (_server == null)
            {
                var string = new ServerSettings();
                _server = new RestServer(settings).LogToConsole();
                _server.Start();
            }
        }
    }

}
