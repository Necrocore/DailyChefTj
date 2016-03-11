using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyChefTj.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Rol Rol { get; set; }

    }
}