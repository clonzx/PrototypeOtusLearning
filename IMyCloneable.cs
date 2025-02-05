namespace PrototypeOtusLearning;

public interface IMyCloneable<T> 
{
    /// <summary>
    /// Поверхностное копирование класса
    /// </summary>
    /// <returns>Копия существующего класса</returns>
    T ShallowClone();

    /// <summary>
    /// Глубокое копирование класса
    /// </summary>
    /// <returns>Копия существующего класса</returns>
    T DeepClone();
}
