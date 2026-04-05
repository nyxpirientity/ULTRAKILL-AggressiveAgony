using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine.Assertions;

namespace Nyxpiri.ULTRAKILL.AggressiveAgony
{
    public static class Options
    {
        internal static void Initialize(ConfigFile config)
        {
            Assert.IsNotNull(config);
            _config = config;

            HomingProjectileParryPunchStaminaGain = _config.Bind("Balance.ParryGains", "HomingProjectileParryPunchStaminaGain", 0.15f, "Amount of punch stamina gained when parrying/boosting a homing projectile spawned by pain");
            HomingProjectileParryHealthGain = _config.Bind("Balance.ParryGains", "HomingProjectileParryHealthGain", 30,"Amount of health gained when parrying/boosting a homing projectile spawned by pain");
            HomingProjectileParryEnergyGain = _config.Bind("Balance.ParryGains", "HomingProjectileParryEnergyGain", 125, "Amount of energy gained when parrying/boosting a homing projectile spawned by pain");
            
            HomingProjectileDamage = _config.Bind("Balance.Damage", "HomingProjectileDamage", 35, "Amount of energy gained when parrying/boosting a homing projectile spawned by pain");
            ULTRAHomingProjectileDamage = _config.Bind("Balance.Damage", "ULTRAHomingProjectileDamage", 50, "");

            ULTRAHomingProjectileExplosionDamageScale = _config.Bind("Balance.Damage", "ULTRAHomingProjectileExplosionDamageScale", 1.0f, "");
            ULTRAHomingProjectileExplosionSizeScale = _config.Bind("Balance.Damage", "ULTRAHomingProjectileExplosionSizeScale", 0.5f, "");
            ULTRAHomingProjectileExplosionSpeedScale = _config.Bind("Balance.Damage", "ULTRAHomingProjectileExplosionSpeedScale", 0.5f, "");
           
            MortarParryHealthGain = _config.Bind("Balance.ParryGains", "MortarParryHealthGain", 35,"Amount of health gained when parrying/boosting a mortar spawned by pain");
            MortarParryEnergyGain = _config.Bind("Balance.ParryGains", "MortarParryEnergyGain", 125, "Amount of energy gained when parrying/boosting a mortar spawned by pain");
            MortarParryPunchStaminaGain = _config.Bind("Balance.ParryGains", "MortarParryPunchStaminaGain", 0.15f, "Amount of punch stamina gained when parrying/boosting a homing projectile spawned by pain");

            MortarDamage = _config.Bind("Balance.Damage", "MortarDamage", 50, "");
            MortarExplosionDamageScale = _config.Bind("Balance.Damage", "MortarExplosionDamageScale", 1.0f, "");
            MortarExplosionSizeScale = _config.Bind("Balance.Damage", "MortarExplosionSizeScale", 0.85f, "");
            MortarExplosionSpeedScale = _config.Bind("Balance.Damage", "MortarExplosionSpeedScale", 0.85f, "");

            ULTRAMortarDamage = _config.Bind("Balance.Damage", "ULTRAMortarDamageScale", 50, "");
            ULTRAMortarExplosionDamageScale = _config.Bind("Balance.Damage", "ULTRAMortarExplosionDamageScale", 1.0f, "");
            ULTRAMortarExplosionSizeScale = _config.Bind("Balance.Damage", "ULTRAMortarExplosionSizeScale", 0.85f, "");
            ULTRAMortarExplosionSpeedScale = _config.Bind("Balance.Damage", "ULTRAMortarExplosionSpeedScale", 0.85f, "");
        }

        private static ConfigFile _config = null;

        public static ConfigEntry<int> HomingProjectileParryHealthGain { get; private set; }
        public static ConfigEntry<int> HomingProjectileParryEnergyGain { get; private set; }
        public static ConfigEntry<float> HomingProjectileParryPunchStaminaGain { get; private set; }
        public static ConfigEntry<int> HomingProjectileDamage { get; private set; }
        public static ConfigEntry<int> ULTRAHomingProjectileDamage { get; private set; }
        public static ConfigEntry<float> ULTRAHomingProjectileExplosionDamageScale { get; private set; }
        public static ConfigEntry<float> ULTRAHomingProjectileExplosionSizeScale { get; private set; }
        public static ConfigEntry<float> ULTRAHomingProjectileExplosionSpeedScale { get; private set; }
        public static ConfigEntry<int> MortarParryHealthGain { get; private set; }
        public static ConfigEntry<int> MortarParryEnergyGain { get; private set; }
        public static ConfigEntry<float> MortarParryPunchStaminaGain { get; private set; }
        public static ConfigEntry<int> MortarDamage { get; private set; }
        public static ConfigEntry<float> MortarExplosionDamageScale { get; private set; }
        public static ConfigEntry<float> MortarExplosionSizeScale { get; private set; }
        public static ConfigEntry<float> MortarExplosionSpeedScale { get; private set; }
        public static ConfigEntry<int> ULTRAMortarDamage { get; private set; }
        public static ConfigEntry<float> ULTRAMortarExplosionDamageScale { get; private set; }
        public static ConfigEntry<float> ULTRAMortarExplosionSizeScale { get; private set; }
        public static ConfigEntry<float> ULTRAMortarExplosionSpeedScale { get; private set; }
    }
}
