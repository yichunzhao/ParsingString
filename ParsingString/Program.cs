using System;

namespace ParsingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parsing double string");
            var target = "0.2";
            Console.WriteLine("Parsing " + target);

            double result = Double.Parse(target);
            CheckResult(result);

            var _target = "0,2";
            Console.WriteLine("Parsing " + _target);
            double _result = Double.Parse(_target);
            CheckResult(_result);

            //add a new commit
        }

        private static void CheckResult(double result)
        {
            Console.WriteLine(result);
            
            if (result == 0.2)
            {
                Console.WriteLine("result is 0.2");
            }

            if (result == 2)
            {
                Console.WriteLine("result is 2");
            }
        }
    }
}