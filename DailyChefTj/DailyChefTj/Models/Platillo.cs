using System.Collections.Generic;

namespace DailyChefTj.Models
{
    public class Platillo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public int Calificacion { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }

    }
}