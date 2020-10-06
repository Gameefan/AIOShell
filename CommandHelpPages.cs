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
			syntaxList.Add("lcs", "lcs <name>");
			syntaxList.Add("gse", "gse <filename>");
			syntaxList.Add("setvar", "setvar <name> <value>");
			syntaxList.Add("addvar", "addvar <name> <value>");
			syntaxList.Add("compare", "compare <value1> <value2> <cmp-mode> <value>");
			syntaxList.Add("echo", "echo <text>");
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
			functionList.Add("lcs", "Loads an extra command set");
			functionList.Add("gse", "Loads and executes G-Script file");
			functionList.Add("setvar", "Sets a local variable");
			functionList.Add("addvar", "Increments the provided variable by the provided value");
			functionList.Add("compare", "Compares two values and exectes the command if they are equal; cmp-mode { 0=eq 1=lt 2=gt 3=neq 4=nlt 5=ngt }");
			functionList.Add("echo", "Displays text");
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
			aliasList.Add("lcs", "loadcommandset, loadextracommandset, lecs");
			aliasList.Add("gse", "gscirptexecute");
			aliasList.Add("setvar", "No aliases");
			aliasList.Add("addvar", "No aliases");
			aliasList.Add("compare", "cmp");
			aliasList.Add("echo", "No aliases");
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
			authorList.Add("lcs", "Gameefan");
			authorList.Add("gse", "Gameefan");
			authorList.Add("setvar", "Gameefan");
			authorList.Add("addvar", "Gameefan");
			authorList.Add("compare", "Gameefan");
			authorList.Add("echo", "Gameefan");
		}
	}
}
