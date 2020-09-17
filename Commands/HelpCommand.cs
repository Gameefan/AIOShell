using AIOShell.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIOShell.Commands
{
	public class HelpCommand : ICommand
	{
		public int Execute(string[] args)
		{
			if(args.Length != 2 &&  args.Length != 1)
			{
				Output.WriteError("Invalid arguments!\n");
				return 1;
			}
			if(args.Length==1)
			{
				foreach (string str in CommandHelpPages.syntaxList.Keys)
				{
					Output.Write($"	{CommandHelpPages.syntaxList[str]}\n");
				}
				return 0;
			}
			if(!CommandManager.commands.ContainsKey(args[1].ToLower()))
			{
				Output.WriteError($"Command '{args[1].ToLower()}' not found!\n");
				return 3;
			}
			if(CommandHelpPages.syntaxList.ContainsKey(CommandManager.commands[args[1].ToLower()].GetHelpID()))
			{
				try
				{
					Output.Write("	SYNTAX:\n", color: ConsoleColor.White);
					Output.Write($"		{CommandHelpPages.syntaxList[CommandManager.commands[args[1].ToLower()].GetHelpID()]}\n");
					Output.Write("	FUNCTION:\n", color: ConsoleColor.White);
					Output.Write($"		{CommandHelpPages.functionList[CommandManager.commands[args[1].ToLower()].GetHelpID()]}\n");
					Output.Write("	ALIASES:\n", color: ConsoleColor.White);
					Output.Write($"		{CommandHelpPages.aliasList[CommandManager.commands[args[1].ToLower()].GetHelpID()]}\n");
					Output.Write("	AUTHOR:\n", color: ConsoleColor.White);
					Output.Write($"		{CommandHelpPages.authorList[CommandManager.commands[args[1].ToLower()].GetHelpID()]}\n");
				}catch
				{
					Output.WriteError("An error occured!\n");
				}
			}
			else
			{
				Output.WriteError("Help page not found!\n");
				return 2;
			}
			return 0;
		}

		public string GetHelpID()
		{
			return "help";
		}
	}
}
