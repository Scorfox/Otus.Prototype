using NUnit.Framework;
using Prototype.Models;

namespace Tests;

public static class PrototypeHelper
{  
    public static void AssertInitPersonEqualCopiedPerson(Person person, Person copiedPerson)
    {
        Assert.Multiple(() =>
        {
            Assert.That(copiedPerson.LastName, Is.EqualTo(person.LastName));
            Assert.That(copiedPerson.FirstName, Is.EqualTo(person.FirstName));
            Assert.That(copiedPerson.MiddleName, Is.EqualTo(person.MiddleName));
        });
    }
    
    public static void AssertInitEmployeeEqualCopiedEmployee(Employee employee, Employee copiedEmployee)
    {
        AssertInitPersonEqualCopiedPerson(employee, copiedEmployee);
        Assert.Multiple(() =>
        {
            Assert.That(employee.DepartmentName, Is.EqualTo(copiedEmployee.DepartmentName));
        });
    }
    
    public static void AssertInitManagerEqualCopiedManager(Manager manager, Manager copiedManager)
    {
        AssertInitEmployeeEqualCopiedEmployee(manager, copiedManager);
        Assert.Multiple(() =>
        {
            Assert.That(manager.CashBonus, Is.EqualTo(copiedManager.CashBonus));
        });
    }
    
    public static void AssertInitPersonNotEqualCopiedPerson(Person person, Person copiedPerson)
    {
        Assert.Multiple(() =>
        {
            Assert.That(copiedPerson.LastName, !Is.EqualTo(person.LastName));
            Assert.That(copiedPerson.FirstName, !Is.EqualTo(person.FirstName));
            Assert.That(copiedPerson.MiddleName, !Is.EqualTo(person.MiddleName));
        });
    }
    
    public static void AssertInitEmployeeNotEqualCopiedEmployee(Employee employee, Employee copiedEmployee)
    {
        AssertInitPersonNotEqualCopiedPerson(employee, copiedEmployee);
        Assert.Multiple(() =>
        {
            Assert.That(employee.DepartmentName, !Is.EqualTo(copiedEmployee.DepartmentName));
        });
    }
    
    public static void AssertInitManagerNotEqualCopiedManager(Manager manager, Manager copiedManager)
    {
        AssertInitEmployeeNotEqualCopiedEmployee(manager, copiedManager);
        Assert.Multiple(() =>
        {
            Assert.That(manager.CashBonus, !Is.EqualTo(copiedManager.CashBonus));
        });
    }
}