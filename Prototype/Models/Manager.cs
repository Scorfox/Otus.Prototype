using Prototype.Interfaces;

namespace Prototype.Models;

/// <summary>
/// Менеджер
/// </summary>
public class Manager : Employee, IMyCloneable<Manager>
{
    /// <summary>
    /// Премия
    /// </summary>
    public double CashBonus { get; set; }
    
    public Manager(string lastName, string firstName, string middleName, string departmentName, double cashBonus) 
        : base(lastName, firstName, middleName, departmentName)
    {
        CashBonus = cashBonus;
    }
    
    public override Manager MyClone() => new(LastName, FirstName, MiddleName, DepartmentName, CashBonus);
}