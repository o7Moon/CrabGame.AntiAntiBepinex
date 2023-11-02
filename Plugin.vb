Imports Bepinex
Imports Bepinex.IL2CPP
Imports HarmonyLib

Class PluginInfo
    Public Const PLUGIN_GUID = "AntiAntiBepinex"
    Public Const PLUGIN_NAME = "AntiAntiBepinex"
    Public Const PLUGIN_VERSION = "1.0.0"
End Class

<BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)> _
Class Plugin
    Inherits BasePlugin

    Public Overrides Sub Load()
        Harmony.CreateAndPatchAll(GetType(Patch))
        Log.LogInfo("Loaded AntiAntiBepinex")
    End Sub

    Class Patch 
        <HarmonyPatch(GetType(MonoBehaviourPublicGataInefObInUnique), "Method_Private_Void_GameObject_Boolean_Vector3_Quaternion_0"),
        HarmonyPatch(GetType(MonoBehaviourPublicCSDi2UIInstObUIloDiUnique), "Method_Private_Void_0"),
        HarmonyPatch(GetType(MonoBehaviourPublicVesnUnique), "Method_Private_Void_0"),
        HarmonyPatch(GetType(MonoBehaviourPublicObjomaOblogaTMObseprUnique), "Method_Public_Void_PDM_2"),
        HarmonyPatch(GetType(MonoBehaviourPublicTeplUnique), "Method_Private_Void_PDM_32"),
        HarmonyPrefix> 
        Public Shared Function Prefix(__originalMethod As System.Reflection.MethodBase) As Boolean
            Return False
        End Function
    End Class
End Class

