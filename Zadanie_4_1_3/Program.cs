using System;
/*Дана двумерная матрица, все элементы которой различны. В каждой
строке выбирается элемент с наименьшим значением, затем среди
этих чисел выбирается наибольшее. Указать индексы элемента с
найденным значением.*/



namespace Zadanie_4_1_3
{
    class Program
    {

        static void Main(string [] args)
        {
            const int n = 4;
            int[,] test_mas = new int[n, n] {{-10,2,4,5}, {-13,-9,6,8}, {-10, -18, -30,1}, { 100, 100, 30, 1}};
            int[] rezult = new int[n];
            int left_index = 0;
            int right_index = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < 1; j++)
                {
                    rezult[i] = test_mas[i, j];
                }

            for (int i = 0; i < n; i++)
                for (int j = 1; j < n; j++)
                {
                    if (rezult[i] > test_mas[i, j])
                        rezult[i] = test_mas[i, j];
                }
          
         int max = rezult[0];

         for (int i=1; i<n; i++)
         {
         if (max< rezult[i])
         max= rezult[i];
         }
        
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)

                    if (max == test_mas[i, j])
                    {
                        left_index = i;
                        right_index = j;
                    }
            Console.WriteLine("Индексы максимального числа среди выборки минимальнных значений исходного массиве следующие. Левый - {0}, Правый - {1}.", left_index, right_index);
        }
    }
}
