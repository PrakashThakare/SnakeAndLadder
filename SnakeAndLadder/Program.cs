using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Snake And Ladder Game");
            SnakeAndLadderStart obj = new SnakeAndLadderStart();
            obj.StartPosionZero();
            Console.ReadLine();
        }
    }
}
