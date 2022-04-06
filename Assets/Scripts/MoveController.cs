using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private InputController inputHandler;
    [SerializeField] private Rigidbody platform;
    [SerializeField] private float speed;


    void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        if (inputHandler.IsThereTouchOnScreen())
        {
            Vector2 currDeltaPosition = inputHandler.GetTouchDelta();
            Vector3 platformTorque = new Vector3( -1 * currDeltaPosition.y, 0, currDeltaPosition.x);
            if (currDeltaPosition.x == 0 && currDeltaPosition.y == 0)
            {
                platform.angularVelocity = Vector3.zero;
            }
            else
            {
                platform.AddTorque(platformTorque * speed);
            }
            
            
        }
    }
}
