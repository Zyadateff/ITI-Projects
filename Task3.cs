namespace ititasks.task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ahlan ya user ya 7bibi\n");
            while (true)
            {
                Console.Write("choose an operation u want \n");
                Console.Write("1: check a number is pos or neg\n");
                Console.Write("2: check a number is even or odd\n");
                Console.Write("3: check a rectangle is square or not\n");
                Console.Write("0: Exit program..\n");
                string input = Console.ReadLine();
                int inputn = int.Parse(input);
                if (inputn == 1)
                {
                    Console.Write("enter a number plz\n");
                    string num = Console.ReadLine();
                    int number = int.Parse(num);
                    if (number < 0)
                    {
                        Console.WriteLine("a number is negative");
                    }
                    else if (number > 0)
                    {
                        Console.WriteLine("a number is positive");
                    }
                    else { Console.WriteLine("a number is zero"); }
                    continue;
                }
                if (inputn == 2)
                {
                    Console.Write("enter a number plz\n");
                    string num = Console.ReadLine();
                    int number = int.Parse(num);
                    if (number %2 == 0)
                    {
                        Console.WriteLine("a number is even");
                    }
                    else 
                    {
                        Console.WriteLine("a number is odd");
                    }
                    continue;
                }
                if (inputn == 3)
                {
                    Console.Write("enter length and width plz\n");
                    string num1 = Console.ReadLine();
                    string num2 = Console.ReadLine();
                    double length = double.Parse(num1);
                    double width = double.Parse(num2);

                    if (length==width)
                    {
                        Console.WriteLine("a rectangle is square");
                    }
                    else if (length!=width)
                    {
                        Console.WriteLine("a rectangle isn't square");
                    }
                    continue;
                }
                if (inputn == 0) {
                    Console.WriteLine("Exiting..");
                    break;
                }

            }

        }
    }
}
