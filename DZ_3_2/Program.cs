// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите X координату точки A");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y координату точки A");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z координату точки A");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите X координату точки B");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y координату точки B");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z координату точки B");
double zb = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xb-xa),2) + Math.Pow((yb-ya),2) + Math.Pow((zb-za),2));

Console.WriteLine();
Console.Write("Длина отрезка АВ: ");
System.Console.WriteLine(distance);
Console.WriteLine();