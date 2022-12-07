using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tictactow.Models
{
    //[key]
    internal class Board
    {
        //[Key]
        public int Id { get; set; }
        public int Game_id { get; set; }
        //public virtual Game Game { get; set; }
        public int Position { get; set; }
        public string Mark { get; set; }
        
        public Board() 
        { 

        }

        public Board( int game_id, int position, string mark)
        {
            Game_id = game_id;
            Position = position;
            Mark = mark;
        }
    }
}
