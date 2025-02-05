namespace PrototypeOtusLearning.Weapons;

public class Weapon : IMyCloneable<Weapon>, ICloneable
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int MaxUseCount { get; set; }

    public object Clone()
    {
        return ShallowClone();
    }

    public Weapon DeepClone()
    {
        return ShallowClone();
    }

    public Weapon ShallowClone()
    {
        return (Weapon)MemberwiseClone();
    }
    public override string ToString()
    {
        return $"{Name} {GetType()}";
    }
}
