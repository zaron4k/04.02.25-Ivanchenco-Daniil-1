using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class PersonalComputer
    {
        public string model;
        public double cpuFrequency;
        public int ramSize;
        public int hddSize;

        public PersonalComputer()
        {
            model = "Неизвестно";
            cpuFrequency = 0.0;
            ramSize = 0;
            hddSize = 0;
        }

        public PersonalComputer(string model)
        {
            this.model = model;
        }

        public PersonalComputer(string model, double cpuFrequency) : this(model)
        {
            this.cpuFrequency = cpuFrequency;
        }

        public PersonalComputer(string model, double cpuFrequency, int ramSize) : this(model, cpuFrequency)
        {
            this.ramSize = ramSize;
        }

        public PersonalComputer(string model, double cpuFrequency, int ramSize, int hddSize) : this(model, cpuFrequency, ramSize)
        {
            this.hddSize = hddSize;
        }

        public void Info()
        {
            Console.WriteLine($"Модель: {model}, Тактовая частота CPU: {cpuFrequency} ГГц, RAM: {ramSize} ГБ, HDD: {hddSize} ГБ");
        }

        public override string ToString()
        {
            return $"PC({model}, {cpuFrequency} ГГц, {ramSize} ГБ RAM, {hddSize} ГБ HDD)";
        }
    }
}
