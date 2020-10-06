using AIOShell.Interfaces;
using System;
using System.IO;

namespace AIOShell.Commands
{
	public class CdCommand : ICommand
	{
		public int Execute(string[] args)
		{
			if (args.Length < 2)
			{
				Output.WriteError("Invalid arguments!\n");
				return 1;
			}
			string folderToEnter = $"\\";
			/*
			foreach (string arg in args)
			{
				folderToEnter += arg;
			}*/

			for (int i = 1; i < args.Length; i++)
			{
				folderToEnter += args[i];
			}
			try
			{
				Output.WriteDebug($"{Environment.CurrentDirectory} + {folderToEnter}\n");
				Environment.CurrentDirectory += folderToEnter;
			}
			catch (DirectoryNotFoundException)
			{
				//Output.WriteError("The directory not found!\n");
				Output.WriteDebug($"{args.Length}\n");
				Output.WriteDebug($"{args[1].Length}\n");
				if (args.Length == 2 && args[1].Length == 1)
				{
					try
					{
						Output.WriteDebug(Environment.CurrentDirectory);
						Environment.CurrentDirectory = $"{args[1].ToUpper()}:\\";
					}
					catch (DirectoryNotFoundException)
					{
						Output.WriteError("Directory not found!\n");
						return 2;
					}
					catch (Exception)
					{
						Output.WriteError("An error occured!\n");
						return 3;
					}
					return 0;
				}
				return 2;
			}
			catch (Exception)
			{
				Output.WriteError("An error occured!\n");
				return 3;
			}
			return 0;
		}

		public string GetHelpID()
		{
			return "cd";
		}
	}
}
