using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BacklogData.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Image { get; set; }
        public int TotalGames { get; set; }
        public ObservableCollection<Game> Games { get; set; } = new ObservableCollection<Game>();

        public User()
        {
            
        }
    }
}
