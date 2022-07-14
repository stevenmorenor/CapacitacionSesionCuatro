using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionSesionCuatro.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-HDVJNKT\\SQLEXPRESS;Initial Catalog =TrainingEquipment;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Coach> Coachs { get; set; }
        public DbSet<Player> players { get; set; }


    }
}
