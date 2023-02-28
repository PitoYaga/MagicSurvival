using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedJoystick : Joystick
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        PlayerControllerJoystick.PointerDown = false;
        base.OnPointerDown(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        PlayerControllerJoystick.PointerDown = true;
        base.OnPointerUp(eventData);
    }
}