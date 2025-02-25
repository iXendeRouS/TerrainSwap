using BTD_Mod_Helper.Api.Data;
using BTD_Mod_Helper.Api.ModOptions;

namespace TerrainSwap
{
    public class Settings : ModSettings
    {
        public static readonly ModSettingBool SwapTerrain = new ModSettingBool(true)
        {
            description = "While enabled, swap land and water terrain and vice versa."
        };
    }
}
