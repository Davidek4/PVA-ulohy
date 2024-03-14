using System;

namespace Body_v_rovině
{
    internal class Program
    {
        static void Main(string[] args)
        {
        zacatek:

            // Zadání souřadnic (v případě chybného vstupu jde sem)

            Console.WriteLine("bod A osa x");

            double XAsouradnice;
            if (!double.TryParse(Console.ReadLine(), out XAsouradnice))
            {
                Console.WriteLine("Špatný vstup");
                Console.ReadLine();
                Console.Clear();
                goto zacatek;
            }

            Console.WriteLine("bod A osa y");

            double YAsouradnice;
            if (!double.TryParse(Console.ReadLine(), out YAsouradnice))
            {
                Console.WriteLine("Špatný vstup");
                Console.ReadLine();
                Console.Clear();
                goto zacatek;
            }

            Console.WriteLine("bod B osa x");

            double XBsouradnice;
            if (!double.TryParse(Console.ReadLine(), out XBsouradnice))
            {
                Console.WriteLine("Špatný vstup");
                Console.ReadLine();
                Console.Clear();
                goto zacatek;
            }

            Console.WriteLine("bod B osa y");

            double YBsouradnice;
            if (!double.TryParse(Console.ReadLine(), out YBsouradnice))
            {
                Console.WriteLine("Špatný vstup");
                Console.ReadLine();
                Console.Clear();
                goto zacatek;
            }

            Console.WriteLine("bod C osa x");

            double XCsouradnice;
            if (!double.TryParse(Console.ReadLine(), out XCsouradnice))
            {
                Console.WriteLine("Špatný vstup");
                Console.ReadLine();
                Console.Clear();
                goto zacatek;
            }

            Console.WriteLine("bod C osa y");

            double YCsouradnice;
            if (!double.TryParse(Console.ReadLine(), out YCsouradnice))
            {
                Console.WriteLine("Špatný vstup");
                Console.ReadLine();
                Console.Clear();
                goto zacatek;
            }

            // Počítání sklonu

            double rozdilYAB = YBsouradnice - YAsouradnice;
            double rozdilXAB = XBsouradnice - XAsouradnice;

            double sklonAB = rozdilYAB / rozdilXAB;

            double rozdilYBC = YCsouradnice - YBsouradnice;
            double rozdilXBC = XCsouradnice - XBsouradnice;

            double sklonBC = rozdilYBC / rozdilXBC;

            // Zjišťování jestli jsou některé body na stejném místě

            if (XAsouradnice == XBsouradnice && XAsouradnice == XCsouradnice && XBsouradnice == XCsouradnice && YAsouradnice == YBsouradnice && YAsouradnice == YCsouradnice && YBsouradnice == YCsouradnice)
            {
                Console.WriteLine("Všechny body jsou ve stejném místě");
            }

            else if (XAsouradnice == XBsouradnice && YAsouradnice == YBsouradnice)
            {
                Console.WriteLine("Body A a B jsou ve stejném místě");
            }

            else if (XAsouradnice == XCsouradnice && YAsouradnice == YCsouradnice)
            {
                Console.WriteLine("Body A a C jsou ve stejném místě");
            }

            else if (XBsouradnice == XCsouradnice && YBsouradnice == YCsouradnice)
            {
                Console.WriteLine("Body B a C jsou ve stejném místě");
            }

            // Zjišťování jestli jsou body na jedné přímce

            else if (XAsouradnice == XBsouradnice && XAsouradnice == XCsouradnice)
            {
                Console.WriteLine("Body leží na jedné přímce");
            }

            else if (Math.Abs(sklonAB - sklonBC) < 0.0000001)  // 1 = 1
            {
                Console.WriteLine("Body leží na jedné přímce");
            }

            else
            {
                Console.WriteLine("Body neleží na jedné přímce");
            }

            //------------------------------------------------------------------------------------------------------------

            // Hledání prostředního bodu

            if ((XAsouradnice + XBsouradnice) == 2 * XCsouradnice && (YAsouradnice + YBsouradnice) == 2 * YCsouradnice)
            {
                Console.WriteLine("Prostřední je bod C");
                Console.ReadKey();
            }

            else if ((XBsouradnice + XCsouradnice) == 2 * XAsouradnice && (YBsouradnice + YCsouradnice) == 2 * YAsouradnice)
            {
                Console.WriteLine("Prostřední je bod A");
                Console.ReadKey();
            }

            else if ((XAsouradnice + XCsouradnice) == 2 * XBsouradnice && (YAsouradnice + YCsouradnice) == 2 * YBsouradnice)
            {
                Console.WriteLine("Prostřední je bod B");
                Console.ReadKey();
            }

            else if ((YAsouradnice == YBsouradnice && YAsouradnice == YCsouradnice) && ((XAsouradnice > XBsouradnice && XBsouradnice > XCsouradnice) || (XAsouradnice < XBsouradnice && XBsouradnice < XCsouradnice)))
            {
                Console.WriteLine("Prosřední je bod B");
                Console.ReadKey();
            }

            else if ((YAsouradnice == YBsouradnice && YAsouradnice == YCsouradnice) && ((XBsouradnice > XAsouradnice && XAsouradnice > XCsouradnice) || (XBsouradnice < XAsouradnice && XAsouradnice < XCsouradnice)))
            {
                Console.WriteLine("Prosřední je bod A");
                Console.ReadKey();
            }

            else if ((YAsouradnice == YBsouradnice && YAsouradnice == YCsouradnice) && ((XAsouradnice > XCsouradnice && XCsouradnice > XBsouradnice) || (XAsouradnice < XCsouradnice && XCsouradnice < XBsouradnice)))
            {
                Console.WriteLine("Prosřední je bod C");
                Console.ReadKey();
            }

            else if ((XAsouradnice == YAsouradnice && XBsouradnice == YBsouradnice && XCsouradnice == YCsouradnice) && ((XAsouradnice > XCsouradnice && XCsouradnice > XBsouradnice) || (XAsouradnice < XCsouradnice && XCsouradnice < XBsouradnice)))
            {
                Console.WriteLine("Prosřední je bod C");
                Console.ReadKey();
            }

            else if ((XAsouradnice == YAsouradnice && XBsouradnice == YBsouradnice && XCsouradnice == YCsouradnice) && ((XBsouradnice > XAsouradnice && XAsouradnice > XCsouradnice) || (XBsouradnice < XAsouradnice && XAsouradnice < XCsouradnice)))
            {
                Console.WriteLine("Prosřední je bod A");
                Console.ReadKey();
            }

            else if ((XAsouradnice == YAsouradnice && XBsouradnice == YBsouradnice && XCsouradnice == YCsouradnice) && ((XAsouradnice > XBsouradnice && XBsouradnice > XCsouradnice) || (XAsouradnice < XBsouradnice && XBsouradnice < XCsouradnice)))
            {
                Console.WriteLine("Prosřední je bod B");
                Console.ReadKey();
            }

            else
            {
                Console.ReadKey();
            }
        }
    }
}
