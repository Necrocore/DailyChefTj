using System;

namespace DailyChefTj.Models
{
    public class Medidas
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
    }
}