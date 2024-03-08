// See https://aka.ms/new-console-template for more information

using Prototype.Models;

var manager = new Manager("LastName1", "FirstName1", "MiddleName1", "DepartmentName1", 1000);
var manager2 = manager.MyClone();
var manager3 = (Manager)manager.Clone();

manager2.LastName = "LastName2";
manager2.FirstName = "FirstName2";
manager2.MiddleName = "MiddleName2";
manager2.DepartmentName = "DepartmentName2";
manager2.CashBonus = manager.CashBonus + 1000;

manager3.LastName = "LastName3";
manager3.FirstName = "FirstName3";
manager3.MiddleName = "MiddleName3";
manager3.DepartmentName = "DepartmentName3";
manager3.CashBonus = manager.CashBonus + 2000;

Console.WriteLine($"Manager1: " +
                  $"LastName {manager.LastName}, " +
                  $"FirstName: {manager.FirstName}, " +
                  $"MiddleName: {manager.MiddleName}, " +
                  $"DepartmentName: {manager.DepartmentName}, " +
                  $"CashBonus: {manager.CashBonus}");

Console.WriteLine($"Manager2: " +
                  $"LastName {manager2.LastName}, " +
                  $"FirstName: {manager2.FirstName}, " +
                  $"MiddleName: {manager2.MiddleName}, " +
                  $"DepartmentName: {manager2.DepartmentName}, " +
                  $"CashBonus: {manager2.CashBonus}");

Console.WriteLine($"Manager3: " +
                  $"LastName {manager3.LastName}, " +
                  $"FirstName: {manager3.FirstName}, " +
                  $"MiddleName: {manager3.MiddleName}, " +
                  $"DepartmentName: {manager3.DepartmentName}, " +
                  $"CashBonus: {manager3.CashBonus}");

    