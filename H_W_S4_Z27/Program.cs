// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {num} равна { GetSum(num)}");

int GetSum(int num){
  int sum = 0;
  while(num > 0)
  {
    sum += num%10;
    num /=10;
  } 
  return sum;
}
