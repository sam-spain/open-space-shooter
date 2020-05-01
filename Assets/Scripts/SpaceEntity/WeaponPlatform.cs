using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceObjects
{
    internal class WeaponPlatform : MonoBehaviour
    {
        [SerializeField]
        private Transform spawnPosition;
        [SerializeField]
        private GameObject ammunitionPrefab;
        internal void Fire()
        {
            Instantiate(
                ammunitionPrefab, spawnPosition.position, Quaternion.identity);
        }
    }
}