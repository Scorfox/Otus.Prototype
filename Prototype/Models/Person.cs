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

    public Person(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }

    public virtual Person MyClone() => new(LastName, FirstName, MiddleName);
    
    public object Clone() => MyClone();
}