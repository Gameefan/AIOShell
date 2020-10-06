using AIOShell.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIOShell.Commands
{
	public class ExitCommand : ICommand
	{
		public int Execute(string[] args)
		{
			Output.Write("Quitting\n");
			return 1001;
		}

		public string GetHelpID()
		{
			return "exit";
		}
	}
}
