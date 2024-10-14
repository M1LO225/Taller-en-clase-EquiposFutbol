using System.ComponentModel.DataAnnotations;

namespace Taller_en_clase_EquiposFutbol.Models
{
    public class Equipos
    {
        [Key]
        public int IdEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public string Ciudad { get; set; }
        public string TitulosEquipo { get; set; }
        public bool AdmiteExtranjeros { get; set; }
        public Estadio Estadio { get; set; }

    }
}
