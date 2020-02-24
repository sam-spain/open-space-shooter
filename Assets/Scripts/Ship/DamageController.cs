using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceObjects
{
    // When ships or other space objects are hit then this handles 
    // telling the base component to receive damage
    [RequireComponent(typeof(Ship))]
    public class DamageController : MonoBehaviour
    {

        private Ship ship;
        private void Start()
        {
            ship = GetComponent<Ship>();
        }
        public void TakeHit()
        {
            Debug.Log("Controller took hit");
            ship.TakeHit();
        }
    }
}