// Задаем массив. Пишем программу, которая определяет существует ли
// заданное число в массиве

int[] array = GetRandomArray(15, -10, 10); // задаем параметры массива
Console.WriteLine($"Массив случайных чисел: {string.Join(", " , array)}"); // метод объектов стринг представляет 
int number = ReadInt("number");
GetCheckinkFromNumber(array);
//Console.WriteLine($"Масс {string.Join(", " , arr)}");

int[] GetRandomArray(int length, int min, int max) // создаем фкнкцию массива с параметрами длинна, макс и мин
{
  int[] array = new int[length]; // создали массив определенной длинны заполненный нолями
  Random rnd = new Random();

  for (int i = 0; i < length; i++)
  {
    array[i] = rnd.Next(min, max + 1); // заполняем массив случайными числами
  }

  return array;
}

int ReadInt(string argument)        // создаем функцию (метод) которая
{                                    // будет принимать на вход и выдавать значения
  Console.Write($"Введите число для проверки {argument}: ");
  int number;

  while (!int.TryParse(Console.ReadLine(), out number)) // если это не число!...
  {
      Console.WriteLine("Error! Try again.");           // тогда: ошибка,попробуйте еще раз!
  }

  return number;                                        // выводим значение
}

void GetCheckinkFromNumber(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  { 
    if (array[i] == number)
    {
            Console.WriteLine($"Число {number} в массиве присутствует ни позиции {i}!");
      return; // завершает работу функции
    }
     
  }
   
  Console.WriteLine($"Числа {number} в массиве нет!");
}