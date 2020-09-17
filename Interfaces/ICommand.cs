using System;
using System.Collections.Generic;
using System.Text;

namespace AIOShell.Interfaces
{
	public interface ICommand
	{
		public int Execute(string[] args);
		public string GetHelpID();
	}
}
