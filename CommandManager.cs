using AIOShell.Commands;
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

		public static int FetchCommand(string cmd)
		{
			string[] args = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			if (args.Length <= 0)
				return 1;
			if (commands.ContainsKey(args[0].ToLower()))
			{
				currentCommand = args[0].ToLower();
				int returnCode = commands[args[0].ToLower()].Execute(args);
				currentCommand = "";
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

			commands.Add("mkdir", new MkDirCommand());

			commands.Add("rmdir", new RmDirCommand());

			commands.Add("ls", new LsCommand());

			commands.Add("help", new HelpCommand());

			//commands.Add("changedisk", new ChangeDiskCommand());
		}
	}
}
