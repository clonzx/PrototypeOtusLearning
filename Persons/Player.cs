using PrototypeOtusLearning.Items;
using PrototypeOtusLearning.Weapons;

namespace PrototypeOtusLearning.Persons;

/// <summary>
/// Персонаж управляемый игроком
/// </summary>
public class Player(string name, int health, List<Item> items, List<Weapon> weapons) 
    : Person(name, health, items, weapons)
{
}
