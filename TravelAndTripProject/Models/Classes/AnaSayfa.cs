using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelAndTripProject.Models.Classes
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string Başlik { get; set; }
        public string Aciklama { get; set; }
    }
}