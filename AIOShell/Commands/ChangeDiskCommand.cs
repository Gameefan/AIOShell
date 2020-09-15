using AIOShell.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AIOShell.Commands
{
	public class ChangeDiskCommand : ICommand
	{
		public int Execute(string[] args)
		{
			if(args.Length!=2)
			{
				Output.WriteError("Invalid arguments!\n");
				return 1;
			}
			try
			{
				Output.WriteDebug(Environment.CurrentDirectory);
				Environment.CurrentDirectory = $"{args[1].ToUpper()}:\\";
			}
			catch (DirectoryNotFoundException)
			{
				Output.WriteError("An directory not found!\n");
				return 2;
			}
			catch (Exception)
			{
				Output.WriteError("An error occured!\n");
				return 3;
			}
			return 0;
		}
	}
}
