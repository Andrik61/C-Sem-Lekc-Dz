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

/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> макс = -3
*/
/*

Консоль.Write("Ввести первое число: ");
int number1 = Преобразовать.ToInt32(консоль.Прочитай строку());
Консоль.Write("Ввести второе число: ");
int number2 = Преобразовать.ToInt32(консоль.Прочитай строку());
если (число1 < число2)
{
 Консоль.Write("Наибольшее число: "+number2);
}
*/

/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

// Консоль.Write("Ввести первое число: ");
// Преобразовать = число1  в целое число.ToInt32(консоль.Строка чтения());

// Консоль.Write("Ввести второе число: ");
// Преобразовать = число2  в целое число.ToInt32(консоль.Прочитай строку());

// Консоль.Write("Ввести третье число: ");
// Преобразовать = число3  int.ToInt32(консоль.Прочитай строку());

// максимальное  количество;

// если (число1 > число2)
// {
//     если (число1 > число3)
//     {
//         число  1= максимальное;
//     }
//     ещё 
//     {
//         число  3= максимальное;
//     }
// }
// ещё
// {
//     если (число2 > число3)
//     {
//         число 2=максимальное  ;
//     }
//     ещё 
//     {
//         число  3= максимальное;
//     }
// }
// Консоль.Write("Максимальное число: " + max);

/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

// Консоль.WriteLine("Введите число N: ");
// число чисел = Преобразовать.ToInt32(консоль.Прочитай строку());
// если (число % 2==0)
// {
// Консоль.WriteLine(number + "чётное" );
// }
// иначе, если (число % 2==1)
// {
// Консоль.WriteLine(number + "нечётное" );
// } 

// Seminar 2 :

// Решение Dz :
// int N = 5;
// int start = -4; // первое четное число - 2
// while (start <= N)
// {
//    Console.WriteLine(start);
//    start += 2;  // start = start + 2
// }

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10,100);
// // [10;100)
// // Console.WriteLine($"Рандомное число: {number}"); // - Интерполяция
// // Console.WriteLine($"Текст: {В фигурных скобках - переменная}") - Интерполяция
// // Console.WriteLine("Рандомное число: " + number); // Конкатенация - сложение строк
// // camelCase
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// int maximum = firstDigit; // Пусть максимум - это 1 число (количество десятков)
// if (maximum < secondDigit) maximum = secondDigit;
// Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}");

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46   // 456 -> 4    //456->6     // 4,6->46
// 782 -> 72   // 456/100=4   //456%10=6   // 4 десятка (4*10=40)
// 918 -> 98
                               // 6 единиц (6*1=6)
//11.1
                                       // 4*10+6=46
// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int first1 = number / 100;
// int second2 = number % 10;
// int result = first1 * 10 + second2;
// Console.WriteLine(result);

 // Или : 11.2

// int number = Convert.ToInt32(Console.ReadLine());
// int result = (number/100) * 10 + number % 10 ;
// Console.WriteLine($"Первая и третья цифра числа: {result}");

//11.3
                                                        
// string number = Console.ReadLine();                  // 012 - []
// Console.WriteLine(number[0] + "" + number[2]);       // 456

// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли
// второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток 
// от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 

 // 12.1

// Console.WriteLine("Введите число 1: ");
// int number1 =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int number2 =Convert.ToInt32(Console.ReadLine());
// if (number1 % number2 == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно, остаток" + number1 % number2);
// }

// 12.2

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber % secondNumber == 0) Console.WriteLine("Кратное");
// else Console.WriteLine($"Остаток от деления: {firstNumber % secondNumber}");

// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // &&
// // апельсины и яблоки - и то, и то (1 и 1 - True(1) или 0 и 0 False(0))
// if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("да");
// else Console.WriteLine("нет");

// DZ :

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = Convert.ToInt32(Console.ReadLine());
// int secondnumber = number / 10;
// int result = secondnumber % 10;
// Console.WriteLine(result);


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -6

// string number = Console.ReadLine();
// int size = number.Length;
// Console.WriteLine(size);
// if (number.Length < 3)
// {
//     Console.WriteLine("Строка не имеет 3 символа");
// }
// else 
//  {
//      Console.WriteLine(size);
//  }

// int number = Convert.ToInt32(Console.ReadLine());
// int number3 = number % 10;
// Console.WriteLine(number3);
// if (number < 2)
// {
//     Console.WriteLine( number3 + "третьей цифры  нет");
// }


//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int number = new Random().Next(1,7);
// if (number <=5)
// {
//     Console.WriteLine(number + "нет");
// }
// else 
//  {
//     Console.WriteLine(number + "да");
//  }
