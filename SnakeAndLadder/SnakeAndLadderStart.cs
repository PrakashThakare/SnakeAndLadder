using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class SnakeAndLadderStart
    {
        public void StartPosionZero()
        {
            Console.WriteLine("Enter Player name");
            string sPlayer1 = Convert.ToString(Console.ReadLine());

            Random random = new Random();
            int iDice = random.Next(1, 7);

            Console.WriteLine("Dice Number Is :{0}", iDice);

        }
    }
}
