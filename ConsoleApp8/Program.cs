using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalComputer pc1 = new PersonalComputer();
            pc1.Info();
            Console.WriteLine(pc1.ToString());

            PersonalComputer pc2 = new PersonalComputer("Dell XPS", 3.5, 16, 512);
            pc2.Info();
            Console.WriteLine(pc2);

            Console.Write("Введите модель ПК: ");
            string model = Console.ReadLine();
            Console.Write("Введите тактовую частоту процессора (ГГц): ");
            double cpuFrequency = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите объем RAM (ГБ): ");
            int ramSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите объем HDD (ГБ): ");
            int hddSize = Convert.ToInt32(Console.ReadLine());

            PersonalComputer pc3 = new PersonalComputer(model, cpuFrequency, ramSize, hddSize);
            pc3.Info();
            Console.WriteLine(pc3);
        }
    }
}
