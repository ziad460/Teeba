using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teeba.Models
{
    public class LuxorMetaData
    {
        [Required , MaxLength(100)]
        public string Name { get; set; }    //Place Name
        [Required , MaxLength(150)]
        public string Location { get; set; }        //Place Location In Luxor
        [MaxLength(150)]
        public string Short_Describtion { get; set; }  //Short describtion about this place
    }
    public class AsswanMetaData
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }    //Place Name
        [Required, MaxLength(100)]
        public string Location { get; set; }        //Place Location In Luxor
        [MaxLength(150)]
        public string Short_Describtion { get; set; }  //Short describtion about this place
    }
    public class passengerMetaData
    {
        [Required , MaxLength(50)]
        public string Name { get; set; }
        [Required , EmailAddress]
        public string Email { get; set; }
        [Display(Name = "National ID")]
        public double National_ID { get; set; }
        [Required , MaxLength(50)]
        public string Country { get; set; }
        [Required, MaxLength(50)]
        public string City { get; set; }
        [Required, MaxLength(50)]
        public string street { get; set; }
        [Display(Name = "Phone Number")]
        public double Phone_Number { get; set; }
    }
}