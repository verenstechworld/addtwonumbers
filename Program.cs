// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int number1, number2, sum; // variable declaration

Console.Write("Please enter first number:");
number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter second number:");
number2 = Convert.ToInt32(Console.ReadLine());

sum = number1 + number2;
Console.WriteLine("the sum: {0}", sum);
Console.WriteLine("Please press any key to close");

Console.ReadKey();
