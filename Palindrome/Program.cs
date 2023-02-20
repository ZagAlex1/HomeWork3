// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();

PalicOrNo(PutNumber("Введите пятизначное число : "));

char[] PutNumber(string greeting)
{
  System.Console.Write(greeting);
  while (true)
  {
    int number = Convert.ToInt32(Console.ReadLine());
    char[] array = number.ToString().ToCharArray();
    if (array.Length != 5)
      System.Console.WriteLine("Введите правильное число!!!");
    else
      return array;
  }
}

void PalicOrNo(char[] array)
{
  if (array[0] == array[array.Length - 1] && array[1] == array[array.Length - 2])
    System.Console.WriteLine("Число палиндром");
  else
    System.Console.WriteLine("Число не палиндром");
}




