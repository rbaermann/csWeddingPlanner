using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace weddingPlanner.Models
{
    public class UserWedding
    {
        [Required]
        public int UserWeddingId {get; set;}

        public int UserId {get; set;}

        public int WeddingId {get; set;}

        public User User {get; set;}

        public Wedding Wedding {get; set;}
    }
}