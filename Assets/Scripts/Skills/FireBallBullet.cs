using System;
using UnityEngine;

namespace Skills
{
    public class FireBallBullet : MonoBehaviour
    {
        [SerializeField] private float fireBallSpeed = 35;

        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        void Start()
        {
            _rigidbody2D.AddForce(transform.up * (fireBallSpeed * Time.deltaTime));
            //anim
            Destroy(gameObject, 2);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            _rigidbody2D.velocity = Vector2.zero;
            //explosion anim
            //when anim is finish, destroy 
            
            Destroy(gameObject);
        }
    }
}
