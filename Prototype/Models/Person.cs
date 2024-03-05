using Prototype.Interfaces;

namespace Prototype.Models;

/// <summary>
/// Персона
/// </summary>
public class Person : IMyCloneable<Person>, ICloneable
{
    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Отчество
    /// </summary>
    public string MiddleName { get; set; }
    /// <summary>
    /// Рост в см
    /// </summary>
    public int Growth { get; set; }

    public Person(string lastName, string firstName, string middleName, int growth)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        Growth = growth;
    }

    public virtual Person Clone() => new(LastName, FirstName, MiddleName, Growth);
    
    object ICloneable.Clone() => Clone();
}