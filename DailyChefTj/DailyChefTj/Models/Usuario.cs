using System.Collections.Generic;

namespace DailyChefTj.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public List<Medidas> Medidas { get; set; }
        public Cargo Rol { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public List<Ingrediente> IngredientesNoDeseados { get; set; }
        public List<Ingrediente> Alergias { get; set; }
    }
}