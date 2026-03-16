using System;
using System.Collections;
using System.Collections.Generic;
using Nyxpiri.ULTRAKILL.NyxLib;
using Nyxpiri.ULTRAKILL.PainTracker;
using UnityEngine;

namespace Nyxpiri.ULTRAKILL.AggressiveAgony
{
    public class ParryGainsModifier : MonoBehaviour
    {
        public float ParryHealthGain = 100.0f;
        public float ParryStaminaGain = 300.0f;
        private Projectile _projectile;

        protected void Awake()
        {
            _projectile = GetComponent<Projectile>();        
            PlayerPunchEvents.PreParryProjectile += PreParryProjectile;
        }

        private void PreParryProjectile(EventMethodCanceler canceler, Punch punch, Projectile proj)
        {
            if (!NyxLib.Cheats.Enabled)
            {
                return;
            }

            if (proj != _projectile)
            {
                return;
            }

            proj.playerBullet = true;
            var v1 = NewMovement.Instance;
            v1.GetHealth((int)ParryHealthGain, false, false, true);
            v1.boostCharge += ParryStaminaGain;
        }
    }
}