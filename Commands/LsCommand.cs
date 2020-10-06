using AIOShell.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AIOShell.Commands
{
	public class LsCommand : ICommand
	{
		public int Execute(string[] args)
		{
			string[] files = Directory.GetFiles(Environment.CurrentDirectory);
			string[] directories= Directory.GetDirectories(Environment.CurrentDirectory);
			foreach (string dir in directories)
			{
				Output.Write($"   {dir.Substring(Environment.CurrentDirectory.Length + 1)}\\\n");
			}
			foreach (string file in files)
			{
				Output.Write($"   {file.Substring(Environment.CurrentDirectory.Length + 1)}\n");
			}
			return 0;
		}

		public string GetHelpID()
		{
			return "ls";
		}
	}
}
