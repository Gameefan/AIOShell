using AIOShell.Commands;
using AIOShell.Commands.Hidden;
using AIOShell.Interfaces;
using System;
using System.Collections.Generic;

namespace AIOShell
{
	public static class CommandManager
	{
		public static Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

		public static bool debugEnabled = false;

		public static string currentCommand = "";
		public static string extraCommandSet = "";

		public static bool allowChangeOfCurrentCommand = true;

		public static int FetchCommand(string cmd)
		{
			string[] args = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			//int i = 0;
			for (int i = 0; i < args.Length; i++)
			{
				int count = 0;
				foreach (char c in args[i].ToCharArray())
				{
					if (c.Equals('%'))
						count++;
				}
				for (int x = 0; x < count; x++)
				//if(args[i].Contains("%"))
				{
					int index = args[i].IndexOf("%");
					int whiteSpace = args[i].IndexOf(" ", index);
					if (whiteSpace == -1)
					{
						whiteSpace = args[i].Length - 1;
					}
					int lenght = whiteSpace - index;
					if (Program.localVariables.ContainsKey(args[i].Substring(index + 1, lenght)))
					{
						args[i] = args[i].Replace(args[i].Substring(index, lenght + 1), Program.localVariables[args[i].Substring(index + 1, lenght)].ToString());
					}
					else
					{
						args[i] = args[i].Replace(args[i].Substring(index, lenght + 1), "0");
					}
				}
				//i++;
			}
			if (args.Length <= 0)
				return 1;
			if (commands.ContainsKey(args[0].ToLower()))
			{
				currentCommand = args[0].ToLower();
				int returnCode = commands[args[0].ToLower()].Execute(args);
				currentCommand = "";
				if (returnCode != 0)
				{
					Output.WriteDebug($"\nGot a non-zero return code from command: \"{args[0]}\"! Is it normal or is investigation required?\nStack:\n{Environment.StackTrace}\nExit code: {returnCode}");
				}
				return returnCode;
			}
			else
			{
				Output.WriteError($"Couldn't find command: {args[0]}\n");
				return 1;
			}
		}

		public static void SetupCommands()
		{
			commands.Add("exit", new ExitCommand());

			commands.Add("listalldrives", new ListAllDrivesCommand());
			commands.Add("lad", new ListAllDrivesCommand());

			commands.Add("listenvvars", new ListEnvVarsCommand());
			commands.Add("listenvs", new ListEnvVarsCommand());
			commands.Add("lev", new ListEnvVarsCommand());
			commands.Add("levs", new ListEnvVarsCommand());

			commands.Add("cd", new CdCommand());
			//commands.Add("123", new CdCommand());

			commands.Add("mkdir", new MkDirCommand());

			commands.Add("rmdir", new RmDirCommand());

			commands.Add("ls", new LsCommand());

			commands.Add("help", new HelpCommand());

			commands.Add("loadcommandset", new LoadCommandSetCommand());
			commands.Add("lcs", new LoadCommandSetCommand());
			commands.Add("loadextracommandset", new LoadCommandSetCommand());
			commands.Add("lecs", new LoadCommandSetCommand());

			commands.Add("pe_i", new PE_InterestingCommand());
			commands.Add("pe_enum", new PE_InterestingCommand());

			commands.Add("gse", new GScirptExecuteCommand());
			commands.Add("gscriptexecute", new GScirptExecuteCommand());

			commands.Add("setvar", new SetVarCommand());

			commands.Add("addvar", new AddVarCommand());

			commands.Add("cmp", new CompareCommand());
			commands.Add("compare", new CompareCommand());

			commands.Add("echo", new EchoCommand());
			//commands.Add("changedisk", new ChangeDiskCommand());
		}
	}
}
