using UnityEngine;

namespace Player
{
    public class PlayerControllerJoystick : MonoBehaviour
    {
        public FixedJoystick joystick;
    
        Rigidbody2D _rb;
    
        Vector2 _movement;
        public float moveSpeed;
        public static bool PointerDown = false;
    
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

    
        void Update()
        {
            _movement.x = joystick.Horizontal;
            _movement.y = joystick.Vertical;
        }
        void FixedUpdate()
        {
            if (PointerDown)
            {
                _rb.velocity = Vector3.zero;
            }
            else
            {
                _rb.MovePosition(_rb.position + _movement * moveSpeed * Time.fixedDeltaTime);
            }
        }
    
    
    }
}
