using NUnit.Framework;
using Prototype.Models;

namespace Tests;

public class PrototypeCloneTests
{
    [Test]
    public void Test_PersonDeepCopying_ReturnsSuccess()
    {
        var initialPerson = GlobalUsings.GeneratePerson();
        var copiedPerson = (Person)initialPerson.Clone();
        
        PrototypeHelper.AssertInitPersonEqualCopiedPerson(initialPerson, copiedPerson);
        
        GlobalUsings.ChangePerson(copiedPerson);

        PrototypeHelper.AssertInitPersonNotEqualCopiedPerson(initialPerson, copiedPerson);
    }
    
    [Test]
    public void Test_EmployeeDeepCopying_ReturnsSuccess()
    {
        var initialEmployee = GlobalUsings.GenerateEmployee();
        var copiedEmployee = (Employee)initialEmployee.Clone();
        
        PrototypeHelper.AssertInitEmployeeEqualCopiedEmployee(initialEmployee, copiedEmployee);
        
        GlobalUsings.ChangeEmployee(copiedEmployee);
        
        PrototypeHelper.AssertInitEmployeeNotEqualCopiedEmployee(initialEmployee, copiedEmployee);
    }
    
    [Test]
    public void Test_ManagerDeepCopying_ReturnsSuccess()
    {
        var initialManager = GlobalUsings.GenerateManager();
        var copiedManager = (Manager)initialManager.Clone();
        
        PrototypeHelper.AssertInitManagerEqualCopiedManager(initialManager, copiedManager);
        
        GlobalUsings.ChangeManager(copiedManager);
        
        PrototypeHelper.AssertInitManagerNotEqualCopiedManager(initialManager, copiedManager);
    }
}