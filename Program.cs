// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");

string? num = Console.ReadLine();

if (num?[0]== num?[4]||num?[1] == num?[3])
{
    Console.WriteLine("Polindrom");
}
else
{
Console.WriteLine("Nepalindrom");
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите A: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите A: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите A: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

Console.WriteLine(d);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index<=x)
{
    Console.WriteLine(Math.Pow(index,3));
    index ++;
}