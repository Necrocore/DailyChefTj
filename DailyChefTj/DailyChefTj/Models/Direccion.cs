using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace DailyChefTj.Models
{
    public class Direccion
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string Calle { get; set; }
        public int CodigoPostal { get; set; }
        public string Fraccionamiento { get; set; }
        public Image GoogleMaps { get; set; }
    }
}