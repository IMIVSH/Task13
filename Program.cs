// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Введите ваше число");
int number = int.Parse(Console.ReadLine()!);
int revNumber = 0;
int operateNumber = 0;

if(number < 0)
{
    operateNumber = number * -1;
}
else
{
    operateNumber = number;
}

while(operateNumber > 0)
{
    revNumber = (revNumber * 10) + (operateNumber % 10);
    operateNumber = operateNumber / 10;
}

revNumber = revNumber / 10;
revNumber = revNumber / 10;
revNumber = revNumber % 10;

if(revNumber == 0)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine(revNumber);
}