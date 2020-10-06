using AIOShell.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIOShell.Commands
{
	public class AddVarCommand : ICommand
	{
		public int Execute(string[] args)
		{
			if (args.Length != 3)
			{
				Output.WriteError("Invalid arguments!\n");
				return 1;
			}
			if (!Program.localVariables.ContainsKey(args[1]))
			{
				Output.WriteError("Variable doesn't exist\n");
				return 2;
			}
			try
			{
				int add = int.Parse(args[2]);
				Program.localVariables[args[1]] += add;
				Output.Write($"%{args[1]} + {args[2]} = {Program.localVariables[args[1]]}\n");
			}
			catch (Exception)
			{
				Output.WriteError("Parse error occured!\n");
				return 3;
			}
			return 0;
		}

		public string GetHelpID()
		{
			return "addvar";
		}
	}
}
