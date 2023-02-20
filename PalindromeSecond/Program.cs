// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

TestPalindrome(PutNumber("Введите пятизначное число : "));

void TestPalindrome(int number)
{
  if ((number / 10000) == (number % 10) &&
  (number / 1000) % 10 == (number / 10) % 10)
    System.Console.WriteLine("Это палиндром");
  else
    System.Console.WriteLine("Это не палиндром");
}

int PutNumber(string greeting)
{
  System.Console.Write(greeting);
  while (true)
  {
    int number = Convert.ToInt32(Console.ReadLine());
    if (number / 10000 == 0 || number / 10000 > 9)
      System.Console.Write("Введите правильное число : ");
    else
      return number;
  }
}
