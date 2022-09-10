// 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 → 1, 4, 9, 16, 25.
// 2 → 1,4

// МОЙ КОД 

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());

// int result = 1;
// for (int i = 1; i <= number; i++)
// {
//     result = i * i;
//     Console.Write(result);
//     if (i < number)
//     {
//         Console.Write(", ");
//     }
// }

// КОД ПРЕПОДАВАТЕЛЯ 

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int[] squares = new int[number];
for (int i = 1; i <= number; i++)
{
    squares[i - 1] = i * i;
}
for (int i = 0; i < number; i++)
{
    Console.Write(squares[i]);
    if (i < 4)
        Console.Write(", ");
}
