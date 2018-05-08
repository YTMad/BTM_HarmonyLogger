using System.IO;
using System.Reflection;
using BattleTech;
using Harmony;

namespace HarmonyLogger {
	#region Mech
	[HarmonyPatch(typeof(BattleTech.Mech), "ApplyBraced")]
	public static class BattleTech_Mech_ApplyBraced_PostFix
	{
		static void Postfix(Mech __instance)
		{
			HarmonyLogger.Log("Mech", $"Class: Mech - Runtime: {__instance.GetType()} - Method: ApplyBraced - Vehicule: {__instance.DisplayName} - Pilot: {__instance.GetPilot().Name}");
		}
	}
	#endregion
}