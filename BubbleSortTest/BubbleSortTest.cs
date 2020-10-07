using System;

namespace BubbleSortTest
{
	class BubbleSortTest
	{
		static void Main(string[] args)
		{
			int[] array = { 50, 45, 40, 35, 30, 25, 20, 15, 10, 5, 1 };
			bool sorted = false;
			int temp = 0;
			int pass = 1;

			PrintArray(array, 0);

			for (int i = 0; i < array.Length; i++)
			{
				BubbleSort(array, pass);
				pass++;
			}
			
		}

		public static void BubbleSort(int[] ary, int passNum)
		{
			for (var i = 0; i < ary.Length -1; i++)
			{
				var smallest = i;

				for (var index = i + 1; index < ary.Length; index++)
				{
					if (ary[index] < ary[smallest])
					{
						smallest = index;
					}
					else
					{
						break;
					}
					Swap(ref ary[smallest], ref ary[i]);
					i++;
					PrintArray(ary, passNum);
				}
			}
		}

		public static void Swap(ref int first, ref int second)
		{
			var temp = first;
			first = second;
			second = temp;
		}

		static void PrintArray(int[]ary, int passNum)
		{
			string promptMessage;

			Console.Clear();

			if (passNum == 0)
			{
				Console.Write("Initial:  ");
				promptMessage = "\nPress any key to view results of first compare...";
			}
			else if (passNum == 10)
			{
				Console.WriteLine("Final:  ");
				promptMessage = "\nPress any key to exit...                 ";
			}
			else
			{
				Console.Write("Pass {0}: ", passNum);
				promptMessage = "\nPress any key to view results of next compare...";
			}
			foreach (int num in ary)
			{
				Console.Write("{0} ", num);
			}
			Console.Write(promptMessage);
			Console.ReadKey();
			passNum++;
			
		}
	}
}
