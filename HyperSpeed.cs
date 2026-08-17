global using BTD_Mod_Helper.Extensions;
using MelonLoader;
using BTD_Mod_Helper;
using HyperSpeed;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Simulation.Factory;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

[assembly: MelonInfo(typeof(HyperSpeed.HyperSpeed), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6-Epic")]

namespace HyperSpeed;

public class HyperSpeed : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<HyperSpeed>("HyperSpeed loaded!");
    }
    public override void OnNewGameModel(GameModel result)
    {
        foreach (var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
        }
    }


}