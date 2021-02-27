using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Calculator Console Program!]");
            Console.WriteLine("Enter amount of input:");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] storenum = new int[input];
            int temp = 0;
            int choice = 4;
            // accepts numerous inputs
            for(int i = 0; i < input; i++)
            {
                Console.WriteLine("Enter Number:");
                storenum[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Operation:");
            Console.WriteLine("[1]Addition");
            Console.WriteLine("[2]Subtraction");
            Console.WriteLine("[3]Multiplacation");
            Console.WriteLine("[4]Division");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    for (int a = 0; a < input; a++)
                    {
                        temp += storenum[a];
                    }
                    Console.WriteLine(temp);
                    break;
                case 2:
                    for (int a = 0; a < input; a++)
                    {
                        temp -= storenum[a];
                    }
                    Console.WriteLine(temp);
                    break;
                case 3:
                   
                    break;
                case 4:
                    
                    break;
            }


            
            Console.ReadKey();
        }
    }
}
