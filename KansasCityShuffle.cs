using System;

namespace KansasCityShuffle
{
	internal class KansasCityShuffle
	{
		static void Main(string[] args)
		{
			int[] array = new int[5];
			FillArray(array);
			Console.WriteLine("Исходный массив: ");
			OutputArray(array);
			Shuffle(array);
			Console.WriteLine("\nПеремешанный массив: ");
			OutputArray(array);
			Console.WriteLine();
		}

		static void FillArray(int[] array)
		{
			Random random = new Random();
			int maxValue = 100;

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(maxValue + 1);
			}
		}

		static void OutputArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
				Console.Write($"{array[i]} ");
		}

		static void Shuffle(int[] array)
		{
			Random random = new Random();
			for (int i = array.Length - 1; i >= 0; i--)
			{
				int randomIndex = random.Next(i);
				int shuffeldNumber = array[randomIndex];
				array[randomIndex] = array[i];
				array[i] = shuffeldNumber;
			}
		}
	}
}
