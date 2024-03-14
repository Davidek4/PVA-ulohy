using System;

namespace uloha3
{
    internal class Program
    {
        public static bool IsPalindrome(long num, int radix)
        {
            long reversed = 0;
            long original = num;

            while (num > 0)
            {
                reversed = reversed * (long)radix + num % (long)radix;
                num /= (long)radix;
            }

            return reversed == original;
        }

        public static bool NextPalindrome(long from, int radix, out long next)
        {
            next = 0;

            if (radix < 2 || radix > 36)
            {
                Console.WriteLine("Neplatná číselná soustava.");
                return false;
            }

            long current = from + 1;

            while (current > from)
            {
                if (IsPalindrome(current, radix))
                {
                    next = current;
                    return true;
                }
                current++;
            }
            Console.WriteLine("Nelze nalézt palindrom větší než zadané číslo.");
            return false;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Zadejte výchozí číslo:");
            long from = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte číselnou soustavu, ve které chcete najít palindrom:");
            int radix = int.Parse(Console.ReadLine());
            long next;

            if (NextPalindrome(from, radix, out next))
            {
                Console.WriteLine($"Nalezený palindrom v soustavě {radix} větší než {from}: {next}");
            }
            else
            {
                Console.WriteLine($"Nepodařilo se najít palindrom v soustavě {radix} větší než {from}.");
            }
            Console.ReadKey();
        }
    }
}
