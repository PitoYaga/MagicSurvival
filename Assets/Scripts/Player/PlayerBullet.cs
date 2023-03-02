using System;
using UnityEngine;

namespace Player
{
    public class PlayerBullet : MonoBehaviour
    {
        [SerializeField] private float speed = 50;
        [SerializeField] private int pierCount = 1;
        [SerializeField] private float speedMultiply = 15;

        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        void Start()
        {
            _rigidbody2D.AddForce(transform.up * speed * Time.deltaTime);
            Destroy(gameObject, 2);
        }
    
        void Update()
        {
        
        }
        
        void BasicShootUpgrade()
        {
            
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            pierCount--;
            if (pierCount <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
