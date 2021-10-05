using System;

namespace TodoApi.Models.Player
{
    public class Player
    {
        public int Id { get; set;}

        public string Name { get; set; }

        public string Firstname { get; set; }

        public int Numero { get; set; }

        public Player(int id, string name, string firstname, int numero)
        {
            this.Id = id;
            this.Name = name;
            this.Firstname = firstname;
            this.Numero = numero;
        }
    }

    // public class Team
    // {
    //     public string Name { get; set; }

    //     public Player Players[] { get; set; }
    // }
}