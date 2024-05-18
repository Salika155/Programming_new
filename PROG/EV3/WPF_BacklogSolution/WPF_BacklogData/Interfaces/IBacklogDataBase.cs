using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_BacklogData.Models;

namespace WPF_BacklogData.Interfaces
{
    public interface IBacklogDataBase
    {
        void AddUser(string name, string email, string password);
        User GetUser(string email, string password);
        void AddGame(Game game);
        List<Game> GetGamesByUser(int userId);
        void RemoveGame(long id);
    }
}
