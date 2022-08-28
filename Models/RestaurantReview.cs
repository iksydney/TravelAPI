using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAPI.Models
{
    [Table("RestaurantReview")]
    public class RestaurantReview
    {
        [Key]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public int RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]
        public Restaurant Restaurant { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
