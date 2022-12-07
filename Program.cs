using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tictactow.Services.Data;
using Tictactow.Models;
namespace Tictactow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TheContext theContext = new TheContext();
            Player player1 = new Player("kwstakis");
            Player player2 = new Player("giannakis");
            //theContext.Players.Add(player1);
            //theContext.SaveChanges();

            //theContext.Players.Add(player2);
            //theContext.SaveChanges();
            Game paixnidi= new Game(player1, player2);
            Console.WriteLine(paixnidi.Id);
            theContext.Games.Add(paixnidi);
            theContext.SaveChanges();  

            //theContext.Players.Add(player2);
            //theContext.SaveChanges();
            //Board atata = new Board();
            //theContext.Boards.Add(atata);
            //Game game = new Game(theContext, player1, player2);
            //theContext.Boards.Add(new Game { Player1= "asda", Player2 = "aa" });
            //theContext.Boards.Add(new Board { Player1= "asda", Player2 = "aa" });
            //Board board = new Board();
            //Winner = winner;
            //Random r = new Random();
            //List<int> list = new List<int>();
            //List<string> list1 = new List<string>();
            //int counter = 1;
            //while (counter < 10)
            //{
            //    Board board = new Board(1, -1, "no mark");

            //    int a = r.Next(1, 10);
            //    if (list.Contains(a))
            //    {
            //        continue;
            //    }
            //    list.Add(a);
            //    string ab = "";
            //    if (counter % 2 == 0)
            //    {
            //        //ab += $"O{a}";
            //        board.Mark = "O";
            //        board.Position = a;
            //        theContext.Boards.Add(board);
            //        theContext.SaveChanges();
            //        counter++;
            //        continue;
            //    }

            //    ab += $"X{a}";
            //    board.Mark = "X";
            //    board.Position = a;
            //    theContext.Boards.Add(board);
            //    theContext.SaveChanges();
            //    list1.Add(ab);
            //    counter++;
            //}


        }
    }
}

