using UnityEngine;
using BepInEx;
using Nyxpiri.ULTRAKILL.NyxLib;

namespace Nyxpiri.ULTRAKILL.AggressiveAgony
{
    [BepInPlugin("com.nyxpiri.bepinex.plugins.ultrakill.aggressive-agony", "Aggressive Agony", "0.0.0.1")]
    [BepInProcess("ULTRAKILL.exe")]
    public class AggressiveAgonyPlugin : BaseUnityPlugin
    {
        protected void Awake()
        {
            Log.Initialize(Logger);

            AggressiveAgony.Initialze();
        }

        protected void Start()
        {
        }

        protected void Update()
        {

        }

        protected void LateUpdate()
        {

        }
    }
}
