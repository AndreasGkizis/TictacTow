using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tictactow.Services.Data;

namespace Tictactow.Models
{
    internal class Game
    {
        public int Id { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player Winner { get; set; }
        //public TheContext cont { get; set; }

        public Game() { }
        public Game( Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;

            TheContext someContext = new TheContext();
            Random r = new Random();
            List<int> list = new List<int>();
            List<string> list1 = new List<string>();
            int counter = 1;
            while (counter < 10)
            {
                Board board = new Board(this.Id, -1, "no mark");

                int a = r.Next(1, 10);
                if (list.Contains(a))
                {
                    continue;
                }
                list.Add(a);
                string ab = "";
                if (counter % 2 == 0)
                {
                    //ab += $"O{a}";
                    board.Mark = "O";
                    board.Position = a;
                    someContext.Boards.Add(board);
                    someContext.SaveChanges();
                    counter++;
                    continue;
                }

                ab += $"X{a}";
                board.Mark = "X";
                board.Position = a;
                someContext.Boards.Add(board);
                someContext.SaveChanges();
                list1.Add(ab);
                counter++;
            }
            Winner = player2;




        }

        public override string ToString()
        {
            return base.ToString();
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
