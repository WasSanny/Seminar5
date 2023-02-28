// Программа, которая заменяет отрицательные элементы массива, на положительные и наоборот!

// 1. Создаем и заполняем массив
// 2. Используем цикл для замены  положительных на отрицацельные элементы и наоборот

int[] array = GetRandomArray(12, -9, 9); // задаем параметры
int[] nov = GetMinAndMaxFromArray(array);
Console.WriteLine($"Введен массив {string.Join("," , array)}"); // метод объектов стринг представляет 
Console.WriteLine($"Замена {string.Join("," , nov)}");
//Console.WriteLine($"Сумма отрицательных {minEndMax[1]}");

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
  int[] arr = new int [12];
  
   for (int i = 0; i < arr.Length; i++)
  {
    
      arr[i] = array[i] * -1;
    
  }
  return arr;
  }
