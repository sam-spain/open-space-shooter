using UnityEngine;
using static UnityEngine.Time;

public class ShipMotor : MonoBehaviour
{
    private float xInput;
    private float yInput;

    [SerializeField]
    private float baseShipSpeed = 1f;

    private void Update()
    {
        transform.Translate(Vector3.right * xInput * baseShipSpeed * deltaTime);
        transform.Translate(Vector3.up * yInput * baseShipSpeed * deltaTime);
    }

    internal void SetInput(float xInput, float yInput)
    {
        this.xInput = xInput;
        this.yInput = yInput;
    }
}