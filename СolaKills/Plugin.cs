using HarmonyLib;
using Exiled.API.Features;

namespace СolaKills
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "angelseraphim.";
        public override string Name => "СolaKills";
        public override string Prefix => "СolaKills";

        public static Plugin plugin;
        public static Harmony harmony;
        public override void OnEnabled()
        {
            plugin = this;
            harmony = new Harmony("ColaKils");
            harmony.PatchAll();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            plugin = null;
            harmony.UnpatchAll();
            base.OnDisabled();
        }
    }
}
