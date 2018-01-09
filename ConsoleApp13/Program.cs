using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            var summ = 1.0;
            var percent = 0.03;
            var score = 1.0;

            for (var i = 0; i < 2000; i++)
            {
                score =  score * percent + score;

            }
            Console.WriteLine(score);


        }
    }
}
