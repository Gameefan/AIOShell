﻿using System;

namespace AIOShell
{
	public static class Output
	{
		public static ConsoleColor defaultColor = Console.ForegroundColor;
		public static string Write(string s, ConsoleColor color = ConsoleColor.Gray, bool displayPrefix = false)
		{
			string msg = $"{s}";
			if (CommandManager.currentCommand != "" && displayPrefix)
			{
				msg = CommandManager.currentCommand + ": " + msg;
				if (!Program.disableColors)
					Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write($"{CommandManager.currentCommand}: ");
			}
			if (!Program.disableColors)
				Console.ForegroundColor = color;
			Console.Write(s);
			Console.ResetColor();
			return msg;
		}
		public static string WriteWarning(string s, ConsoleColor color = ConsoleColor.Yellow, bool displayPrefix = true)
		{
			string msg = $"Warning: {s}";
			if (CommandManager.currentCommand != "" && displayPrefix)
			{
				msg = CommandManager.currentCommand + ": " + msg;
				if (!Program.disableColors)
					Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write($"{CommandManager.currentCommand}: ");
			}
			if (!Program.disableColors)
				Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("Warning: ");
			if (!Program.disableColors)
				Console.ForegroundColor = color;
			Console.Write(s);
			Console.ResetColor();
			return msg;
		}
		public static string WriteError(string s, ConsoleColor color = ConsoleColor.Red, bool displayPrefix = true)
		{
			string msg = $"Error: {s}";
			if (CommandManager.currentCommand != "" && displayPrefix)
			{
				msg = CommandManager.currentCommand + ": " + msg;
				if (!Program.disableColors)
					Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write($"{CommandManager.currentCommand}: ");
			}
			if (!Program.disableColors)
				Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Error: ");
			if (!Program.disableColors)
				Console.ForegroundColor = color;
			Console.Write(s);
			Console.ResetColor();
			return msg;
		}
		public static string WriteDebug(string s, ConsoleColor color = ConsoleColor.Cyan, bool displayPrefix = true)
		{
			if (!CommandManager.debugEnabled)
				return "";
			string msg = $"Debug: {s}";
			if (CommandManager.currentCommand != "" && displayPrefix)
			{
				msg = CommandManager.currentCommand + ": " + msg;
				if (!Program.disableColors)
					Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write($"{CommandManager.currentCommand}: ");
			}
			if (!Program.disableColors)
				Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("Debug: ");
			if (!Program.disableColors)
				Console.ForegroundColor = color;
			Console.Write(s);
			Console.ResetColor();
			return msg;
		}
	}
}
