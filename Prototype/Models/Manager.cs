namespace Prototype.Models;

/// <summary>
/// Менеджер
/// </summary>
public class Manager : Employee, ICloneable
{
    public Manager(string lastName, string firstName, string middleName, int growth) 
        : base(lastName, firstName, middleName, growth)
    {
    }
    
    object ICloneable.Clone() => Clone();
}