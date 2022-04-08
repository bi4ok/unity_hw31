using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private bool _isBegin=false;

    public Vector2 GetTouchDelta()
    {
        if (Input.touchCount > 0)
        {
            Touch currentTouch = Input.GetTouch(0);
            if (currentTouch.phase == TouchPhase.Began)
            {
                _isBegin = true;
            }
            else if (currentTouch.phase == TouchPhase.Ended)
            {
                _isBegin = false;
                return Vector2.zero;
            }
            if (_isBegin)
            {
                return currentTouch.deltaPosition;
            }
            
        }
        return Vector2.zero;
    }

    public bool IsThereTouchOnScreen()
    {
        return Input.touchCount > 0;
    }
}
