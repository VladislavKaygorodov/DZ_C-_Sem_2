int number = new Random().Next(10,1000);
Console.WriteLine($"Рандомное число: {number}");

if ( number / 100 == 0)
{
    Console.WriteLine("Ошибка, число не являтся трехзначным");
}
else
{
    int FindNum = number % 10;
    Console.WriteLine($"Третьим числом заданного значения является: {FindNum}");
}