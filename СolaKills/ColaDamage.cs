using CustomPlayerEffects;
using HarmonyLib;
using Mirror;
using PlayerStatsSystem;

namespace СolaKills
{
    [HarmonyPatch(typeof(Scp207), nameof(Scp207.OnTick))]
    internal class ColaDamage
    {
        private static bool Prefix(Scp207 __instance)
        {
            if (NetworkServer.active && !Vitality.CheckPlayer(__instance.Hub))
            {
                float damage = Plugin.plugin.Config.Damage;
                __instance.Hub.playerStats.DealDamage(new UniversalDamageHandler(damage, DeathTranslations.Scp207));
            }
            return false;
        }
    }
}
