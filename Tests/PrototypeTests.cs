using NUnit.Framework;
using Prototype.Models;

namespace Tests;

public class Tests
{
    [Test]
    public void Test_PersonDeepCopying_ReturnsSuccess()
    {
        var initialPerson = GlobalUsings.GeneratePerson();
        var copiedPerson = initialPerson.MyClone();

        GlobalUsings.ChangePerson(copiedPerson);

        AssertInitPersonNotEqualCopiedPerson(initialPerson, copiedPerson);
    }
    
    [Test]
    public void Test_EmployeeDeepCopying_ReturnsSuccess()
    {
        var initialEmployee = GlobalUsings.GenerateEmployee();
        var copiedEmployee = initialEmployee.MyClone();
        
        GlobalUsings.ChangeEmployee(copiedEmployee);
        
        AssertInitEmployeeNotEqualCopiedEmployee(initialEmployee, copiedEmployee);
    }
    
    [Test]
    public void Test_ManagerDeepCopying_ReturnsSuccess()
    {
        var initialManager = GlobalUsings.GenerateManager();
        var copiedManager = initialManager.MyClone();
        
        GlobalUsings.ChangeManager(copiedManager);
        
        AssertInitManagerNotEqualCopiedManager(initialManager, copiedManager);
    }

    private static void AssertInitPersonNotEqualCopiedPerson(Person person, Person copiedPerson)
    {
        Assert.Multiple(() =>
        {
            Assert.That(copiedPerson.LastName, !Is.EqualTo(person.LastName));
            Assert.That(copiedPerson.FirstName, !Is.EqualTo(person.FirstName));
            Assert.That(copiedPerson.MiddleName, !Is.EqualTo(person.MiddleName));
        });
    }
    
    private static void AssertInitEmployeeNotEqualCopiedEmployee(Employee employee, Employee copiedEmployee)
    {
        AssertInitPersonNotEqualCopiedPerson(employee, copiedEmployee);
        Assert.Multiple(() =>
        {
            Assert.That(employee.DepartmentName, !Is.EqualTo(copiedEmployee.DepartmentName));
        });
    }
    
    private static void AssertInitManagerNotEqualCopiedManager(Manager manager, Manager copiedManager)
    {
        AssertInitEmployeeNotEqualCopiedEmployee(manager, copiedManager);
        Assert.Multiple(() =>
        {
            Assert.That(manager.CashBonus, !Is.EqualTo(copiedManager.CashBonus));
        });
    }
}