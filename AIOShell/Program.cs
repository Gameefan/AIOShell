using System;
using System.Diagnostics;
using System.IO;

namespace AIOShell
{
	class Program
	{
		static void Main(string[] args)
		{
			if(args.Length==1&&args[0]=="debug")
			{
				CommandManager.debugEnabled = true;
			}
			CommandManager.SetupCommands();
			while (true)
			{
				bool shouldBreak = false;
				Output.Write($"AIOSHELL{"{"+ Environment.CurrentDirectory + "}"} $ ");
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
			Console.ForegroundColor = Output.defaultColor;
		}
	}
}
