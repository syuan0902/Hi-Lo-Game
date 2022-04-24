using System;

namespace Hi_Lo_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //列出Random的陣列內容
            /*
            HiLoGame.random = new Random(1);
            Random seededRandom = new Random(1);
            Console.Write("前20個隨機數是: ");
            for (int i = 0; i < 10; i++)
                Console.Write($"{ seededRandom.Next(1, HiLoGame.MAXIMUM + 1)} ");*/
            
            Console.WriteLine($"歡迎參加猜數字遊戲,目前的數字是{HiLoGame.GetCurrentNumber()}");
            Console.WriteLine($"數字區間在 1和 {HiLoGame.MAXIMUM} 之間");

            while (HiLoGame.GetPot() > 0)
            {
                Console.WriteLine($"\n你有 {HiLoGame.GetPot()}元");

                Console.WriteLine("\n下一個數字>=目前數字大請輸入 1, 下一個數字<=目前數字小請輸入 2, \n結束遊戲請輸入其他按鍵");

                char key = Console.ReadKey(true).KeyChar;
                if (key == '1')
                {
                    HiLoGame.Guess(true);
                }

                else if (key == '2')
                {
                    HiLoGame.Guess(false);
                }

                /*else if (key == '3')
                {
                    HiLoGame.Hint();
                }*/

                else return;
            }

            Console.WriteLine("\n你口袋空空囉, Bye~~");
        }
    }
}
