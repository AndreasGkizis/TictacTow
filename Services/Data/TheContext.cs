using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tictactow.Models;

namespace Tictactow.Services.Data
{
    internal class TheContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Player> Players{ get; set; }
        public TheContext(): base("name=MyConString") { }
    }
}
