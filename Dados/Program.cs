using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAmount = 100;
            int amount, number;
            Random random = new Random();
            int diceNumber = random.Next(1, 6);

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                if (totalAmount <= 0)
                {
                    Console.WriteLine("No tienes dinero para apostar");
                    break;
                }
                   
                Console.WriteLine("JUEGO DE DADOS");
                Console.WriteLine($"Tienes {totalAmount} para jugar");

                do
                {
                    Console.Write($"Cuanto quieres apostar: ");
                    amount = Int32.Parse(Console.ReadLine());
                } while (amount > totalAmount);

                do
                {
                    Console.Write($"Ingresa un numero entre 1 y 6: ");
                    number = Int32.Parse(Console.ReadLine());
                } while (number < 1 || number > 6);


                if (number == diceNumber)
                {
                    totalAmount += amount;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Acertaste el dado cayo {diceNumber}, ahora tienes {totalAmount}");
                }
                else
                {
                    totalAmount -= amount;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Perdiste el dado cayo {diceNumber}, ahora tienes {totalAmount}");
                }
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
