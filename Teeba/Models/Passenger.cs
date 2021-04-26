using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Teeba.Models
{
    [Table("Passenger"), MetadataType(typeof(passengerMetaData))]
    public class Passenger
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double National_ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string street { get; set; }
        public double Phone_Number { get; set; }

        public virtual ICollection<TourPassenger> TourPassengers { get; set; }
    }
}