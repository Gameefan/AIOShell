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
			Output.Write("Quitting");
			return 1001;
		}
	}
}
