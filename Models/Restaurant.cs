using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAPI.Models
{
    [Table("Restaurants")]
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string PhoneNumber { get; set; }
        public string RestaurantEmail { get; set; }
        public string Address { get; set; }
        public string Opens { get; set; }
        public string Closes { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Area { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Price { get; set; }
        public string ReserveUrl { get; set; }
        public string ImageUrl { get; set; }
        public List<RestaurantReview> Reviews { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
