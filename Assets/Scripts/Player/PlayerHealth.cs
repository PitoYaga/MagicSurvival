using System;
using Enemies;
using Game;
using Skills;
using UnityEngine;

namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private float playerHealth = 100;
        [SerializeField] private int healthMultiplyer = 20;

        void Start()
        {
        
        }

        
        void Update()
        {
        
        }

        void GetDamage(float damage)
        {
            if (FindObjectOfType<ShieldBase>() == null)
            {
                playerHealth -= damage;
            }
            else if (!FindObjectOfType<ShieldBase>().hasShield)
            {
                playerHealth -= damage;
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Constants.enemyTag))
            {
                GetDamage(other.GetComponent<BasicEnemy>().enemyDamage);
                other.GetComponent<BasicEnemy>().Attack();
            }
        }
    }
}
