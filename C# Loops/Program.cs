using System.Security.Cryptography.X509Certificates;
using static System.Console;
using static System.Convert;

//     TASK-Part 1 : 1 - dən 50 qədər 3artım ilə ədədlərin hasilini tapın 
{
    WriteLine("TASK-Part 1");
    long product = 1;

    for (long i = 1; i <= 50; i += 3)
    {
        product *= i;
    }
    WriteLine(long.MaxValue);
    WriteLine($"product : {product}");

}
//   TASK - part 2 :  -30 - dan 28 - ə qədər həm 3 həm 6 bölünən ədədlərin cəmini , 5 və ya 2 -  ə bölünənlərin hasilini  və tək ədədlərin sayını tapın
{
    WriteLine("TASK-Part 2");
    int sum = 0;
    long product = 1;
    int count = 0;

    for (int i = -30; i <= 28; i++)
    {
        if (i % 3 == 0 && i % 6 == 0)
        {
            sum += i;
        }
        if ((i % 2 == 0 || i % 5 == 0) && i != 0)
        {
            product = product * i;
        }
        if (i % 2 != 0)
        {
            count++;
        }
    }
    WriteLine($"sum : {sum}");
    WriteLine($"product : {product}");
    WriteLine($"count : {count}");

}


//    TASK-part 3 : 304001 ədədinin müsbət rəqəmlərinin cəmini müsbət və mənfi olmayan rəqəmlərinin sayını tapın

{
    WriteLine("TASK-Part 3");
    {
        int sum = 0;
        int count = 0;
        int index = 304001;
        int remainder = 0;
        while (index > 1)
        {
            if (index > 0)
            {
                remainder = index % 10;
                sum += remainder;
                index = index / 10;
                count++;
            }
        }
        WriteLine($"sum : {sum}");
        WriteLine($"count : {count}");
    }
}