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
        public string? Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; } = DateTime.MinValue;
        public int Rating { get; set; }
        public string? Img { get; set; } = string.Empty;
        public int Genre_ID { get; set; }
        public int Developer_ID { get; set; }
        public int User_ID { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.MinValue;
        public DateTime? CompletionDate { get; set; }
        public GameStatus GameStatus { get; set; } = GameStatus.PorJugar;
        public int Platform_ID { get; set; }

        public Game() { }

        public Game(int gameId, string name, string description, DateTime releaseDate, int rating, string img, int genreId, int developerId, int userId, double price, DateTime purchaseDate, DateTime? completionDate, string status, int platformId)
        {
            ID = gameId;
            Name = name ?? string.Empty;
            Description = description ?? string.Empty;
            ReleaseDate = releaseDate;
            Rating = rating;
            Img = img ?? string.Empty;
            Genre_ID = genreId;
            Developer_ID = developerId;
            User_ID = userId;
            Price = price;
            PurchaseDate = purchaseDate;
            CompletionDate = completionDate;
            GameStatus = GameStatus.PorJugar;
            Platform_ID = platformId;
        }
    


        public Game(int gameId, string name, string img, string status, string description)
        {
            ID = gameId;
            Name = name;
            Img = img;
            GameStatus = GameStatus.PorJugar;
            Description = description;
        }
    }

    public interface ISGameListener
    {
        void OnStudentSelected(Game game);
    }
}
