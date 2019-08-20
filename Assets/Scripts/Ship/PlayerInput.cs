using UnityEngine;

[RequireComponent(typeof(ShipMotor))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private ShipMotor shipMotor;

    private void Update()
    {
        movement();
    }

    private void movement()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        Vector3 screenSpace = new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z);
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(screenSpace);

        if (yInput > 0 && transform.position.y > screenBounds.y - 1)
        {
            yInput = 0;
        }
        else if (yInput < 0 && transform.position.y < -screenBounds.y + 1)
        {
            yInput = 0;
        }

        if (xInput > 0 && transform.position.x > screenBounds.x - 1)
        {
            xInput = 0;
        }
        else if (xInput < 0 && transform.position.x < -screenBounds.x + 1)
        {
            xInput = 0;
        }

        shipMotor.setInput(xInput, yInput);
    }
}