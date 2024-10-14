using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller_en_clase_EquiposFutbol.Models;

namespace Taller_en_clase_EquiposFutbol.Data
{
    public class Taller_en_clase_EquiposFutbolContext : DbContext
    {
        public Taller_en_clase_EquiposFutbolContext (DbContextOptions<Taller_en_clase_EquiposFutbolContext> options)
            : base(options)
        {
        }

        public DbSet<Taller_en_clase_EquiposFutbol.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<Taller_en_clase_EquiposFutbol.Models.Estadio> Estadio { get; set; } = default!;
    }
}
