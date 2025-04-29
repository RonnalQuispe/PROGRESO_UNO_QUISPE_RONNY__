using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROGRESO_UNO_QUISPE_RONNY.Models;

    public class baseProgreso1 : DbContext
    {
        public baseProgreso1 (DbContextOptions<baseProgreso1> options)
            : base(options)
        {
        }

        public DbSet<PROGRESO_UNO_QUISPE_RONNY.Models.Cliente> Cliente { get; set; } = default!;
    }
