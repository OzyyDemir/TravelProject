using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelAndTripProject.Models.Classes
{
    public class AdresBlog
    {
        [Key]
        public int id { get; set; }

        public string Baslik { get; set; }

        public string Aciklama { get; set; }

        public string Adres { get; set; }

        public string Mail { get; set; }

        public string Telefon { get; set; }

        public string Konum { get; set; }
    }
}