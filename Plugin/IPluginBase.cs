﻿using System;

namespace DalamudPluginCommon
{
	public interface IPluginBase
	{
		Localization Localization { get; }
		string PluginName { get; }
		void PrintMessage(string message);
		string GetSeIcon(SeIconChar seIconChar);
		uint? GetLocalPlayerHomeWorld();
		void LogInfo(string messageTemplate);
		void LogInfo(string messageTemplate, params object[] values);
		void LogError(string messageTemplate);
		void LogError(string messageTemplate, params object[] values);
		void LogError(Exception exception, string messageTemplate, params object[] values);
		bool IsKeyPressed(ModifierKey.Enum key);
		bool IsKeyPressed(PrimaryKey.Enum key);
		void SaveConfig(dynamic config);
		dynamic LoadConfig();
		void Dispose();
		string PluginFolder();
		void UpdateResources();
		void CreateDataFolder();
		string PluginVersion();
	}
}