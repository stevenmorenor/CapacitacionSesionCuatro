using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionSesionCuatro
{
    public class Coach
    {
        [Key]
        public int Id_Coach { get; set; }
        public int Player_Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public virtual Player Player { get; set; }

        //public static List<Coach> GetAllCoach()
        //{
        //    return new List<Coach>(){
        //         new Coach {Name = "Wendy", Age = 34, Experience = 6},
        //         new Coach {Name = "Jaime", Age = 45, Experience = 8},
        //         new Coach {Name = "Felipe", Age = 38, Experience = 4}
        //    };
        //}

    }
}
