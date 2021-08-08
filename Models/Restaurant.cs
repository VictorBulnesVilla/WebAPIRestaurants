using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIRestaurants.Models
{
    public class Restaurant
    {
        public int restaurantID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string locacionLatitude { get; set; }
        public string locationLongitude { get; set; }
        public string phone { get; set; }
        public string pathImage { get; set; }
        public string email { get; set; }
        public int isActivate { get; set; }
        public DateTime creationDate { get; set; }
        public int mainBranchID { get; set; }
        public int restaurantCategoryID { get; set; }
        public int userID { get; set; }

    }
}


