﻿using System.ComponentModel.DataAnnotations;

namespace Taller_en_clase_EquiposFutbol.Models
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }

    }
}
