using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Tinder;


namespace Tinder_para_trastear
{
    public class ModelHTTP : IModel
    {
        private string _serverAdress;

        //private string_serverAdress = "http://localhost:1234";

        public void AddUser(string name, double age, string description, string photo, string genre, int rating)
        {
            var finalPath = _serverAdress + "/add_user";
        }
            
        public ObservableCollection<User> GetFilteredUsers(string nombre, int offset, int limit)
        {
            throw new NotImplementedException();
        }

        private Res PerformPOST<Req,Res>(String path, Req request) where Res : class
        {
            try
            {
                var finalPath = _serverAdress + path;
                using (HttpClient client = new HttpClient())
                {
                    var requestBodyString = JsonSerializer.Serialize(request);
                }
            }
        }


    }
}
