// Напишите программу, которая
// 1. на вход принимает число
//  2. и выдает его квадрат (число умноженное на само себя).

// Например,
// 4 -> 16
// -3 -> 9
// -7 -> 49

string str = Console.ReadLine(); /// все воспринимается как текст

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число:");

int square = number*number;

Console.WriteLine($"Квадрат числа {number} = {square}");
