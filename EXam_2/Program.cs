﻿//  Задайте значения M и N. Напишите программу, которая найдёт
//   сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int CalculateSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
		}
		Console.Write("Enter your m number: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your n number: ");
        int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(CalculateSumm(m,n));
	
