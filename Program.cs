using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Write a number between 1-10");
            int randomNam = Convert.ToInt32(Console.ReadLine());
            int MyguessNum = 6;
            
            if (randomNam > 10)
            {
                Console.WriteLine("The number you wrote is wrong please write a number between 1-10");
            }
            else 
            {
                Console.WriteLine($" Your number is  {randomNam}");

                switch (randomNam) 
                {
                    case 1:
                        
                        Console.WriteLine( "Your Number is 5 number smaller");

                        break;
                    case 2:

                        Console.WriteLine("Your Number is 4 number smaller");

                        break;
                    case 3:

                        Console.WriteLine("Your Number is 3 number smaller");

                        break;
                    case 4:

                        Console.WriteLine("Your Number is 2 number smaller");

                        break;
                    case 5:

                        Console.WriteLine("Your Number is 1 number smaller");

                        break;
                    case 6:

                        Console.WriteLine("Your choice is corect ");

                        break;
                    case 7:

                        Console.WriteLine("Your Number is 1 number biger");

                        break;
                    case 8:

                        Console.WriteLine("Your Number is 2 number biger");

                        break;
                    case 9:

                        Console.WriteLine("Your Number is 3 number biger");

                        break;
                    case 10:

                        Console.WriteLine("Your Number is 4 number biger");

                        break;
                    
                }
            }



            Console.ReadKey();

        }
    }
}
