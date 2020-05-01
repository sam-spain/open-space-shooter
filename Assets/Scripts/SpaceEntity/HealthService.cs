using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceObjects
{
    // Responsible for handling damage to health
    internal class HealthService : MonoBehaviour
    {
        [SerializeField]
        private float baseHP;

        [SerializeField]
        private float currentHP;

        private void Start() {
            currentHP = baseHP;
        }

        internal void TakeHit(float hitAmount) {
            currentHP -= hitAmount;
        }

        internal bool WasFatalHit() {
            return currentHP <= 0;
        }
    }
}