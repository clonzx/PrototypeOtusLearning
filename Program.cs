using PrototypeOtusLearning.Items;
using PrototypeOtusLearning.Persons;
using PrototypeOtusLearning.Weapons;
using System.Xml.Linq;

namespace PrototypeOtusLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Начальная Инициализация 
            var weapon1 = new Sword();
            var weapon2 = new Spear();
            var item1 = new Key("Key1");
            var item2 = new Food("Food1");
            var item3 = new Key("Key2");
            var item4 = new Food("Food2");

            var player1 = new Player("Player", 100,
                [item1, item2],
                [weapon1]);
            var mob1 = new Mob("Mob1", 100,
                [item3, item4],
                [weapon2]);

            Console.WriteLine($"----- Исходное сосотояние -------------");
            Console.WriteLine($"player1 = {player1}");
            Console.WriteLine($"mob1 = {mob1}");
            // Клонирование 1 способ
            Console.WriteLine($"----- Клонирование 1 способ -------------");
            var player2 = player1.Clone();
            var mob2 = mob1.Clone();
            Console.WriteLine($"player2 = {player2}");
            Console.WriteLine($"mob2 = {mob2}");
            // Клонирование 2 способ
            Console.WriteLine($"----- Клонирование 2 способ -------------");
            player2 = player1.DeepClone();
            mob2 = mob1.DeepClone();
            Console.WriteLine($"player2 = {player2}");
            Console.WriteLine($"mob2 = {mob2}");
        }
    }
}
