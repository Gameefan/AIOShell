using AIOShell.Interfaces;
using System;
using System.IO;

namespace AIOShell.Commands
{
	public class MkDirCommand : ICommand
	{
		public int Execute(string[] args)
		{
			if (args.Length < 2)
			{
				Output.WriteError("Invalid arguments!\n");
				return 1;
			}
			string newFolder = "\\";
			for (int i = 1; i < args.Length; i++)
			{
				newFolder += args[i];
			}
			Output.WriteDebug(newFolder + "\n");
			if (Directory.Exists(Environment.CurrentDirectory+newFolder))
			{
				Output.WriteError("Folder already exists!\n");
				return 2;
			}
			try
			{
				DirectoryInfo di = Directory.CreateDirectory($@"{Environment.CurrentDirectory}{newFolder}");
				Output.Write("Directory created successfully!\n",displayPrefix:true);
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
			return "mkdir";
		}
	}
}
