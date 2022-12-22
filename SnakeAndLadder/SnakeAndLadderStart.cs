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
            int iPosition = 0;

            Console.WriteLine("Enter Player name");
            string iPlayer1 = Convert.ToString(Console.ReadLine());

            while (iPosition <= 100)
            {
                Random random = new Random();
                int iDice = random.Next(1, 6);

                iPosition += iDice;
                Console.WriteLine("Dice Rolled :{0} Position is {1}", +iDice, iPosition);

                if(iPosition > 100)
                {
                    iPosition = iPosition - iDice;
                    Console.WriteLine("Not Valid Please Tray Again {0}", iPosition);

                }
                else if ((iPosition == 99) || (iPosition == 95) || (iPosition == 87) || (iPosition == 65)) // Snake
                {
                    iPosition -= 17;
                    Console.WriteLine("You Got Sneke Position is {0}", iPosition);
                }
                else if ((iPosition == 62) || (iPosition == 54) || (iPosition == 17))   // Snake
                {
                    iPosition -= 9;
                    Console.WriteLine("You Got Sneke Position is {0}", iPosition);
                }
                else if ((iPosition == 4) || (iPosition == 9) || (iPosition == 51) || (iPosition == 40) || (iPosition == 63) || (iPosition == 51))// Ladder
                {
                    iPosition += 13;
                    Console.WriteLine("You Got Ladder Position is {0}", iPosition);
                }
                else  if (iPosition==24) // Ladder
                {
                    iPosition += 48;
                    Console.WriteLine("You Got Ladder Position is {0}", iPosition);
                }
                else if (iPosition <= 0)
                {
                    iPosition = 0;   // reset

                }
               else if (iPosition == 100)
                {
                    break;
                    
                }
            }
            Console.WriteLine("Winner is : " + iPlayer1);
        }
    }
}
