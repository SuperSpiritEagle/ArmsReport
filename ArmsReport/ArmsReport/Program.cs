using System;
using System.Collections.Generic;
using System.Linq;

namespace ArmsReport
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>
            {
                new Soldier("Иванов Иван Иванович", "AK-47", "Сержант", 36),
                new Soldier("Петров Петр Петрович", "M4A1", "Рядовой", 24),
                new Soldier("Сидоров Сидор Сидорович", "PKM", "Старший сержант", 42),
                new Soldier("Кузнецов Кузьма Кузьмич", "RPK", "Младший сержант", 30),
                new Soldier("Смирнов Александр Александрович", "MP5", "Младший сержант", 28)
            };

            var soldierNamesAndRanks = soldiers.Select(soldier => new { soldier.Name, soldier.Rank });

            foreach (var soldier in soldierNamesAndRanks)
            {
                Console.WriteLine($"Имя: {soldier.Name}, Звание: {soldier.Rank}");
            }
        }
    }

    public class Soldier
    {
        public Soldier(string name, string weapon, string rank, int servicePeriodInMonths)
        {
            Name = name;
            Weapon = weapon;
            Rank = rank;
            ServicePeriodInMonths = servicePeriodInMonths;
        }

        public string Name { get; }
        public string Weapon { get; }
        public string Rank { get; }
        public int ServicePeriodInMonths { get; }
    }
}
