global using NUnit.Framework;
using Prototype.Models;

namespace MyNamespace
{
    public class GlobalUsings
    {
        public static Person GeneratePerson()
        {
            return new Person("lastName", "firstName", "middleName", 180);
        }
        
        public static Person ChangePerson(Person person)
        {
            person.LastName = "newLastName";
            person.FirstName = "newFirstName";
            person.MiddleName = "newMiddleName";
            person.Growth = 185;
            
            return person;
        }
    }
}
