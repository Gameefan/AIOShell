using AIOShell.Interfaces;
using System;
using System.IO;

namespace AIOShell.Commands
{
	public class CompareCommand : ICommand
	{
		public int Execute(string[] args)
		{
			if(args.Length<5)
			{
				Output.WriteError("Invalid arguments!\n");
				return 1;
			}
			string newArgs = "";
			int cmpmode = 0;
			try
			{
				switch(int.Parse(args[3]))
				{
					case 0: // eq
						cmpmode = 0;
						break;
					case 1: // lt
						cmpmode = 1;
						break;
					case 2: // gt
						cmpmode = 2;
						break;
					case 3: // neq
						cmpmode = 3;
						break;
					case 4: // nlt
						cmpmode = 4;
						break;
					case 5: // ngt
						cmpmode = 5;
						break;
					default:
						throw new Exception();
				}
			}
			catch (Exception)
			{
				Output.WriteError("Invalid cmp-mode!\n");
				return 2;
			}
			//if(args[1]==args[2])
			if((cmpmode == 0 && args[1] == args[2]) || (cmpmode == 1 && int.Parse(args[1]) < int.Parse(args[2])) || (cmpmode == 2 && int.Parse(args[1]) > int.Parse(args[2])) || (cmpmode == 3 && args[1] != args[2]) || (cmpmode == 4 && int.Parse(args[1]) >= int.Parse(args[2])) || (cmpmode == 5 && int.Parse(args[1]) <= int.Parse(args[2])))
			{
				for (int i = 4; i < args.Length; i++)
				{
					newArgs += args[i];
					newArgs += " ";
				}
				return CommandManager.FetchCommand(newArgs);
			}

			return 0;
		}

		public string GetHelpID()
		{
			return "compare";
		}
	}
}
