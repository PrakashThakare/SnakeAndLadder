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
            string iPlayer1 = Convert.ToString(Console.ReadLine());
       
            int iPositionon = 0;
            while (iPositionon <= 100)
            {
                Random random = new Random();
                Console.ReadLine();

                int iDice = random.Next(1, 6);
                iPositionon += iDice;
                Console.WriteLine("Dice Rolled :{0} Position is {1}", +iDice, iPositionon);

                if ((iPositionon == 99) || (iPositionon == 95) || (iPositionon == 87) || (iPositionon == 65)) // Snake
                {
                    iPositionon -= 17;
                    Console.WriteLine("You Got Sneke Position is {0}", iPositionon);
                }
                else if ((iPositionon == 62) || (iPositionon == 54) || (iPositionon == 17))   // Snake
                {
                    iPositionon -= 9;
                    Console.WriteLine("You Got Sneke Position is {0}", iPositionon);
                }
                else if ((iPositionon == 4) || (iPositionon == 9) || (iPositionon == 51) || (iPositionon == 40) || (iPositionon == 63) || (iPositionon == 51))// Ladder
                {
                    iPositionon += 13;
                    Console.WriteLine("You Got Ladder Position is {0}", iPositionon);
                }
                else  if (iPositionon==24) // Ladder
                {
                    iPositionon += 48;
                    Console.WriteLine("You Got Ladder Position is {0}", iPositionon);
                }

            }
        }
    }
}
