// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

System.Console.WriteLine();
Console.Write("Массив:");
System.Console.WriteLine();
double [] array = GetArray(8,100,1000); // размер, мин и макс значения

double[]GetArray (int size, int minValue, int maxValue)
{
  double[] res = new double [size];
  for (int i = 0; i < size; i++)
    {
    res[i] = new Random().Next(minValue, maxValue)/10.0;  
    }
    return res;
}
Console.WriteLine(String.Join(" ", array));
// Console.WriteLine("Минимальный элемент массива  =   "  + array.Min());         // простой вывод мин
// System.Console.WriteLine("Максимальный элемент массива  =   "  +array.Max());   // простой вывод макс




void dif(double[]array)
{
int i=0;
double max = array[0];
double min = array[0];
array[i] = max;
array[i] = min;
for (; i<array.Length; i++)
{
  if (array[i]>max)
  {
      max = array[i];
  }
  if (array[i]<min)
  {
      min = array[i];
  }
}
System.Console.WriteLine("Максимальный элемент массива =  " + max);

// int j=0;
// double min = 100;
// array[j] = min;
// for (; j<array.Length; j++)
// {
//   if (array[j]<min)
//   {
//       min = array[j];
//   }
// }
System.Console.WriteLine("Минимальный элемент массива =  " + min);

double dif = max - min;


System.Console.WriteLine("Разница между значениями максимального и минимального элементов массива =  " + Math.Round(dif, 2));
}
dif(array);