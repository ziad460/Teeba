using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teeba.Models
{
    public class Tour       // Class about Every Tour
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Days { get; set; }       //Number Of Tour Days
        public string Destination { get; set; }     //(Luxor Or Asswan)
        public double Price { get; set; }
        public string Image { get; set; }

        public virtual ICollection<TourPassenger> TourPassengers { get; set; }
    }
}