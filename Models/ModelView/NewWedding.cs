using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace weddingPlanner.Models
{
    public class NewWedding
    {
        public Wedding NewlyWeds {get; set;}

        public UserWedding Weds {get; set;}
    }
}