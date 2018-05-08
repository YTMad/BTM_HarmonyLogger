using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BattleTech;
using Harmony;

namespace HarmonyLogger {

	public static class HarmonyLogger
	{
		public static Dictionary<string, string> LogPaths = new Dictionary<string, string>();
		public static /*Type[]*/ string[] Types;
		public static string ModDirectory;

		public static void Init()
		{
			ModDirectory = Path.Combine(Path.GetDirectoryName(VersionManifestUtilities.MANIFEST_FILEPATH), @"..\..\..\Mods\");
			Directory.CreateDirectory(ModDirectory+"/HarmonyLogger");
			
			//todo Register here
			Types = new[] {
				"HarmonyLogger",
				"AbstractActor",
				"Mech"
			};//GetTypesInNamespace(Assembly.GetExecutingAssembly(), "HarmonyLogger");
			
			for (int i = 0; i < Types.Length; i++) {
				LogPaths[Types[i]] = (Path.Combine(ModDirectory, "HarmonyLogger/"+Types[i]/*.Name*/ + ".log"));
				using (var logwriter = File.AppendText(HarmonyLogger.LogPaths[Types[i]])) {
					logwriter?.WriteLine("Init ok");
				}
			}
			var harmony = HarmonyInstance.Create("Battletech.yandrosthemad.HarmonyLogger");
			harmony.PatchAll(Assembly.GetExecutingAssembly());
			
		}
		public static void Log(string pathKey , string message) {
					using (var logwriter = File.AppendText(HarmonyLogger.LogPaths["HarmonyLogger"])) {
						logwriter?.WriteLine(message);
					}
					using (var logwriter = File.AppendText(HarmonyLogger.LogPaths[pathKey])) {
						logwriter?.WriteLine(message);
					}
		}
		
		
//		private static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
//		{
//			return assembly.GetTypes()
//					.Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
//					.ToArray();
//		}
		
	}	

}