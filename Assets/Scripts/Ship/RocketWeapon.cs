using System.Collections;
using System.Collections.Generic;
using SpaceObjects;
using UnityEngine;
namespace Weapons
{
    public class RocketWeapon : MonoBehaviour
    {

        [SerializeField]
        private AnimationCurve curve;

        [SerializeField]
        private float speed = 10f;
        private float lifeTime = 0;
        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            lifeTime += Time.deltaTime;
            transform.Translate(Vector3.up * speed * curve.Evaluate(lifeTime) * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            DamageController damageController = other.gameObject.GetComponent<DamageController>();
            if (damageController != null)
                damageController.takeHit();
        }
    }
}