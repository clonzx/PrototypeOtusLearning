using PrototypeOtusLearning.Weapons;
using PrototypeOtusLearning.Items;

namespace PrototypeOtusLearning.Persons;

/// <summary>
/// Класс персонажа
/// </summary>
/// <param name="name"> Имя </param>
/// <param name="health"> Здоровье </param>
/// <param name="items"> Предметы </param>
/// <param name="weapons"> Оружие </param>
public class Person(string name, int health, List<Item> items, List<Weapon> weapons) : IMyCloneable<Person>, ICloneable
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = name;

    public int Health { get; set; } = health;

    public List<Item> Items { get; set; } = items;

    public List<Weapon> Weapons { get; set; } = weapons;

    public object Clone()
    {
        return ShallowClone();
    }

    public Person DeepClone()
    {
        Person person = ShallowClone();
        person.Id = Guid.NewGuid();
        person.Items = [];
        foreach (var item in Items)
        {
            person.Items.Add(item.DeepClone());
        }
        return person;
    }

    public Person ShallowClone()
    {
        return (Person)MemberwiseClone();
    }

    public override string ToString()
    {
        string itemsString = Items == null ? "" : String.Join(",",Items.Select(item => item.ToString()));
        string weaponsString = Weapons == null ? "" : String.Join(",", Weapons.Select(item => item.ToString()));
        return $"{Name} Id={Id} health:{Health}\n" +
            $"Items({itemsString})\n" +
            $"Weapons({weaponsString})\n";
    }
}
