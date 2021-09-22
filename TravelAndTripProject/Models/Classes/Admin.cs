using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelAndTripProject.Models.Classes
{
    public class Admin
    {
        [Key]
        public int id { get; set; }

        public string Kullanici { get; set; }

        public string Sifre { get; set; }
    }
}