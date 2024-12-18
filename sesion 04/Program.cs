namespace sesion_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 13  Write a program to allow the user to enter a string and print the REVERSE of it.
            // System.Console.WriteLine("enter the string");
            // string Input = Console.ReadLine();
            // string Reversed  ="";
            // for (int i = Input.Length -1; i >=0 ; i--)
            // {
            //     Reversed += Input[i]  ;
            // }
            // System.Console.WriteLine(Reversed);
            #endregion

            #region 14 - Write a program to allow the user to enter int and print the REVERSED of it.
            //     System.Console.WriteLine("enter the string");
            // string Input = Console.ReadLine();
            // string Reversed  ="";
            // for (int i = Input.Length -1; i >=0 ; i--)
            // {
            //     Reversed += Input[i]  ;
            // }
            // System.Console.WriteLine(Reversed);
            #endregion

            #region 15  Write a program in C# Sharp to find prime numbers within a range of numbers.
            // System.Console.WriteLine("enter the first input ");
            // int.TryParse(Console.ReadLine(), out int first);
            // System.Console.WriteLine("entet the last input");
            // int.TryParse(Console.ReadLine(), out int last);
            // for (int i = first; i < last; i++)
            // {

            //      if (IsPrime(i)) {
            //         System.Console.WriteLine(i);
            //     }
            // }

            #endregion

            #region 16
            //     Console.WriteLine("Enter a number to convert: ");
            //   int number = int.Parse(Console.ReadLine());

            //     string binary = "";

            //     while (number > 0)
            //     {
            //         binary = (number % 2) + binary;
            //         number /= 2;
            //     }

            //     Console.WriteLine($"The Binary of the number is {binary}");

            #endregion

            #region 17 
            // Console.WriteLine("Enter the coordinates of the first point (x1, y1): ");
            // int x1 = int.Parse(Console.ReadLine());
            // int y1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the coordinates of the second point (x2, y2): ");
            // int x2 = int.Parse(Console.ReadLine());
            // int y2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the coordinates of the third point (x3, y3): ");
            // int x3 = int.Parse(Console.ReadLine());
            // int y3 = int.Parse(Console.ReadLine());

            // int area = (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            // if (area == 0)
            // {
            //     Console.WriteLine("The points lie on a single straight line.");
            // }
            // else
            // {
            //     Console.WriteLine("The points do not lie on a single straight line.");
            // }



            #endregion

            #region 18
            Console.WriteLine("Enter the time taken to complete the task (in hours): ");
            double timeTaken = double.Parse(Console.ReadLine());

            if (timeTaken >= 2 && timeTaken <= 3)
            {
                Console.WriteLine("The worker is highly efficient.");
            }
            else if (timeTaken > 3 && timeTaken <= 4)
            {
                Console.WriteLine("The worker is instructed to increase their speed.");
            }
            else if (timeTaken > 4 && timeTaken <= 5)
            {
                Console.WriteLine("The worker is provided with training to enhance their speed.");
            }
            else if (timeTaken > 5)
            {
                Console.WriteLine("The worker is required to leave the company.");
            }
            else
            {
                Console.WriteLine("Invalid input. Time should be a positive number.");
            }
            #endregion



        }
    }
}
