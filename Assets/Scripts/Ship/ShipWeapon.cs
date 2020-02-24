using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapon : MonoBehaviour
{

    [SerializeField]
    private Transform spawnPosition;
    [SerializeField]
    private GameObject ammunitionPrefab;
    public void Fire()
    {
        Instantiate(
            ammunitionPrefab, spawnPosition.position, Quaternion.identity);
    }
}
