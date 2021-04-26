using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Teeba.Models
{
    public class TourPassenger
    {
        public int ID { get; set; }
        public int Passenger_ID { get; set; }
        public int Tour_ID { get; set; }
        public int Passengers_Number { get; set; }      //Number of passengers in the Tour
        public string Tour_Type { get; set; }

        [ForeignKey("Passenger_ID")]
        public virtual Passenger Passenger { get; set; }

        [ForeignKey("Tour_ID")]
        public virtual Tour Tour { get; set; }
    }
}