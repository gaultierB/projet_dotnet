using System;

namespace TodoApi.Models
{
    public class Player
    {
        public int Id { get; set;}

        public string Name { get; set; }

        public string Firstname { get; set; }

        public int Number { get; set; }

        public Player(int id, string name, string firstname, int number)
        {
            this.Id = id;
            this.Name = name;
            this.Firstname = firstname;
            this.Number = number;
        }
    }
}