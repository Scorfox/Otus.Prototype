namespace Prototype.Models;

/// <summary>
/// Работник
/// </summary>
public class Employee : Person, ICloneable
{
    public Employee(string lastName, string firstName, string middleName, int growth) 
        : base(lastName, firstName, middleName, growth)
    {
    }
    
    object ICloneable.Clone() => Clone();
}