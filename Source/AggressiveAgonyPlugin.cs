using UnityEngine;
using BepInEx;
using Nyxpiri.ULTRAKILL.NyxLib;
using System;
using System.IO;

namespace Nyxpiri.ULTRAKILL.AggressiveAgony
{
    public static class Cheats
    {
        public const string AggressiveAgony = "nyxpiri.aggressive-agony";
    } 

    [BepInPlugin("nyxpiri.ultrakill.aggressive-agony", "Aggressive Agony", "0.0.0.1")]
    [BepInProcess("ULTRAKILL.exe")]
    public class AggressiveAgonyPlugin : BaseUnityPlugin
    {
        protected void Awake()
        {
            Log.Initialize(Logger);

            AggressiveAgony.Initialze();
            NyxLib.Cheats.ReadyForCheatRegistration += RegisterCheats;
            Options.Initialize(Config);
            
            if (!File.Exists(Config.ConfigFilePath))
            {
                Config.Save();
            }
        }

        private void RegisterCheats(CheatsManager cheatsManager)
        {
            cheatsManager.RegisterCheat(new ToggleCheat(
                "Aggressive Agony", 
                Cheats.AggressiveAgony,
                onDisable: (cheat) =>
                {
                },
                onEnable: (cheat, manager) =>
                {
                }
            ), "HELL'S IMPACT");
        }

        protected void Start()
        {
        }

        protected void Update()
        {

        }

        protected void OnApplicationFocus(bool hasFocus)
        {
            if (hasFocus)
            {
                Config.Reload();
            }
        }
        
        protected void LateUpdate()
        {

        }
    }
}
