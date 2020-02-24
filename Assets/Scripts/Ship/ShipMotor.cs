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
    private void LateUpdate() {
        ClampPosition();
    }

    private void ClampPosition()
    {
        Vector3 position = Camera.main.WorldToViewportPoint(transform.position);
        position.x = Mathf.Clamp(position.x, 0.05F, 0.95F);
        position.y = Mathf.Clamp(position.y, 0.1F, 0.9F);
        transform.position = Camera.main.ViewportToWorldPoint(position);
    }

    internal void SetInput(float xInput, float yInput)
    {
        this.xInput = xInput;
        this.yInput = yInput;
    }
}