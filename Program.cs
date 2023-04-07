// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// int[] FillArray(int[] array) {
//     for(int i = 0; i < array.Length; i++) {
//         Console.Write($"Введите элемент массива array[{i}]: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// int Extent(int[] array) {
//     int result = array[0];
//     if(array[1] == 0) {
//         return 1;
//     }
//         if(array[1] == 1) {
//         return result;
//     }
//     for(int i = 2; i <= array[1]; i++) {
//         result = result*array[0];
//     }
//     return result;
// }

// Console.Clear();
// int[] array = new int[2];
// FillArray(array);
// int newResult = Extent(array);
// Console.WriteLine($"Число {array[0]} в степени {array[1]} = {newResult}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();

// int SumOfNumbers(int number) {
//     int sum = 0;
//     int newNum = number;
//     if(number < 10) {
//         sum = sum + number;
//         return sum;
//     }
//     while(newNum >= 10) {
//         sum = sum + newNum%10;
//         newNum = newNum/10;
//     }
//     sum = sum + newNum;
//     return sum;
// }

// Console.Write("Введите положительное целое число большеe 0: ");
// int a = Convert.ToInt32(Console.ReadLine());
// while(true) {
//     if(a <= 0) {
//         Console.Write("Вы ввели неверное число. Попробуйте снова: ");
//         a = Convert.ToInt32(Console.ReadLine());
//     } else break;
// }
// Console.WriteLine($"Сумма цифр числа {a} = {SumOfNumbers(a)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateArray(int size, int minValue, int maxValue) {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++) {
//         int ielement = 0;
//         Console.Write($"Введите {i} элемент массива в диапозоне от {minValue} до {maxValue}: ");
//         ielement = Convert.ToInt32(Console.ReadLine());
//         while(true) {
//             if(ielement < minValue || ielement > maxValue) {
//                 Console.Write($"Вы ввели {i} элемент выходящий за пределы допустимого диапозона. Попробуйте снова: ");
//                 ielement = Convert.ToInt32(Console.ReadLine());
//             } else break;
//         }
//         array[i] = ielement;
//     }    
//     return array;
// }

// void ShowArray(int[] array) {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateArray(size, min, max);
// ShowArray(newArray);
//