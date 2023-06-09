using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Tinder_para_trastear;

namespace Tinder
{
    public class User
    {
        
        private int _id 
        private string _name 
        private int _age 
        private string _photo 
        private string _description 
        private string _gender 
        private int _rating 


        public User()
        {
            
        }

        public User(int id, string name, int age, string photo, string description, string gender, int rating)
        {
            Id = id;
            Name = name;
            Age = age;
            Photo = photo;
            Description = description;
            Gender = gender;
            Rating = rating;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public int Rating { get; set; }

        private bool UserFilter(User user)
        {
            if (String.IsNullOrEmpty(Name))
                return true;
            else
                return false;
        }

        public static User SetIdClient()
        {
            throw new NotImplementedException();
        }

        public static User Create()
        {
            throw new NotImplementedException();
        }

        internal User SetName(string name)
        {
            Name = name;
            return this;
        }
        public User SetAge(int age)
        {
            Age = age;
            return this;
        }
        public User SetPhoto(string photo)
        {
            Photo = photo;
            return this;
        }
        public User SetDescription(string description)
        {
            Description = description;
            return this;
        }
        public User SetGender(string gender)
        {
            Gender = gender;
            return this;
        }
        public User SetRating(int rating)
        {
            Rating = rating;
            return this;
        }
        

        //content = "{Binding Name}"

        //<image> visibility="{Binding HasOneSar}"
        //public bool HasOneStar => Rating > 10;
        //hacerlo *5

    }
}
