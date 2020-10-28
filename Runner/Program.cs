using SequenceAnalysis;
using SumOfMultiple;
using System;
using System.Text.RegularExpressions;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var loopContinue = true;
            while (loopContinue)
            {
                Console.WriteLine("SumOfMultiple for 1");
                Console.WriteLine("SequenceAnalysis for 2");

                string _numberS = "";
                int _number = 0;
                Console.Write("Number Entry : ");
                _numberS = Console.ReadLine();
                bool res = int.TryParse(_numberS, out _number);
                if (res != true)
                {
                    Console.WriteLine("ONLY NUMBER!");
                    return;
                }




                switch (_number)
                {
                    case 1:
                        string s = "";
                        int number = 0;
                        Console.Write("SumOfMultiple Input : ");
                        s = Console.ReadLine();

                        bool res2 = int.TryParse(s, out number);
                        if (res2 != true)
                        {
                            Console.WriteLine("ONLY NUMBER!");
                            return;
                        }

                        var exampleSOM = new ExampleSOM();
                        var result = exampleSOM.Example(number);
                        Console.Write("SumOfMultiple Output : ");
                        Console.WriteLine(result);
                        break;
                    case 2:
                        string word;
                        Console.Write("SequenceAnalysis Input : ");
                        word = Console.ReadLine();

                        var w = Regex.IsMatch(word, @"^[a-zA-Z]+$");
                        if (w!=true)
                        {
                            Console.WriteLine("ONLY LETTERS!");
                            return;
                        }

                        var exampleSA = new ExampleSA();
                        var result2 = exampleSA.Example(word);
                        Console.Write("SequenceAnalysis Output : ");
                        Console.WriteLine(result2);
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

                Console.ReadLine();
            }

        }
    }
}
