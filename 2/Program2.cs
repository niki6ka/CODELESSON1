// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Please enter first number: ");
int FirstNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number: ");
int SecondNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter third number: ");
int ThirdNumber=Convert.ToInt32(Console.ReadLine());

if (FirstNumber == SecondNumber && SecondNumber == ThirdNumber)
  {Console.WriteLine("The numbers are equal");}
else
    {
    if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber) {Console.WriteLine("The first number is greater "+FirstNumber);}
    else
        {
            if (SecondNumber > FirstNumber && SecondNumber > ThirdNumber) {Console.WriteLine("The second number is greater "+SecondNumber);}
            else
            {Console.WriteLine("The third number is greater "+ThirdNumber);}
        }
          
    }
