using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyChefTj.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Proveedor Proveedor { get; set; }
       
    }
}