using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceObjects
{
    internal class Ship : SpaceEntity
    {
        private void Start()
        {
            motorService = GetComponent<MotorService>();
            weaponService = GetComponent<WeaponService>();
            healthService = GetComponent<HealthService>();
        }
        internal void SetInputVector(float x, float y)
        {
            if (motorService != null)
            {
                motorService.SetInput(x, y);
            }
        }

        internal void FireWeapons()
        {
            if (weaponService != null)
            {
                weaponService.FireWeapon();
            }
        }

        internal void TakeHit()
        {
            healthService.TakeHit(1F);
            if(healthService.WasFatalHit()) {
                Destroy(this.gameObject);
            }
        }
    }

}