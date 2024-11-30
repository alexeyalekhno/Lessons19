using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
            new Computer(){Code=1, Brand = "HP", CPU = "AMD", Frequency = 3.30, RAM = 4, HardDrive = 512, VideoCard = 4, Price = 51999.99, NumberCopies = 5 },
            new Computer(){Code=2, Brand = "ASUS", CPU = "Intel", Frequency = 4.40, RAM = 8, HardDrive = 1024, VideoCard = 6, Price = 81200.20, NumberCopies = 31 },
            new Computer(){Code=3, Brand = "AsRock", CPU = "AMD", Frequency = 2.80, RAM = 8, HardDrive = 2048, VideoCard = 8, Price = 73400.99, NumberCopies = 8 },
            new Computer(){Code=4, Brand = "HP", CPU = "AMD", Frequency = 3.60, RAM = 16, HardDrive = 1024, VideoCard = 4, Price = 52300.20, NumberCopies = 6 },
            new Computer(){Code=5, Brand = "Lenovo", CPU = "Intel", Frequency = 3, RAM = 32, HardDrive = 1024, VideoCard = 4, Price = 58600.60, NumberCopies = 10},
            new Computer(){Code=6, Brand = "Acer", CPU = "Эльбрус", Frequency = 1.80, RAM = 4, HardDrive = 512, VideoCard = 2, Price = 91000.00, NumberCopies = 1 },
            };

            Console.WriteLine("Введите компьютер с каким процессором вас интересует:");
            string cpu = Console.ReadLine();
            List<Computer> computers1 = computers.Where(c => c.CPU == cpu).ToList();
            Print(computers1);


            Console.WriteLine("Введите какую хотите минимальную оперативную память:");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(c => c.RAM >= ram).ToList();
            Print(computers2);

            List<Computer> computers3 = computers.OrderBy(c => c.Price).ToList();
            Print(computers3);

            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(c => c.CPU);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"{c.Code} {c.Brand} {c.CPU} {c.CPU} {c.Frequency} {c.RAM} {c.HardDrive} {c.VideoCard} {c.Price} {c.NumberCopies}");
                }
            }

            Computer computer5 = computers.OrderByDescending(c => c.Price).FirstOrDefault();
            Console.WriteLine($"{computer5.Code} {computer5.Brand} {computer5.CPU} {computer5.CPU} {computer5.Frequency} {computer5.RAM} {computer5.HardDrive} {computer5.VideoCard} {computer5.Price} {computer5.NumberCopies}");
            Computer computer6 = computers.OrderBy(c => c.Price).FirstOrDefault();
            Console.WriteLine($"{computer6.Code} {computer6.Brand} {computer6.CPU} {computer6.CPU} {computer6.Frequency} {computer6.RAM} {computer6.HardDrive} {computer6.VideoCard} {computer6.Price} {computer6.NumberCopies}");

            Console.WriteLine(computers.Any(c=>c.NumberCopies>30));

            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Code} {c.Brand} {c.CPU} {c.CPU} {c.Frequency} {c.RAM} {c.HardDrive} {c.VideoCard} {c.Price} {c.NumberCopies}");
            }
            Console.WriteLine();
        }
    }

    
}

