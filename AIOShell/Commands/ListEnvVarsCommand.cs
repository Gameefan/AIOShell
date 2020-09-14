using AIOShell.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIOShell.Commands
{
	public class ListEnvVarsCommand : ICommand
	{
		public int Execute(string[] args)
		{
			/*
			foreach (string s in Environment.GetEnvironmentVariables().Keys)
			{
				Output.Write($"{s}: {Environment.GetEnvironmentVariables()[s]}\n");
			}*/


			foreach (string s in Environment.GetEnvironmentVariables().Keys)
			{
				/*
				foreach (string item in Environment.GetEnvironmentVariables()[s].ToString().Split(';'))
				{
					Output.Write($"{s}: {item}\n");
				}*/
				for (int i = 0; i < Environment.GetEnvironmentVariables()[s].ToString().Split(';').Length; i++)
				{
					Output.Write($"{s}[{i.ToString()}]: {Environment.GetEnvironmentVariables()[s].ToString().Split(';')[i]}\n");
				}
				//Output.Write($"{s}: {Environment.GetEnvironmentVariables()[s]}\n");
			}
			return 0;
		}
	}
}
