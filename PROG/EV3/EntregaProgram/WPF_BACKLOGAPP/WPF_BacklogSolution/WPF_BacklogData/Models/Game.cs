using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WPF_BacklogData.Models
{
    public enum GameStatus
    {
        PorJugar,
        Jugando,
        Completado,
        Abandonado
    }
    public class Game
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Rating { get; set; }
        public string Img { get; set; }
        public int Genre_ID { get; set; }
        public int Developer_ID { get; set; }
        public int User_ID { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int Platform_ID { get; set; }
        public string Status { get; set; }


        public Game(int gameId, string name, string description, DateTime releaseDate, int rating, string img, int genreId, int developerId, int userId, decimal price, DateTime purchaseDate, DateTime completionDate, string status, int Platform_id)
        {
            ID = gameId;
            Name = name;
            Description = description;
            ReleaseDate = releaseDate;
            Rating = rating;
            Img = img;
            Genre_ID = genreId;
            Developer_ID = developerId;
            User_ID = userId;
            Price = price;
            PurchaseDate = purchaseDate;
            CompletionDate = completionDate;
            Status = status;
            Platform_ID = Platform_id;
        }

        public Game(int gameId, string name, string img, string status)
        {
            ID = gameId;
            Name = name;
            Img = img;
            Status = status;
        }

        public Game()
        {

        }
    }

    public interface ISGameListener
    {
        void OnStudentSelected(Game game);
    }
}
