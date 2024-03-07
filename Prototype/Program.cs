// See https://aka.ms/new-console-template for more information

using Prototype.Models;

var manager = new Manager("LastName1", "FirstName1", "MiddleName1", "DepartmentName1", 1000);
var manager2 = manager.MyClone();

manager2.LastName = "LastName2";
manager2.FirstName = "FirstName2";
manager2.MiddleName = "MiddleName2";
manager2.DepartmentName = "DepartmentName2";
manager2.CashBonus = manager.CashBonus + 1000;

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
    