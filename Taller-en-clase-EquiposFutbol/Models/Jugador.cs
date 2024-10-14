namespace Taller_en_clase_EquiposFutbol.Models
{
    public class Jugador
    {
        public int IdJugador { get; set; }
        public string NombreJugador { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        public Equipos Equipos { get; set; }

    }
}
