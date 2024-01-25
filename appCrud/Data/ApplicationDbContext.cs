using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace appCrud.Data


{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
    } // <-- Cette accolade ferme la classe ApplicationDbContext

    // Ajoutez ici d'autres classes ou membres si nécessaire
} // <-- Cette accolade ferme l'espace de noms (namespace)
