using Microsoft.VisualBasic;
using System.Resources;
using System.Security.Cryptography;
using static System.Console;
using static System.Convert;

// TASK PART 1

Write("Department :");
string departmentName = ReadLine();
if (departmentName == "HR")
{
    WriteLine("Human Resources Department");
}
else if (departmentName == "IT")
{
    WriteLine("Information Technology Department");
}
else if (departmentName == "Finance")
{
    WriteLine("Finance Department");
}
else
{
    WriteLine("There is no such department");
}

// TASK PART 2

Write("Staj :");
int stajYear = ToInt32(ReadLine());

if (stajYear >= 0 && stajYear <=2)
{
    WriteLine("Your salary is 2000");
}else if (stajYear >=3 && stajYear <=5)
{
    WriteLine("Your salary is 5000");
}else if (stajYear >5 && stajYear <=10)
{
    WriteLine("Your salary is 7000");
}else 
{
    WriteLine("Your salary is 10000");
}