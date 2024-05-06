using System;
namespace MyFirstApp {
    class Program {
        static void Main(string[] args)
        {

            //Thread.Sleep(1000);
            Console.WriteLine("Введи то, чему хочешь научить Шарикова");
            string name = Console.ReadLine();
            string revName = new string(name.Reverse().ToArray());
            //Thread.Sleep(1000);
            //Console.WriteLine(revName);
            string face1 = " ----------\n|         |\n|o       o|\n|         |\n|   ----  |\n ----------";
            string face2 = " ----------\n|         |\n|o       o|\n|         |\n|    |O|  |\n ----------";
            int s = 0;
            string ss = "";
            while(s != revName.Length)
            {
                ss += revName[s];
                Console.Clear();
                if (s % 2 == 0)
                {
                    Console.WriteLine(face1);
                    Console.WriteLine(ss);
                    s++;
                    Thread.Sleep(400);

                }
                else
                {
                    Console.WriteLine(face2);
                    Console.WriteLine(ss);
                    s++;
                    Thread.Sleep(400);
                }
            }
            Console.ReadKey();
        }
    }
}