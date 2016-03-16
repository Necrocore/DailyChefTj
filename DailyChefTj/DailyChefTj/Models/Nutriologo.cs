using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyChefTj.Models
{
    public class Nutriologo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Telefono { get; set; }
        public Cargo Rol { get; set; }
        public List<Usuario> Paciente { get; set; }
    }
}