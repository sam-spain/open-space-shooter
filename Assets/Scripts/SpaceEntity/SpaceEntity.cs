using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceObjects
{
    internal class SpaceEntity : MonoBehaviour
    {
        [SerializeField]
        protected MotorService motorService;

        [SerializeField]
        protected WeaponService weaponService;

        [SerializeField]
        protected HealthService healthService;

    }
}