//  5 elementdən ibarət tələbə massivi yaradın. Massivin dəyərlərini istifadəçidən alın. Sonra isə dəyərləri ekranda göstərin 

string[] students = new string[5];

for (int i = 0; i < students.Length; i++)
{
    Console.Write($"Student {i + 1}: ");
    students[i] = Console.ReadLine();
}

foreach (var student in students) 
{ 
    Console.Write($"Student :");
    Console.WriteLine(student);
}