using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceObjects
{
    internal class WeaponService : MonoBehaviour
    {
        [SerializeField]
        private WeaponPlatform[] weaponPlatforms;

        private int weaponToFireIndex;

        private void Start()
        {
            weaponPlatforms = GetComponentsInChildren<WeaponPlatform>();
        }
        internal void FireWeapon()
        {
            // Do timeout stuff here
            weaponPlatforms[weaponToFireIndex].Fire();
            IncreaseFireIndex();
        }

        private void IncreaseFireIndex()
        {
            weaponToFireIndex++;
            if (weaponPlatforms.Length <= weaponToFireIndex)
            {
                weaponToFireIndex = 0;
            }
        }
    }
}