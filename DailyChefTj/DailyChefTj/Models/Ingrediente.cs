using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyChefTj.Models
{
    public class Ingrediente
    {
        virtual public int Id { get; set; }
        virtual public string Nombre { get; set; }
        virtual public Proveedor Proveedor { get; set; }
       
    }
}