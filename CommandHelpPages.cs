using System;
using System.Collections.Generic;
using System.Text;

namespace AIOShell
{
	public static class CommandHelpPages
	{
		public static Dictionary<string, string> syntaxList = new Dictionary<string, string>();
		public static Dictionary<string, string> functionList = new Dictionary<string, string>();
		public static Dictionary<string, string> aliasList = new Dictionary<string, string>();
		public static Dictionary<string, string> authorList = new Dictionary<string, string>();

		public static void SetupSyntax()
		{
			syntaxList.Add("help", "help");
			syntaxList.Add("cd", "cd <foldername>");
			syntaxList.Add("exit", "exit");
			syntaxList.Add("lad", "lad");
			syntaxList.Add("lev", "lev");
			syntaxList.Add("ls", "ls");
			syntaxList.Add("mkdir", "mkdir <name>");
			syntaxList.Add("rmdir", "rmdir <name>");
		}
		public static void SetupFunction()
		{
			functionList.Add("help", "Displays help for a command");
			functionList.Add("cd", "Changes the current directory");
			functionList.Add("exit", "Exits");
			functionList.Add("lad", "Displays all logical drives connected to the pc");
			functionList.Add("lev", "Displays all enviroment variables");
			functionList.Add("ls", "Shows the contents of the current directory");
			functionList.Add("mkdir", "Creates a directory");
			functionList.Add("rmdir", "Removes a direcotry");
		}
		public static void SetupAlias()
		{
			aliasList.Add("help", "No aliases");
			aliasList.Add("cd", "No aliases");
			aliasList.Add("exit", "No aliases");
			aliasList.Add("lad", "listalldrives");
			aliasList.Add("lev", "listenvvars, listenvs, levs");
			aliasList.Add("ls", "No aliases");
			aliasList.Add("mkdir", "No aliases");
			aliasList.Add("rmdir", "No aliases");
		}
		public static void SetupAuthor()
		{
			authorList.Add("help", "Gameefan");
			authorList.Add("cd", "Gameefan");
			authorList.Add("exit", "Gameefan");
			authorList.Add("lad", "Gameefan");
			authorList.Add("lev", "Gameefan");
			authorList.Add("ls", "Gameefan");
			authorList.Add("mkdir", "Gameefan");
			authorList.Add("rmdir", "Gameefan");
		}
	}
}
