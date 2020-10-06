using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AIOShell
{
	class Program
	{
		public static bool disableColors = false;
		public const string VERSION = "v0.1.0.alpha.5";

		public static Dictionary<string, int> localVariables = new Dictionary<string, int>();

		static void Main(string[] args)
		{
			try
			{
				List<string> argList = new List<string>();
				foreach (string str in args)
				{
					argList.Add(str);
				}
				foreach (string arg in argList)
				{
					switch (arg)
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
					if (CommandManager.extraCommandSet.Length == 0)
						Output.Write($"AIOSHELL{"{" + Environment.CurrentDirectory + "}"} $ ");
					else
					{
						Output.Write($"AIOSHELL{"{" + Environment.CurrentDirectory + "}"} ({CommandManager.extraCommandSet}) $ ");
					}
					string cmd = Console.ReadLine();
					switch (CommandManager.FetchCommand(cmd))
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
			catch (Exception e)
			{
				Console.WriteLine($"An unhandled error occured!\nMSG: {e.Message}\nST: {e.StackTrace}\nS: {e.Source}");
				return;
			}
		}
	}
}
