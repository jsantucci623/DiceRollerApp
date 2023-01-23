using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class DiceRollerMethods
    {
        public static int DieNumber(int numSides)
        {
            Random rand = new Random();
            int num;
            do
            {
                num = rand.Next(numSides);

            } while (num == 0);

            return num;
        }
        public static string DiceResult(int totalDie)
        {
            string answer;
            int num;
            num = totalDie;
            if (num == 2)
            {
                answer = "Snake Eyes";
            }
            else if (num == 3)
            {
                answer = "Ace Deuce";
            }
            else if (num == 12)
            {
                answer = "Box Cars";
            }
            else
                answer = "";

            return answer;
        }
        public static int DiceTotal(int dieTot1, int dieTot2)
        {
            int totalDie = dieTot1 + dieTot2;
            return totalDie;
        }
        public static string WinCraps(int dieTot1, int dieTot2)
        {
            string answer;
            int totalDie = DiceTotal(dieTot1, dieTot2);

            if (totalDie == 7 || totalDie == 11)
            {
                answer = "Winner";
            }
            else if (totalDie == 2 || totalDie == 3 || totalDie == 12)
            {
                answer = "Craps";
            }
            else
                answer = "";

            return answer;
        }  

    }
}
