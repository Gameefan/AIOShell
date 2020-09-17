using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AIOShell
{
	class Program
	{
		public static bool disableColors = false;
		public const string VERSION = "v0.1.alpha.1";
		static void Main(string[] args)
		{
			List<string> argList = new List<string>();
			foreach (string str in args)
			{
				argList.Add(str);
			}
			foreach (string arg in argList)
			{
				switch(arg)
				{
					case "debug":
					case "-debug":
					case "--debug":
						CommandManager.debugEnabled = true;
						break;
					case "nocolor":
					case "-nocolor":
					case "--nocolor":
						disableColors = true;
						break;
					default:
						break;
				}
			}
			CommandManager.SetupCommands();
			CommandHelpPages.SetupSyntax();
			CommandHelpPages.SetupFunction();
			CommandHelpPages.SetupAlias();
			CommandHelpPages.SetupAuthor();
			Output.Write($"AIOShell {VERSION} by Gameefan\n");
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
