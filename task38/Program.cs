// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76


int Promt (string message)
{
  System.Console.WriteLine(message);
  string str = System.Console.ReadLine() ?? String.Empty;
  double numberDouble = (int) Convert.ToDouble(str);
  int result = (int) Math.Abs(Convert.ToInt32(numberDouble));
  if (result == 0)
  {
    System.Console.WriteLine("Указан недостаточный размер массива");
    return -1;
  }
  return result;
}

 

double [] PaddingWithRealNumbers (int sizeArray)
{
  double [] fillArray = new double [sizeArray];
  Random rnd = new Random();
  for (int i = 0; i < sizeArray; i++)
  {
    fillArray[i] = rnd.Next(-99,100) + Math.Round(rnd.NextDouble(), 2);
  }
  return fillArray;
}



double DifferenceMaxMinValue (double [] ArrayIn)
{
  double maxElement = ArrayIn[0];
  double minElement = ArrayIn[0];
  if (ArrayIn.Length == 1)
  {
    System.Console.WriteLine("Недастаточно эллементов массива");
    return -1;
  }

  for (int i = 0; i < ArrayIn.Length; i++)
  {
    if (maxElement<ArrayIn[i])
    {
      maxElement = ArrayIn[i];
    }
    if (minElement>ArrayIn[i])
    {
      minElement = ArrayIn[i];
    }
  }
  System.Console.WriteLine($"Максимальное значение: {maxElement}");
  System.Console.WriteLine($"Минимальное значение: {minElement}");
  return maxElement-minElement;
}


int sizeDoubleArray = Promt ("Ввдите размер массива");
double [] newArray = PaddingWithRealNumbers(sizeDoubleArray);
System.Console.WriteLine(string.Join("; ", newArray));
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {DifferenceMaxMinValue(newArray)}");
