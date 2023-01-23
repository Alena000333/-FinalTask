    string[] array1 = {"Hello", "2", "world", ":-)"};
		string[] array2 = {"1234", "17", "-2", "comp"};
		string[] array3 = {"Russia", "Denm", "Kazan"};
		int MaxLength = 3;
		
		string[] GetShortArray(string[] array)
		{
			int length = array.Length;			
			string[] result = new string[length];
			int count = 0;
			
			for (int i = 0; i < length; i++)
			{
				if(array[i].Length <= MaxLength)
				{
					result[count] = array[i];
					count++;
				}
			}
			Array.Resize(ref result, count);
			
			return result;
		}
		
		void PrintArray(string[] array)
		{
			if(array.Length == 0)
			{
				Console.WriteLine("Массив пустой");
			}
			else
			{
				Array.ForEach(array, (str) => Console.Write($"{str} "));
				Console.WriteLine();
			}
		}
		
		void Output (string[] array)
		{
			Console.WriteLine("Исходный массив:");
			PrintArray(array);
			string[] shortArray = GetShortArray(array);
			Console.WriteLine($"Результирующий массив ");
			PrintArray(shortArray);
			Console.WriteLine();
		}
		
		Output(array1);
		Output(array2);
		Output(array3);
	