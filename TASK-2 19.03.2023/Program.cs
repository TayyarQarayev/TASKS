// TASK-1
using static System.Console;
using static System.Convert;
using static System.Math;

//Write("Öyrəndiyiniz proqramlaşdırma dilinin adı :");
//string programlasdirmaDili = ReadLine();
//Write("Ən yaxın dostunuzun adı :");
//string yaxinDost = ReadLine();
//Write("Qrupunuzun nömrəsi :");
//string qurupNomresi = ReadLine();

//WriteLine($"Mənim öyrəndiyim programlaşdırma dili {programlasdirmaDili}-dir,Mənim ən yaxın dostum {yaxinDost}-dır,Mənim Qrup nömrəm {yaxinDost}-dir.");

//// TASK-2  

//Write("1.Ededi daxil edin:");
//int numberOne = ToInt32(ReadLine());
//Write("2.Ededi daxil edin:");
//int numberTwo = ToInt32(ReadLine());

//WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
//WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
//WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");

// TASK-3 riyazi ifadenin helli

double x, y, z;

Write("x-i daxil edin:");
 x = ToDouble(ReadLine());
Write("z-i daxil edin:");
 z = ToDouble(ReadLine());

y = (Abs((Sqrt(x) * Pow(z,4.0/3)) / Pow(z,3) * Sqrt(x) - Abs(Sqrt(x)))); 

WriteLine($"y = {y}");
