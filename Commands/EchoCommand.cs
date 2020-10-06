using AIOShell.Interfaces;
using System;
using System.IO;

namespace AIOShell.Commands
{
	public class EchoCommand : ICommand
	{
		public int Execute(string[] args)
		{
			string s = "";
			for (int i = 1; i < args.Length; i++)
			{
				s += args[i] + " ";
			}
			Output.Write($"{s}\n");
			return 0;
		}

		public string GetHelpID()
		{
			return "setvar";
		}
	}
}
