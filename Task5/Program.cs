// Программа, которая ище произведение пар чисел в одномерном массие.
// Парой считаем первый и последний элемент массива,
// Результат запишем в новом массиве!

int[] array = GetRandomArray(5, 0, 4); // Вызываем функцию GetRandomArray и задаем параметры
Console.WriteLine($"Рандомный массив {string.Join("," , array)}"); // Join - позволяет вывести массив с разделителем элементов массива
int[] arrayResult = GetProductOfPirse(array);
Console.WriteLine($"Результат произведения {string.Join("," , arrayResult)}");

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

int[] GetProductOfPirse(int[] array)
{
  int length = 0;

  if (array.Length % 2 == 0)
  {
    length = array.Length / 2;
  }
  else
  {
    length = array.Length / 2 + 1; // если остаток от деления не половина массива, тогда +1
  }

  int[] arrayNew = new int [length]; // создаем новый массив, в который помещать будем новые зеачения

  for (int i = 0; i < array.Length / 2; i++)
  {
    arrayNew[i] = array[i] * array[array.Length - 1 - i];
  }

  if (array.Length % 2 != 0)
  {
    arrayNew[length -1] = array[array.Length / 2];
  }
  return arrayNew;
}




  