using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1,4,5,3,5,6,7,8,4};

            Console.WriteLine(Variance.simple_variance(myArray));
        }
    }
}
