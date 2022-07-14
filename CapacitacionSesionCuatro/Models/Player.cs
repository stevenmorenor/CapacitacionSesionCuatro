using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionSesionCuatro
{
    public class Player
    {
        [Key]
        public int Id_Player { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Coach> Coaches { get; set; }
        
        //public static List<Player> GetAllPlayer()
        //{
        //    return new List<Player>(){
        //        new Player {Name = "Steven", Team = "Cali", Age = 20},
        //        new Player {Name = "Miguel", Team = "Millonarios", Age = 25},
        //        new Player {Name = "Camilo", Team = "Santafe", Age = 30},
        //        new Player {Name = "Andres", Team = "Nacional", Age = 40},
        //        new Player {Name = "Pedro", Team = "Tigres", Age = 28},

        //    };
        //}

    }
}
