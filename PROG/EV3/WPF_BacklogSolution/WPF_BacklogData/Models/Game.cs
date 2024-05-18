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
        public DateTime ReseaseYear { get; set; }
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
    }
}
