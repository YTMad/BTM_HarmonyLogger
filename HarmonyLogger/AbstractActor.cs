using System.IO;
using System.Reflection;
using BattleTech;
using Harmony;

namespace HarmonyLogger {
	#region AbstractActor
	[HarmonyPatch(typeof(BattleTech.AbstractActor), "ApplyBraced")]
	public static class BattleTech_AbstractActor_ApplyBraced_PostFix
	{
		static void Postfix(AbstractActor __instance)
		{
			HarmonyLogger.Log("AbstractActor", $"Class: AbstractActor - Runtime: {__instance.GetType()} - Method: ApplyBraced - Vehicule: {__instance.DisplayName} - Pilot: {__instance.GetPilot().Name}");
		}
	}
	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "ApplyUnsteady")]
//	public static class BattleTech_AbstractActor_ApplyUnsteady_PostFix
//	{
//		static void Postfix(AbstractActor __instance)
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - Runtime : {0} - ApplyUnsteady", __instance.GetType());
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "CanDFATargetFromPosition")]
//	public static class BattleTech_AbstractActor_CanDFATargetFromPosition_PostFix
//	{
//		static void Postfix(AbstractActor __instance, bool __result)
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - Runtime : {0} - CanDFATargetFromPosition - {1}", __instance, __result);
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "CanEngageTarget")]
//	public static class BattleTech_AbstractActor_CanEngageTarget_PostFix
//	{
//		static void Postfix(ref bool __result)
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - CanEngageTarget- {0}", __result);
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "CheckDodge")]
//	public static class BattleTech_AbstractActor_CheckDodge_PostFix
//	{
//		static void Postfix()
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - CheckDodge");
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "CheckForInstability")]
//	public static class BattleTech_AbstractActor_CheckForInstability_PostFix
//	{
//		static void Postfix()
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - CheckForInstability");
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "CheckPilotStatusFromAttack")]
//	public static class BattleTech_AbstractActor_CheckPilotStatusFromAttack_PostFix
//	{
//		static void Postfix()
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - CheckPilotStatusFromAttack");
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "ClearUnsteady")]
//	public static class BattleTech_AbstractActor_ClearUnsteady_PostFix
//	{
//		static void Postfix()
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - ClearUnsteady");
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "ConsumeEvasivePip")]
//	public static class BattleTech_AbstractActor_ConsumeEvasivePip_PostFix
//	{
//		static void Postfix()
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - ConsumeEvasivePip");
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "DodgeChance")]
//	public static class BattleTech_AbstractActor_DodgeChance_PostFix
//	{
//		static void Postfix()
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - DodgeChance");
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "DoneWithActor")]
//	public static class BattleTech_AbstractActor_DoneWithActor_PostFix
//	{
//		static void Postfix()
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - DoneWithActor");
//			}
//		}
//	}
//	
//	[HarmonyPatch(typeof(BattleTech.AbstractActor), "DumpAllEvasivePips")]
//	public static class BattleTech_AbstractActor_DumpAllEvasivePips_PostFix
//	{
//		static void Postfix()
//		{
//			using (var logwriter = File.AppendText(AbstractActorLogger.LogPath)) {
//				logwriter?.WriteLine("AbstractActor - DumpAllEvasivePips");
//			}
//		}
//	}
	
	[HarmonyPatch(typeof(BattleTech.AbstractActor), "OnFiringBegin")]
	public static class BattleTech_AbstractActor_OnFiringBegin_PostFix
	{
		static void Postfix(AbstractActor __instance) {
			//TextWriter.WriteLine("Class: AbstractActor - Runtime: {0} - Method: OnFiringBegin - Vehicule: {1} - Pilot: {2}", __instance.GetType(), __instance.DisplayName, __instance.GetPilot().Name);
			HarmonyLogger.Log("AbstractActor", $"Class: AbstractActor - Runtime: {__instance.GetType()} - Method: OnFiringBegin - Vehicule: {__instance.DisplayName} - Pilot: {__instance.GetPilot().Name}");
		}
	}
	#endregion
}