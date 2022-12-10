// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Degree (int numb, int deg)
// {
//     int summ = 1;
//     for (int i = 0; i < deg; i++)
//     {
//         summ *= numb;
//     }
//     return summ;
// }
// System.Console.WriteLine("Write number");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Write degree");
// int degree = Convert.ToInt32(Console.ReadLine());
// int result = Degree (numb: number, deg:degree);
// System.Console.WriteLine(result);

//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  (Массивы и строки использовать нельзя!!!)
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Question27 (int number)
// {
//     int summ = 0;
//     for (int i = 0; number > 0; i++)
//     {
//         summ += number %10;
//         number = number /10;
//     }
//     return summ;
// }
// System.Console.WriteLine("Write number");
// int numb = Convert.ToInt32(Console.ReadLine());
// int result = Question27(numb);
// System.Console.WriteLine(result);

// Напишите программу, которая задаёт массив из произвольного кол-ва 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] Array (int length1) 
// {
//     int[] arr = new int [length1]; 
// for (int i = 0; i < length1; i++) 
// {
//     System.Console.WriteLine("write number");
//     int numb = Convert.ToInt32(Console.ReadLine()); 
//     arr[i] = numb;
// }
// return arr; 
// }
// void ShowArray (int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }
// System.Console.WriteLine("Write Length massive");
// int length = Convert.ToInt32(Console.ReadLine()); 
// ShowArray(Array(length)); 


















