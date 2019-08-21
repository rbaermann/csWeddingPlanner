using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace weddingPlanner.Models
{
    public class UserAndListOfWeddings
    {
        public User UsersWedding {get; set;}

        public List<Wedding> ListOfWeddings {get; set;}
    }
}