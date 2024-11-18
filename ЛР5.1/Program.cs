using System;

class Program
{
    static void Main()
    {   // Задаём длину массива
        Console.WriteLine("Введите длину массива:");
        int n = int.Parse(Console.ReadLine());

        // Создаём массив
        int[] array = new int[n];

        //Осуществляем ввод с клавиатуры
        Console.WriteLine("Введите элементы массива:");

        int maxElement = 0;
        int index = 0;

        //Находим среди введённых элементов максимальный элемент(и его индекс)
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            array[i] = num;

            if (num > maxElement)
            {
                maxElement = num;
                index = i;
            }
        }
        // Проверка на заполненность массива(для исключения результата при 0 длине)
        if (n > 0)
        {
            Console.WriteLine($"Наибольший элемент массива: {maxElement}");
            Console.WriteLine($"Порядковый номер элемента: {index}");
        }
        else
        {
            Console.WriteLine("Массив пустой");
        }
    }
}