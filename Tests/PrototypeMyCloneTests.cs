using NUnit.Framework;

namespace Tests;

public class PrototypeMyCloneTests
{
    [Test]
    public void Test_PersonDeepCopying_ReturnsSuccess()
    {
        var initialPerson = GlobalUsings.GeneratePerson();
        var copiedPerson = initialPerson.MyClone();

        PrototypeHelper.AssertInitPersonEqualCopiedPerson(initialPerson, copiedPerson);
        
        GlobalUsings.ChangePerson(copiedPerson);

        PrototypeHelper.AssertInitPersonNotEqualCopiedPerson(initialPerson, copiedPerson);
    }
    
    [Test]
    public void Test_EmployeeDeepCopying_ReturnsSuccess()
    {
        var initialEmployee = GlobalUsings.GenerateEmployee();
        var copiedEmployee = initialEmployee.MyClone();
        
        PrototypeHelper.AssertInitEmployeeEqualCopiedEmployee(initialEmployee, copiedEmployee);
        
        GlobalUsings.ChangeEmployee(copiedEmployee);
        
        PrototypeHelper.AssertInitEmployeeNotEqualCopiedEmployee(initialEmployee, copiedEmployee);
    }
    
    [Test]
    public void Test_ManagerDeepCopying_ReturnsSuccess()
    {
        var initialManager = GlobalUsings.GenerateManager();
        var copiedManager = initialManager.MyClone();
        
        PrototypeHelper.AssertInitManagerEqualCopiedManager(initialManager, copiedManager);
        
        GlobalUsings.ChangeManager(copiedManager);
        
        PrototypeHelper.AssertInitManagerNotEqualCopiedManager(initialManager, copiedManager);
    }
}