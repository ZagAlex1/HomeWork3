// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int[] pointOne = SetPoint("Введите координаты первой точки : ");
int[] pointTwo = SetPoint("Введите координаты второй точки : ");

ReadPoint("Координаты первой точки ", pointOne);
ReadPoint("Координаты второй точки ", pointTwo);

System.Console.WriteLine("Расстояние между точками : " +
DistanceBetweenPoints(pointOne, pointTwo));

double DistanceBetweenPoints(int[] arrayOne, int[] arrayTwo)
{
  double distanceBetweenPoints = Math.Sqrt(Math.Pow((arrayTwo[0] - arrayOne[0]), 2)
                                        + Math.Pow((arrayTwo[1] - arrayOne[1]), 2)
                                        + Math.Pow((arrayTwo[2] - arrayOne[2]), 2));
  return distanceBetweenPoints;
}

void ReadPoint(string pointNumber, int[] array)
{
  Console.WriteLine($"{pointNumber}: X = {array[0]}, Y = {array[1]}, Z = {array[2]}");
}

int[] SetPoint(string greeting)
{
  System.Console.Write(greeting);
  int[] array = new int[3];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  return array;
}