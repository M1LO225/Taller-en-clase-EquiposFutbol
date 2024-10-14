using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("IdEstadio")]
        public Estadio Estadio { get; set; }

    }
}
