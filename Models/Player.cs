using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tictactow.Services.Data;


namespace Tictactow.Models
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Player()
        {
        }

        public Player(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"id: {Id}, Name : {Name}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
