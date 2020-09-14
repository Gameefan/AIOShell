using System;
using System.Diagnostics;
using System.IO;

namespace AIOShell
{
	class Program
	{
		static void Main(string[] args)
		{
			CommandManager.SetupCommands();
			while (true)
			{
				bool shouldBreak = false;
				Output.Write($"AIOSHELL> ");
				string cmd = Console.ReadLine();
				switch(CommandManager.FetchCommand(cmd))
				{
					case 1001:
						shouldBreak = true;
						break;
					default:
						break;
				}
				if (shouldBreak)
					break;
			}
		}
	}
}
