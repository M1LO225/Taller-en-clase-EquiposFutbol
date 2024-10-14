using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_en_clase_EquiposFutbol.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }
        public string NombreJugador { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        [ForeignKey("Equipos")]
        public Equipos Equipos { get; set; }

    }
}
