using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_project_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
                Console.Write("Enter Number1 :  ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("enter number2 :  ");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Prime numbers from " + n1 + " to " + n2 + " : ");
                int n, p, sum = 0;
                n = n1;
                while (n < n2)
                {
                    for (p = 1; p <= n; p++)
                    {
                        if ((n % p) == 0)
                            sum += p;
                    }
                    if (sum == n + 1)
                        Console.WriteLine(n);
                    sum = 0;
                    n++;
                }
            }
    }
}
