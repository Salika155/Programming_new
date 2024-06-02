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
        //void AddUser(string name, string email, string password);
        void AddUser(User user);
        User GetUserByID(int userID);
        void DeleteUser(int userId);
        void UpdateUser(User user, int id);


        //User GetUser(string email, string password);
        //void AddGame(Game game);
        void AddGame(Game game);
        List<Game> GetGamesByUserID(int userId);
        void RemoveGame(int id);
        void UpdateGame(Game game);

        //void AddUser(User user);
        //List<Game> GetGamesByUserId(int userId);
        //void DeleteGame(int gameId);

    }
}
