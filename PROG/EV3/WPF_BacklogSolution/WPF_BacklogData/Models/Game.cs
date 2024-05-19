using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BacklogData.Models
{
    public class Game
    {
        
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int Rating { get; set; }
        public string? Img { get; set; }
        public int Genre_ID { get; set; }
        public int Developer_ID { get; set; }
        public int User_ID { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime DurationTime { get; set; }
        public string? Status { get; set; }

        public Game(int gameId, string name, string description, DateTime releaseYear, int rating, string img, int genreId, int developerId, int userId, decimal price, DateTime purchaseDate, DateTime completionDate, string status)
        {
            ID = gameId;
            Name = name;
            Description = description;
            ReleaseYear = releaseYear;
            Rating = rating;
            Img = img;
            Genre_ID = genreId;
            Developer_ID = developerId;
            User_ID = userId;
            Price = price;
            PurchaseDate = purchaseDate;
            CompletionDate = completionDate;
            Status = status;
        }

        public Game()
        {

        }

    }
}
