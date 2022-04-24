using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Lo_Game
{
     static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        //Main方法可以取得GotPot回傳的值，但無法修改它
        public static int GetPot() { return pot; }
        public static int GetCurrentNumber() { return currentNumber; }

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            
            if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("\n你猜對囉!!");
                pot+=3;
            }

            else
            {
                Console.WriteLine("\n真不幸, 你猜錯囉!!");
                pot-=3;
            }

            currentNumber = nextNumber;

            Console.WriteLine($"目前的數字是 {currentNumber}");
        }

        /*public static void Hint()
        {
            int half = MAXIMUM / 2;
            
            //currentNumber的值還沒變成nextNumber
            if (currentNumber >= half)
            {
                Console.WriteLine($"\n這個數字至少是 {half}");
            }

            else
            {
                Console.WriteLine($"\n這個數字最多是 {half}");
            }

            pot-=2;
        }*/

    }
}
