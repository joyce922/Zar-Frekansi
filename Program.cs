using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class RollDice
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();

            int frekans1 = 0;
                
            int frekans2 = 0;
                
            int frekans3 = 0;
                
            int frekans4 = 0;
                
            int frekans5 = 0;

            int frekans6 = 0;



            for(int i = 0; i<10000000;i++)
            {
                int rolls = randomNumbers.Next(1, 7);

                switch(rolls)
                {
                    case 1:
                        ++frekans1;
                        break;
                    case 2:
                        ++frekans2;
                        break;
                    case 3:
                        ++frekans3;
                        break;
                    case 4:
                        ++frekans4;
                        break;
                    case 5:
                        ++frekans5;
                        break;
                    case 6:
                        ++frekans6;
                        break;

                }
            }

            Console.WriteLine("Zar  frekansı");
            Console.WriteLine ("\n1 frekansı : " + frekans1 );
            Console.WriteLine ("\n2 frekansı : " + frekans2 );
            Console.WriteLine ("\n3 frekansı : " + frekans3 );
            Console.WriteLine ("\n4 frekansı : " + frekans4 );
            Console.WriteLine ("\n5 frekansı : " + frekans5 );
            Console.WriteLine ("\n6 frekansı : " + frekans6);

            Console.ReadLine();
        }
    }
}
