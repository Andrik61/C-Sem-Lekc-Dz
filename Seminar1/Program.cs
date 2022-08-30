// Lekcia
// int numberA = 3;
// int numberB = 5;
// int result = numberA + numberB;
// Console.WriteLine(result);

// double numberA = 12;
// double numberB = 5;
// System.Console.WriteLine(numberA / numberB);

// int numberA = new Random().Next(1, 10);
// System.Console.WriteLine(numberA);
// int numberB = new Random().Next(1, 10);
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine(result);

// Console.WriteLine("Введите имя пользователя: ");
// string username = Console.ReadLine();
// if (username.ToLower() == "маша")
// {
//     Console.WriteLine("Ура, это же Маша!");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.Write(username);
// }

// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;
// int max = a;
// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;
// if (d > max ) max = d;
// if (e > max ) max = e;
// Console.Write("max = ");
// Console.WriteLine(max);

// Console.SetCursorPosition(8, 4);
// Console.WriteLine("+");
// int xa = 1, ya = 1,
//     xb = 1, yb = 10,
//     xc = 10, yc = 10;
//  Console.SetCursorPosition(xa, ya);
//  Console.WriteLine("+");
//   Console.SetCursorPosition(xb, yb);
//  Console.WriteLine("+");
//   Console.SetCursorPosition(xc, yc);
//  Console.WriteLine("+");
// int x = xa, y = xb;
// int count = 0;
// while (count < 10)
// {
//     int what = new Random().Next(0, 3);
//     if(what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }
//     if(what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }
//     if(what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count++;
// }

// Seminar:

//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на 
// самого себя).
// Например : 4 -> 16
            //   -3 -> 9
            //   -7 -> 49

// Console.WriteLine("Введите число: ");
// string firstNumber = Console.ReadLine(); // "2" + "2" = "22" - Конкатенация; 2+2=4
// string secondNumber = Console.ReadLine();
// Console.WriteLine(firstNumber + secondNumber);

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); // "2" + "2" = "22" - Конкатенация; 2+2=4
// int square = number * number;
// Console.WriteLine(square);

// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Введите число №1: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число №2: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());
// if (firstnumber == secondnumber * secondnumber) // f = 25; s =5
// {
//     Console.WriteLine(firstnumber + "является квадратом от " + secondnumber);
// }
// // "!=" - проверка на неравенство - 5 != 5 - False;
// // "==" - проверка на равенство - 5 == 5 - True;
// else // if (firstnumber != secondnumber * secondnumber); 
// {
//     Console.WriteLine(firstnumber + " Не является квадратом от " + secondnumber);
// }
// camelCase
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Средаж;  5 -> Пятница;

// int daynumber = Convert.ToInt32(Console.ReadLine());
// if (daynumber == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if (daynumber == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if (daynumber == 3)
// {
//     Console.WriteLine("Среда");
// }
// if (daynumber == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if (daynumber == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if (daynumber == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if (daynumber == 7)
// {
//     Console.WriteLine("Воскресенье");
// }

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все
// целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.Write("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0)
// {
//      number *= (-1); // -5 * (-1) = 5 - N
// }
// // -N = N * (-1)
// // [-N ; N] -> [negativNumber; number]
// int negativNumber = number * (-1);
// while (negativNumber <= number) // пока справедливо условие - negativNumber = negativNumber +1
// {                                      //                     negativNumber <= number      
//     Console.WriteLine(negativNumber);  //                     number = 4
//     negativNumber++;                   //                     negativNumber =- 4       
// }     // negativNumber = negativNumber + 1 - Инкремент  //    -4,-3,-2,-1,0,1,2,3,4
//       // negativNumber --   - Декремент     

// DZ :