using System;

namespace PrototypeOtusLearning.Items;

/// <summary>
/// Произвольный предмет
/// </summary>
/// <param name="name"> Нименование </param>
public class Item(string name) : IMyCloneable<Item>, ICloneable
{
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; set; } = name;

    /// <summary>
    /// Запускаемый данным предметом процесс
    /// </summary>
    public ICloneable? ProcessRun { get; set; }

    public object Clone()
    {
        return ShallowClone();
    }

    public Item DeepClone()
    {
        Item item = ShallowClone();
        item.ProcessRun = ProcessRun==null ? null : (ICloneable)ProcessRun.Clone();
        return item;
    }

    public Item ShallowClone()
    {
        return (Item)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"{Name} {this.GetType()}";
    }
}
