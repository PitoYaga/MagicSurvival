using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        public float basicSpeed = 5;

        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        void Start()
        {
        
        }

    
        void Update()
        {
            Movement();
        }

        public void Movement()
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");

            _rigidbody2D.velocity = new Vector2(h, v) * (basicSpeed * Time.deltaTime);
        }
    
   
    }
}
