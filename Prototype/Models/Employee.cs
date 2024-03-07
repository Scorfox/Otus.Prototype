using Prototype.Interfaces;

namespace Prototype.Models;

/// <summary>
/// Работник
/// </summary>
public class Employee : Person, IMyCloneable<Employee>
{
    /// <summary>
    /// Наименование отдела
    /// </summary>
    public string DepartmentName { get; set; }
    
    public Employee(string lastName, string firstName, string middleName, string departmentName) 
        : base(lastName, firstName, middleName)
    {
        DepartmentName = departmentName;
    }

    public override Employee MyClone() => new(LastName, FirstName, MiddleName, DepartmentName);
}