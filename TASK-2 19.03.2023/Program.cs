// TASK-1
using static System.Console;
using static System.Convert;
Write("Öyrəndiyiniz proqramlaşdırma dilinin adı :");
string programlasdirmaDili = ReadLine();
Write("Ən yaxın dostunuzun adı :");
string yaxinDost = ReadLine();
Write("Qrupunuzun nömrəsi :");
string qurupNomresi = ReadLine();

WriteLine($"Mənim öyrəndiyim programlaşdırma dili {programlasdirmaDili}-dir,Mənim ən yaxın dostum {yaxinDost}-dır,Mənim Qrup nömrəm {yaxinDost}-dir.");

// TASK-2 

Write("1.Ededi daxil edin:");
int numberOne = ToInt32(ReadLine());
Write("2.Ededi daxil edin:");
int numberTwo = ToInt32(ReadLine());

WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");