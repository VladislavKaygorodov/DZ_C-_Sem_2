int number = new Random().Next(100,1000);
Console.WriteLine($"Рандомное число: {number}");

int NumOne = number / 100;
int NumTwo = number % 10;
int FinfNum = ( number - (NumOne * 100 + NumTwo)) / 10;

Console.WriteLine($"Вторым числом заданного значения является: {FinfNum}");