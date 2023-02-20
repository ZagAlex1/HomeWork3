// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Cubing(PutNumber("Введите число : "));

void Cubing(int number)
{
  for (int i = 1; i <= number; i++)
  {
    System.Console.Write(Math.Pow(i, 3) + " ");
  }
}

int PutNumber(string greeting)
{
  System.Console.Write(greeting);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}
