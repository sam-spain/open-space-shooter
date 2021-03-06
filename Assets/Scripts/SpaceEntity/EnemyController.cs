﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceObjects
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField]
        private Vector3 target;

        private bool nearTarget;
        private Ship ship;
        // Start is called before the first frame update
        void Start()
        {
            MakeTarget();
            ship = GetComponent<Ship>();
        }

        internal void MakeTarget()
        {
            target = new Vector3(transform.position.x, transform.position.y - 20f, transform.position.z);
        }

        void Update()
        {
            MoveTowardsTarget();
        }

        internal void MoveTowardsTarget()
        {
            Vector3 heading = target - transform.position;
            float distance = heading.magnitude;
            Vector3 direction = heading / distance;
            if (heading.sqrMagnitude > 1F)
            {
                ship.SetInputVector(direction.x, direction.y);
            } else {
                Destroy(this.gameObject);
            }
        }
    }
}