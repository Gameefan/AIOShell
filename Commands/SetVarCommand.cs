using AIOShell.Interfaces;
using System;
using System.IO;

namespace AIOShell.Commands
{
	public class SetVarCommand : ICommand
	{
		public int Execute(string[] args)
		{
			if(args.Length!=3)
			{
				Output.WriteError("Invalid arguments!\n");
				return 1;
			}
			int value = 0;
			try
			{
				value = int.Parse(args[2]);
			}
			catch (Exception)
			{
				Output.WriteError("Parse error occured!\n");
				return 2;
			}

			if(Program.localVariables.ContainsKey(args[1]))
			{
				Program.localVariables[args[1]] = value;
			}else
			{
				Program.localVariables.Add(args[1], value);
			}
			Output.Write($"%{args[1]} = {Program.localVariables[args[1]]}\n");
			return 0;
		}

		public string GetHelpID()
		{
			return "setvar";
		}
	}
}
