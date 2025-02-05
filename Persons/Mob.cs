using PrototypeOtusLearning.Items;
using PrototypeOtusLearning.Weapons;

namespace PrototypeOtusLearning.Persons;

/// <summary>
/// Cущность, управляемые собственным ИИ
/// </summary>
internal class Mob(string name, int health, List<Item> items, List<Weapon> weapons) 
    : Person(name, health, items, weapons)
{
}
