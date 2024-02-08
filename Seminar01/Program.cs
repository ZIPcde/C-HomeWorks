// //Console.Readline

// //int double char string bool
// Console.WriteLine("Type first number!");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Type second number!");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if ((number2 * number2) == number1)
// {
//     System.Console.WriteLine("Yes!!!");
// }
// else
// {
//     System.Console.WriteLine("No!!!");
// };
// // Console.WriteLine(number);
// // Console.WriteLine(number2);

// //  System.Console.WriteLine(); быстрая клавиша - "cw" + Tab
Console.WriteLine("Type your number!");
int N = Convert.ToInt32(Console.ReadLine());
// int start = N;
// N = -N;
// while (N != start)
// {
//     Console.Write(N + " ");
//     N = ++N;
// }
// Console.WriteLine(N);
for (int i = -N; i <= N; i++)
{
    System.Console.Write(i + " ");
};