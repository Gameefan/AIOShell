using AIOShell.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIOShell.Commands
{
	public class ListAllDrivesCommand : ICommand
	{
		public int Execute(string[] args)
		{
			foreach(string s in Environment.GetLogicalDrives())
			{
				Output.Write($"{s}\n");
			}
			return 0;
		}
	}
}
