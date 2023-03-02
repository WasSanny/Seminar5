// Программа, которая задает одномерный массив из 123 случайных чисел.
// Найти количество элементов массива, значения которых лежат в отрезке [10,99]


int[] array = GetRandomArray(123, -150, 155); // Вызываем функцию GetRandomArray и задаем параметры
int kol = GetCount(array);
Console.Write($"Количество элементов в диапозоне от 10 до 99 равно: {kol}");

int[] GetRandomArray(int length, int min, int max) // создаем фкнкцию массива с параметрами длинна, макс и мин
{
  int[] array = new int [length]; // создали массив определенной длинны заполненный нолями
  Random rnd = new Random();

  for (int i = 0; i < length; i++)
  {
    array[i] = rnd.Next(min, max + 1); // заполняем массив случайными числами
  }

  return array;
}

int GetCount(int[] array) // Создаем функцию, которая считает коичество
{
  int kol = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= 10 && array[i] <= 99)
    {
      kol++;
    }
  }

  return kol;
}