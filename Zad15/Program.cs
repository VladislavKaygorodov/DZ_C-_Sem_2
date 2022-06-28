int number = new Random().Next(1,8);
Console.WriteLine($"Номер дня недели: {number}");

for (;number < 5;)
{
    Console.WriteLine("Выбранное число является буднем днем: ");
    if (number == 1)
    {
    Console.Write("понедельник");
    }
   if (number == 2)
    {
    Console.Write("вторник");
    }
    if (number == 3)
    {
    Console.Write("среда");
    }
    if (number == 4)
    {
    Console.Write("четверг");
    }
    if (number == 5)
    {
    Console.Write("пятница");
    }
    break;
}

for (;number >5;)
{
    Console.WriteLine("Выбранное число является выходным днем: ");
    if (number == 6)
    {
    Console.Write("суббота");
    }
    else
    {
      Console.Write("воскресенье");  
    }
    break;
}
