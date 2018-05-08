# BTM_HarmonyLogger
Tool for modders to easily set up a logging logic during mod development.

The aim is to easily be able to check if the patched methods are called in-game and to be able to establish the workflow of a specific classes combination and to provide general information with output like :

>  Class: Mech - Runtime: BattleTech.Mech - Method: ApplyBraced - Vehicule: Orion - Pilot: LSD

>  Class: AbstractActor - Runtime: BattleTech.Mech - Method: OnFiringBegin - Vehicule: Orion - Pilot: LSD

>  Class: AbstractActor - Runtime: BattleTech.Vehicle - Method: OnFiringBegin - Vehicule: Striker - Pilot: Flanker

>  Class: AbstractActor - Runtime: BattleTech.Vehicle - Method: ApplyBraced - Vehicule: Bulldog - Pilot: Outrider

As for now the logger will log every active methods in HarmonyLogger/HarmonyLogger.log and a duplicate in HarmonyLogger/<ClassName>.log


