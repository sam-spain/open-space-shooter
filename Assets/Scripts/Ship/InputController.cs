using UnityEngine;

namespace SpaceObjects
{
    [RequireComponent(typeof(Ship))]
    public class InputController : MonoBehaviour
    {
        [SerializeField]
        private Ship ship;

        private void Update()
        {
            HandleMovementInput();
            HandleWeaponsInput();
        }

        private void HandleMovementInput()
        {
            float xInput = Input.GetAxis("Horizontal");
            float yInput = Input.GetAxis("Vertical");
            ship.SetInputVector(xInput, yInput);
        }

        private void HandleWeaponsInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ship.FireWeapons();
            }
        }
    }
}