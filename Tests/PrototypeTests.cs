using MyNamespace;
using Prototype.Models;

namespace Tests;

public class Tests
{
    [Test]
    public void Test_PersonDeepCopying_ReturnsSuccess()
    {
        var initialPerson = GlobalUsings.GeneratePerson();
        var copiedPerson = initialPerson.Clone();

        GlobalUsings.ChangePerson(copiedPerson);

        AssertInitPersonNotEqualCopiedPerson(initialPerson, copiedPerson);
    }
    
    [Test]
    public void Test_EmployeeDeepCopying_ReturnsSuccess()
    {
        var initialEmployee = new Employee("lastName", "firstName", "middleName", 180);
        var copiedEmployee = initialEmployee.Clone();
        
        GlobalUsings.ChangePerson(copiedEmployee);
        
        AssertInitPersonNotEqualCopiedPerson(initialEmployee, copiedEmployee);
    }
    
    [Test]
    public void Test_ManagerDeepCopying_ReturnsSuccess()
    {
        var initialManager = new Manager("lastName", "firstName", "middleName", 180);
        var copiedManager = initialManager.Clone();
        
        GlobalUsings.ChangePerson(copiedManager);
        
        AssertInitPersonNotEqualCopiedPerson(initialManager, copiedManager);
    }

    private static void AssertInitPersonNotEqualCopiedPerson(Person person, Person copiedPerson)
    {
        Assert.Multiple(() =>
        {
            Assert.That(copiedPerson.LastName, !Is.EqualTo(person.LastName));
            Assert.That(copiedPerson.FirstName, !Is.EqualTo(person.FirstName));
            Assert.That(copiedPerson.MiddleName, !Is.EqualTo(person.MiddleName));
            Assert.That(copiedPerson.Growth, !Is.EqualTo(person.Growth));
        });
    }
}