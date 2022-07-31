using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc3_SnakeandLadder
{
    public class CheckOption
    {
        
        public static int Option(int Position, int roll)
        {
            int Snake = 0;
            int Ladder = 2;
            Random random = new Random();
            int option = random.Next(0, 3);
            
             if (option == Snake)
            {
                Position += roll;
                Console.WriteLine("option snake");
            }
               else if(option == Ladder)
              {
                Position -= roll;
                Console.WriteLine("option  Ladder");
               }
            else
            {
                Position += 0;
                Console.WriteLine("option No Play");
            }
            return Position;
        }
    }
}