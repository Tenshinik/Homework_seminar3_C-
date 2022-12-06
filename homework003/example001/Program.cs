/* 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Enter a five-digit number ");

int number = Convert.ToInt32(Console.ReadLine());

int temp = number;
int number2 = 0;

while(temp > 0)
{
    number2 = number2 * 10;
    number2 = number2 + (temp % 10);  
    temp = temp / 10;
}
Console.WriteLine(number == number2);
