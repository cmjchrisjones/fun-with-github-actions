using System;

namespace FunWithGithubActions
{
    public static class Program
    {
        public static int Main()
        {
            Console.WriteLine("Input a:");
            var line = Console.ReadLine();
            if (!int.TryParse(line, out var a))
            {
                Console.WriteLine($"\"{line}\" is not parseable!");
                return -1;
            }
            
            Console.WriteLine("Input b:");
            line = Console.ReadLine();
            if (!int.TryParse(line, out var b))
            {
                Console.WriteLine($"\"{line}\" is not parseable!");
                return -1;
            }

            var result = Add(a, b);
            Console.WriteLine($"{a} + {b} = {Add(a, b)}");

            return result;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
