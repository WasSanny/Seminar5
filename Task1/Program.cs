// Программа задает масссив из 12 элементов заполенный случайными числами (от - 9 до 9).
// Найти сумму всех положительных и отрицательных элементов массива.

// 1. Создаем и заполняем массив
// 2. Используем цикл для рассчета сумм положительных и отрицацельных элементов

int[] array = GetRandomArray(12, -9, 9); // задаем параметры
int[] minEndMax = GetMinAndMaxFromArray(array);
Console.WriteLine($"Введен массив {string.Join("" , array)}"); // метод объектов стринг представляет 
Console.WriteLine($"Сумма положительных {minEndMax[0]}");
Console.WriteLine($"Сумма отрицательных {minEndMax[1]}");

int[] GetRandomArray(int length, int min, int max) // создаем массив с параметрами длинна, макс и мин
{
  int[] array = new int[length]; // создали массив определенной длинны заполненный нолями
  Random rnd = new Random();

  for (int i = 0; i < length; i++)
  {
    array[i] = rnd.Next(min, max + 1); // заполняем массив случайными числами
  }

  return array;
}

int[] GetMinAndMaxFromArray(int[] array)
{
  int[] minEndMax = new int [2];
  
   for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      minEndMax[0] = minEndMax[0] + array[i];
    }
    else
    {
      minEndMax[1] = minEndMax[1] + array[i];
    }
  }
  return minEndMax;
  }
