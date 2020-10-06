using AIOShell.Interfaces;
using System;
using System.IO;

namespace AIOShell.Commands
{
	public class GScirptExecuteCommand : ICommand
	{
		public int Execute(string[] args)
		{
			string[] lines;
			if (args.Length != 2)
			{
				Output.WriteError("Invalid arguments!\n");
				return 1;
			}
			if (!File.Exists(args[1]))
			{
				if (!File.Exists(args[1] + ".gs"))
				{
					Output.WriteError("File doesn't exist!\n");
					return 2;
				}
				lines = File.ReadAllLines(Environment.CurrentDirectory + "\\" + args[1]+".gs");
			}else
				lines = File.ReadAllLines(Environment.CurrentDirectory + "\\" + args[1]);
			foreach (string line in lines)
			{
				Output.WriteDebug($"Executing command: {line}\n");
				string cmdToFetch = "";
				string[] partsOfCmd = line.Split(separator: ' ', options: StringSplitOptions.RemoveEmptyEntries);
				foreach (string s in partsOfCmd)
				{
					cmdToFetch += s;
					cmdToFetch += " ";
				}
				int exitCode = CommandManager.FetchCommand(cmdToFetch);
				if(exitCode==1001)
				{
					return 3;
				}
			}
			return 0;
		}

		public string GetHelpID()
		{
			return "gse";
		}
	}
}
