using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler7
{
    class Program
    {
        static SortedSet<uint> primes;

        static void Main(string[] args)
        {
            primes = new SortedSet<uint>();
            primes.Add(2);
            primes.Add(3);

            uint n;
            uint.TryParse(args[0], out n);

            Console.WriteLine(NthPrime(n));
            Console.ReadLine();
        }

        static uint NthPrime(uint n)
        {
            while(primes.Count < n)
            {
                FindNextPrime();
            }
            return primes.Last();
        }

        static void FindNextPrime()
        {
            uint p = primes.Last() + 2;
            while(isPrime(p) == false)
            {
                p += 2;
            }
            primes.Add(p);
        }

        static bool isPrime(uint p)
        {
            foreach(uint n in primes)
            {
                if (p % n == 0)
                    return false;
                if (n > Math.Sqrt(p))
                    break;
            }
            return true;
        }
    }
}
