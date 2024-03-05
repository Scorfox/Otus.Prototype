// See https://aka.ms/new-console-template for more information

using Prototype.Models;

var manager = new Manager("LastName1", "FirstName1", "MiddleName1", 180);
var manager2 = manager.Clone();

manager2.LastName = "LastName2";
manager2.FirstName = "FirstName2";
manager2.MiddleName = "MiddleName2";
manager2.Growth = 195;

Console.WriteLine($"Manager1: LastName {manager.LastName}, FirstName: {manager.FirstName}, MiddleName: {manager.MiddleName}, Growth: {manager.Growth}");
Console.WriteLine($"Manager2: LastName {manager2.LastName}, FirstName: {manager2.FirstName}, MiddleName: {manager2.MiddleName}, Growth: {manager2.Growth}");
    