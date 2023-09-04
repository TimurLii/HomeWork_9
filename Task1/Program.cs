// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine()!);


Console.WriteLine(Numbers(num,1));

string  Numbers(int count, int nul)
{
    if( count == nul) return nul.ToString();
    return ( count + "," + Numbers(count - 1,nul));
}