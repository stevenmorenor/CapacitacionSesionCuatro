using CapacitacionSesionCuatro.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CapacitacionSesionCuatro
{
    public class Program
    {
        static void Main(string[] args)
        {
            removePlayer();
            Console.ReadLine();
            //using (SqlConnection con = GetConnection())
            //{
            //    con.Open();

            //    string sql = "select nombre from futbolistas ";
            //    SqlCommand command = new SqlCommand(sql, con);
            //    command.CommandType = CommandType.Text;

            //    SqlDataReader reader = command.ExecuteReader();

            //    var result =
            //    Coach.GetAllCoach().Join(Player.GetAllPlayer(),
            //    e => e.Id_Coach,
            //    d => d.Id_Player, (coach, player) => new
            //    {
            //    CoachName = coach.Name,
            //    PlayerName = player.Name
            //    });
            //    foreach (var coach in result)
            //    {
            //        Console.WriteLine(coach.CoachName + "\t" +
            //        coach.PlayerName);
            //    }
            //    Console.ReadLine();
            //}         

        }

        static void addPlayer()
        {
            using (var player = new PlayerContext())
            {
                Player p = new Player() { Name = "Steven" };
                player.players.Add(p);
                player.SaveChanges();
                Console.WriteLine("Successful create");
            }
        }
        static void updatePlayer()
        {
            using (var player = new PlayerContext())
            {
                Player p = new Player() { Id_Player = 2, Name = "Steven", Team="Millonarios",Age=21 };
                player.players.Update(p);
                player.SaveChanges();
                Console.WriteLine("Successful modification");
            }
        }
        static void getPlayer()
        {
            using (var player = new PlayerContext())
            {
                Console.WriteLine("List of players");
                foreach (var item in player.players.ToList())
                {
                    Console.WriteLine($"Id: {item.Id_Player} The Name is: {item.Name} Your Team: {item.Team} Your Age: {item.Age}");

                }
            }
        }

        static void removePlayer()
        {
            using (var player = new PlayerContext())
            {
                Player p = new Player() { Id_Player = 2};
                player.players.Remove(p);
                player.SaveChanges();
                Console.WriteLine("Successfull remove");
            }
        }

        //private static SqlConnection GetConnection()
        //{
        //    string cs = "Data Source = DESKTOP-HDVJNKT\\SQLEXPRESS;Initial Catalog =TrainingEquipment;Integrated Security=true";

        //    return new SqlConnection(cs);
        //}
    }
}
