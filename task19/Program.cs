//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Ведите пятизначное число: ");
string? number = (Console.ReadLine());
int count = number.Length;
if (count <5 || count >5)
{
    Console.WriteLine("Вы ввели не пятизначное число!!!");
}

else if (number[0] == number[4] && number[1]== number[3])
 {
 Console.WriteLine($"Число {number} являетя палиндромом");
 }
 else
{
 Console.WriteLine($"Число {number} не являетя палиндромом");  
 }

