using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Teeba.Models
{
    [Table("LuxorPlaces") , MetadataType(typeof(LuxorMetaData))]
    public class LuxorPlaces                                    //for Places Details in Luxor 
    {
        public int ID { get; set; }                             //place Id
        public string Name { get; set; }                        //Place Name
        public string Location { get; set; }                    //Place Location In Luxor
        public string Short_Describtion  { get; set; }          //Short describtion about this place
        public string Long_Describtion { get; set; }          //Short describtion about this place
        public double Entrance_Foreigner_Ticket { get; set; }
        public double Entrance_Egyptian_Ticket { get; set; }
        public PlacesImages PlacesImages { get; set; }
        public string Arabic_Long_Describtion { get; set; }          //Short describtion about this place
    }
    [Table("AsswanPlaces"), MetadataType(typeof(AsswanMetaData))]
    public class AsswanPlaces                                   //for Places Details in Asswan 
    {
        public int ID { get; set; }                             //place Id
        public string Name { get; set; }                        //Place Name
        public string Location { get; set; }                    //Place Location In Asswan
        public string Short_Describtion { get; set; }           //Short describtion about this place
        public string Long_Describtion { get; set; }          //Short describtion about this place
        public double Entrance_Foreigner_Ticket { get; set; }
        public double Entrance_Egyptian_Ticket { get; set; }
        public PlacesImages PlacesImages { get; set; }
        public string Arabic_Long_Describtion { get; set; }          //Short describtion about this place
    }
}