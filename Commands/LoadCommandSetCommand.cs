using AIOShell.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIOShell.Commands
{
	public class LoadCommandSetCommand : ICommand
	{
		public int Execute(string[] args)
		{
			if (args.Length != 2)
			{
				Output.WriteError("Invalid arguments!\n");
				return 1;
			}
			CommandManager.extraCommandSet = args[1];
			return 0;
		}

		public string GetHelpID()
		{
			return "lcs";
		}
	}
}
