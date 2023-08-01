           void Task34()
            {
                /* Задача 34: Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
                [345, 897, 568, 234] -> 2 */
                int size = 6;
                int[] numbers = new int[size];

                MyLibClass.FillArray(numbers);
                MyLibClass.PrintArray(numbers);

                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0) count++;
                }
                Console.WriteLine("Количество чётных чисел равно " + count);
            }

            void Task36()
            {
                /* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
                [3, 7, 23, 12] -> 19
                [-4, -6, 89, 6] -> 0 */
                int size = 6;
                int[] numbers = new int[size];

                MyLibClass.FillArray(numbers, 0, 7);
                MyLibClass.PrintArray(numbers);

                int sum = 0;
                for (int i = 1; i < numbers.Length; i += 2)
                {
                    sum += numbers[i];
                }
                Console.WriteLine("Сумма равна " + sum);


            }

            void Task38()
            {
                /* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
                [3,21 7,04 22,93 -2,71 78,24] -> 80,95 */

                int size = 6;
                double[] numbers = new double[size];

                MyLibClass.FillArray(numbers, -100, 100);
                MyLibClass.PrintArray(numbers);

                
                double max = numbers[0];
                double min = numbers[0];

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max) max = numbers[i];
                    else if (numbers[i] < min) min = numbers[i];
                }
                Console.WriteLine(max);
                Console.WriteLine(min);
                Console.WriteLine("Разница значений равна: " +
                                    $"{max - min}");
            }

            Console.Clear();
            Task();