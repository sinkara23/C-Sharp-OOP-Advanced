﻿using System;

namespace _09.CustomListIterator
{
	class Program
	{
		public static void Main(string[] args)
		{
			if (args == null)
			{
				throw new ArgumentNullException(nameof(args));
			}

			string[] command = Console.ReadLine().Split(" ");
			Box box = new Box();

			while (command[0] != "END")
			{
				switch (command[0])
				{
					case "Add":
						string word = command[1];
						box.Add(word);
						break;
					case "Remove":
						int indexToRemove = int.Parse(command[1]);
						box.Remove(indexToRemove);
						break;
					case "Contains":
						string wordIsContains = command[1];
						box.IsContains(wordIsContains);
						break;
					case "Swap":
						int indexOne = int.Parse(command[1]);
						int indexTwo = int.Parse(command[2]);
						box.SwapElements(indexOne, indexTwo);
						break;
					case "Greater":
						string greaterWord = command[1];
						box.Greater(greaterWord);
						break;
					case "Max":
						box.PrintMaxElement();
						break;
					case "Min":
						box.PrintMinElement();
						break;
					case "Print":
						box.PrintAllElements();
						break;
					case "Sort":
						box.SortElements();
						break;
				}

				command = Console.ReadLine().Split();
			}
		}
	}
}