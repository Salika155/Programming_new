using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_BacklogData.Models;

namespace WPF_BacklogData.Models
{
    public class AppBacklogModel
    {
        #region SINGLETON
        private static AppBacklogModel _app = new AppBacklogModel();
        public static AppBacklogModel Instance => _app;

        //public DatabaseRam Database => DatabaseRam.Instance;
        public DatabaseSQL databaseBBDD => DatabaseSQL.Instance;
        #endregion
        //private static AppBacklogModel _instance;


        public AppBacklogModel()
        {

        }

        ////Updates selected user
        //public void UpdateSelectedUser(int id)
        //{
        //    try
        //    {
        //        User u = GetUserById(id);
        //        SelectedUser = u;
        //    }
        //    catch
        //    {
        //        SelectedUser = null;
        //    }
        //    OnUserChange();
        //}

        ////Calls the DBManager to add an user
        //public void AddUser(string name, int age, string description, string image, string gender, float valoration)
        //{
        //    DatabaseSQL.AddUser(name, age, description, image, gender, valoration);
        //}

        ////Calls the DBManager to delete user, also removes the user from the user list
        //public void RemoveUser(int id)
        //{
        //    DBManager.DeleteUser(id);
        //    User usr = GetUserById(id);
        //    UserList.Remove(usr);
        //}

        ////Calls AppManager to filter users
        //public void FilterUsers(string keyword)
        //{
        //    DBManager.Filter(keyword);
        //}

        ////Calls the DBManager to edit an user
        //public void EditUser(int id, string name, int age, string description, string image, string gender, float valoration)
        //{
        //    DBManager.EditUser(id, name, age, description, image, gender, valoration);
        //}

        ////Returns user by its id
        //public User GetUserById(int id)
        //{
        //    return (from u in UserList
        //            where u.Id == id
        //            select u).First();
        //}

        //descativar intellisense -> herramientas -> opciones -> editor de texto -> c# -> intellisense -> desactivar las 5 primeras y las 4 ultimas
    }
}
