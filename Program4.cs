// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Please enter number: ");
int Number=Convert.ToInt32(Console.ReadLine());
int i = 1;
if (Number == 1)
    {Console.WriteLine("Number is not correct for this task");}
else
    for (i = 1; i <= Number; i++)
     {
        if ((i % 2) == 0) 
  {Console.WriteLine("next integer from 1 to " +Number +" is " +i);}

    }
