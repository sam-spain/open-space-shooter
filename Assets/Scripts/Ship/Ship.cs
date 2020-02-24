using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceObjects
{
    internal class Ship : MonoBehaviour
    {

        [SerializeField]
        private ShipMotor motor;

        [SerializeField]
        private ShipWeaponSystem weaponSystem;

        private void Start()
        {
            motor = GetComponent<ShipMotor>();
            weaponSystem = GetComponent<ShipWeaponSystem>();
        }
        internal void SetInputVector(float x, float y)
        {
            if (motor != null)
            {
                motor.SetInput(x, y);
            }
        }

        internal void FireWeapons()
        {
            if (weaponSystem != null)
            {
                weaponSystem.FireWeapon();
            }
        }

        internal void takeHit()
        {
            Destroy(this.gameObject);
        }
    }

}