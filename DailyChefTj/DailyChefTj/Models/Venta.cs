using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyChefTj.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public Platillo Platillo { get; set; }
        public Usuario Usuario { get; set; }
        public int Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}