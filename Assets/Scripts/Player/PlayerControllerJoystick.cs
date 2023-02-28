using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerJoystick : MonoBehaviour
{
    public FixedJoystick Joystick;
    
    Rigidbody2D _rb;
    
    
    Vector2 movement;
    public float MoveSpeed;
    public static bool PointerDown = false;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        movement.x = Joystick.Horizontal;
        movement.y = Joystick.Vertical;
        
        //Rotation 
        float hAxis = movement.x;
        float VAxis = movement.y;
        float ZAxis = Mathf.Atan2(hAxis, VAxis) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0f, 0f, -ZAxis);

    }
    void FixedUpdate()
    {
        if (PointerDown)
        {
            _rb.velocity = Vector3.zero;
        }
        else
        {
            _rb.MovePosition(_rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
        }
        
        
    }
}
