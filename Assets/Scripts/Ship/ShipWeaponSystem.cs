using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeaponSystem : MonoBehaviour
{
    [SerializeField]
    private ShipWeapon[] weapons;

    private int weaponToFireIndex;

    private void Start() {
        weapons = GetComponentsInChildren<ShipWeapon>();
    }
    public void FireWeapon() {
        // Do timeout stuff here
        weapons[weaponToFireIndex].Fire();
        IncreaseFireIndex();
    }

    private void IncreaseFireIndex() {
        weaponToFireIndex++;
        if(weapons.Length <= weaponToFireIndex) {
            weaponToFireIndex = 0;
        }
    }
}
