// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Please enter first number: ");
int FirstNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number: ");
int SecondNumber=Convert.ToInt32(Console.ReadLine());
if (FirstNumber == SecondNumber)
  {Console.WriteLine("The numbers are equal");}
else
    {
    if (FirstNumber > SecondNumber) {Console.WriteLine("The first number is greater and the second is less "+FirstNumber +" > "+SecondNumber);}
    else
      {Console.WriteLine("The second number is greater and the first is less "+FirstNumber +" < "+SecondNumber);}
    }