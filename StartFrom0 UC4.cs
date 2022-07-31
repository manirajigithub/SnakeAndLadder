using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderProblem
{
    public class WinningPosition
    {
        public static int[] WinningPosition()
        {
            int Position, Counter = 0;
            while (Position <= 100)

            {
                int roll = DiceValue.DiceRoll();
                if (Position <= 0)
                {
                    Position = 0;
                    Position = CheckOption.Option(roll, Position);
                }
                else
                {
                    Position = CheckOption.Option(roll, Position);
                }
                counter++;
            }
            int[] arr = new int[3];
            arr[0] = counter;
            arr[1] = Position;
            return arr;
        }
    }
}