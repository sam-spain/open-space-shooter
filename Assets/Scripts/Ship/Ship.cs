using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    [SerializeField]
    private ShipMotor shipMotor;
    public void SetInputVector(float x, float y) 
    {
        shipMotor.SetInput(x, y);
    }

    public void SetWeaponsInput(bool enabled)
    {
        
    }
}
