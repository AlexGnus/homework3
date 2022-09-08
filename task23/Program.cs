//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите любое число от 1 до N: ");

int end = Convert.ToInt32(Console.ReadLine());
for (int start =1; start <= end; start++)
{
    Console.Write($"{Math.Pow(start,3)}  ");
}