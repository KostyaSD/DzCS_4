
internal class Program
{
    private static int num1;
    private static int num2;
    private static void Main(string[] args)
    {
        start();
    }
    
    private static void start()
    {
        Console.Write("Сделайте Ваш выбор:\n" +
            "1. Задача № 25\n" +
            "2. Задача № 27\n" +
            "3. Задача № 29\n" +
            "Ваш выбор: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        switch (num1)
        {
            case 1:
                task25();
                break;
            case 2:
                task27();
                break;
            case 3:
                task29();
                break;
            default:
                Console.Write("Что-то пошло не так! надо было выбрать от 1 до 3\n" +
                              "Миссия провалена!");
                break;
        }
    }
    /* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
              и возводит число A в натуральную степень B.

              3, 5 -> 243 (3⁵)
              2, 4 -> 16*/
    private static void task25()
    {
        Console.WriteLine("Вы выбрали Задачу № 25\n\n" +
                                  "Условие: Напишите цикл, который принимает на вход два числа (A и B)\n" +
                                  "и возводит число A в натуральную степень B.\n");
        Console.Write("Введите число А: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число В: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        //1 вариант решения:
        Console.WriteLine($"Ответ: {Math.Pow(num1, num2)}");
        //2 вариант решения:
        /*int count = num1; 
        for(int i = 1; i < num2; i++)
        {
            count *= num1;
        }
        Console.WriteLine($"Ответ: {count}");*/
    }

    /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

                 452 -> 11
                 82 -> 10
                 9012 -> 12*/

    private static void task27()
    {
        Console.WriteLine("Вы выбрали Задачу № 27\n\n" +
                                          "Условие: Напишите программу, которая принимает на вход число " +
                                          "и выдаёт сумму цифр в числе.\n");
        Console.Write("Введите число: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        // 1 вариант решения: 
        while (num1 != 0)
        {
            count += num1 % 10;
            num1 /= 10;
        }
        Console.WriteLine($"Ответ: {count}");
        // 2 вариант решения:
        /*        int lenght = num1.ToString().Length;
                char[] text = num1.ToString().ToCharArray();
                for (int i = 0; i < lenght; i++)
                {
                    count += Convert.ToInt32(text[i].ToString());
                }
                Console.Write($"Ответ: {count}");*/
    }
    /*Задача 29: Напишите программу, которая задаёт массив произвольной длины, заполняет
               произвольными элементами и выводит их на экран. Длину массива и элементы
               массива можно задать рандомно или попросить пользователя ввести в консоли.

               1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
               6, 1, 33 -> [6, 1, 33]*/

    private static void task29()
    {
        Console.WriteLine("Вы выбрали Задачу № 29\n\n" +
                          "Условие: Напишите программу, которая задаёт массив произвольной длины, заполняет\n" +
                          "произвольными элементами и выводит их на экран. Длину массива и элементы\n" +
                          "массива можно задать рандомно или попросить пользователя ввести в консоли.\n");
        Console.Write("Выберите действие:\n" +
                      "1. Задать длину массива вручную\n" +
                      "2. Задать длину массива автоматически\n" +
                      "Ваш выбор: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[0];
        switch (num1)
        {
            case 1:
                Console.Write("Введите длину массива: ");
                num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Array.Resize(ref arr, num1);
                Console.WriteLine($"Длина массива: {arr.Length}");
                break;
            case 2:
                Array.Resize(ref arr, new Random().Next(4, 21));
                Console.WriteLine($"Длина массива: {arr.Length}");
                break;
            default:
                Console.Write("Что-то пошло не так! надо было выбрать 1 либо 2\n" +
                              "Миссия провалена!");
                break;
        }
        Console.Write("Выберите действие:\n" +
                      "1. Заполнить массив вручную\n" +
                      "2. Заполнить массив автоматически\n" +
                      "Ваш выбор: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        switch (num1)
        {
            case 1:
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"Введите эллемент {i}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Ответ: Массив {");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1) Console.Write(arr[i] + "}");
                    else Console.Write($"{arr[i]}, ");
                }
                break;
            case 2:
                Console.Write("Ответ: Массив {");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 200);
                    if (i == arr.Length - 1) Console.Write(arr[i] + "}");
                    else Console.Write($"{arr[i]}, ");
                }
                break;
            default:
                Console.Write("Что-то пошло не так! надо было выбрать 1 либо 2\n" +
                              "Миссия провалена!");
                break;
        }
    }
}