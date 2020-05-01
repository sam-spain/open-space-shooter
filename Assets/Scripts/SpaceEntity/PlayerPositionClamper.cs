using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceObjects
{
    public class PlayerPositionClamper : MonoBehaviour
    {
        private void LateUpdate()
        {
            ClampPosition();
        }

        private void ClampPosition()
        {
            Vector3 position = Camera.main.WorldToViewportPoint(transform.position);
            position.x = Mathf.Clamp(position.x, 0.05F, 0.95F);
            position.y = Mathf.Clamp(position.y, 0.1F, 0.9F);
            transform.position = Camera.main.ViewportToWorldPoint(position);
        }
    }
}