using UnityEngine;

[RequireComponent(typeof(Ship))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private Ship ship;

    private void Update()
    {
        Movement();
        Weapons();
    }

    private void Movement()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        Vector3 screenSpace = new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z);
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(screenSpace);

        int screenPadding = 1;

        bool tooFarUp = yInput > 0 && transform.position.y > screenBounds.y - screenPadding;
        bool tooFarDown = yInput < 0 && transform.position.y < -screenBounds.y + screenPadding;
        if (tooFarUp || tooFarDown)
        {
            yInput = 0;
        }

        bool tooFarRight = xInput > 0 && transform.position.x > screenBounds.x - screenPadding;
        bool rooFarLeft = xInput < 0 && transform.position.x < -screenBounds.x + screenPadding;
        if (tooFarRight || rooFarLeft)
        {
            xInput = 0;
        }

        ship.SetInputVector(xInput, yInput);
    }
}