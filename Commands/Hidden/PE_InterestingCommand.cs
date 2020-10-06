using AIOShell.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIOShell.Commands.Hidden
{
	public class PE_InterestingCommand : ICommand
	{
		public int Execute(string[] args)
		{
			if(CommandManager.extraCommandSet!="pe_pe")
			{
				Output.WriteError($"Couldn't find command: {args[0]}\n", displayPrefix:false);
				return 0;
			}
			Output.Write($"CurrentDirectory: {Environment.CurrentDirectory}\n");
			Output.Write($"CommandLine: {Environment.CommandLine}\n");
			Output.Write($"MachineName: {Environment.MachineName}\n");
			Output.Write($"UserName: {Environment.UserName}\n");
			Output.Write($"UserDomainName: {Environment.UserDomainName}\n");
			Output.Write($"UserInteractive: {Environment.UserInteractive}\n");
			Output.Write($"OSVersion: {Environment.OSVersion}\n");
			Output.Write($"Is64BitOperatingSystem: {Environment.Is64BitOperatingSystem}\n");
			Output.Write($"ProcessorCount: {Environment.ProcessorCount}\n");
			Output.Write($"SystemDirectory: {Environment.SystemDirectory}\n");
			Output.Write($"StackTrace: {Environment.StackTrace}\n");
			return 0;
		}

		public string GetHelpID()
		{
			return "help";
		}
	}
}
