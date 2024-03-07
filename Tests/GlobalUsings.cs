using Prototype.Models;

namespace Tests
{
    public class GlobalUsings
    {
        public static Person GeneratePerson()
            => new("lastName", "firstName", "middleName");
        
        public static Employee GenerateEmployee()
            => new("lastName", "firstName", "middleName", "departmentName");
        
        public static Manager GenerateManager()
            => new("lastName", "firstName", "middleName", "departmentName", 1000);
        
        public static void ChangePerson(Person person)
        {
            person.LastName = "newLastName";
            person.FirstName = "newFirstName";
            person.MiddleName = "newMiddleName";
        }
        
        public static void ChangeEmployee(Employee employee)
        {
            ChangePerson(employee);
            employee.DepartmentName = "NewDepartmentName";
        }
        
        public static void ChangeManager(Manager manager)
        {
            ChangeEmployee(manager);
            manager.CashBonus += 1000;
        }
    }
}
