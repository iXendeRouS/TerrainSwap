using MelonLoader;
using BTD_Mod_Helper;
using TerrainSwap;
using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models;

[assembly: MelonInfo(typeof(TerrainSwap.TerrainSwap), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace TerrainSwap;

public class TerrainSwap : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<TerrainSwap>("TerrainSwap loaded!");
    }

    public override void OnNewGameModel(GameModel result, MapModel map)
    {
        base.OnNewGameModel(result, map);

        if (!Settings.SwapTerrain) return;

        foreach (var area in map.areas)
        {
            if (area.type == AreaType.water)
            {
                area.type = AreaType.land;
            }
            else if (area.type == AreaType.land)
            {
                area.type = AreaType.water;
            }
        }

        MelonLogger.Msg("Swapped water and land terrain");
    }
}