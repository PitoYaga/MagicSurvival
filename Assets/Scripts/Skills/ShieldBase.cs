using System;
using Enemies;
using Player;
using UnityEngine;

namespace Skills
{
    public class ShieldBase : MonoBehaviour
    {
        [SerializeField] int maxShieldHealth = 2;
        [SerializeField] private float shieldCooldown = 60;
        public bool hasShield;

        private int _currentHealth;
        float _timer = 0;
        
        void Start()
        {
            _currentHealth = maxShieldHealth;
            transform.SetParent(FindObjectOfType<PlayerMovement>().transform);
        }

       
        void Update()
        {
            ShieldRepair();
            ShieldCheck();
        }
        
        void ShieldRepair()
        {
            if (_currentHealth < maxShieldHealth)
            {
                _timer += Time.deltaTime;
                if (_timer >= shieldCooldown)
                {
                    _timer = 0;
                    _currentHealth++;
                }
            }
        }

        void ShieldCheck()
        {
            if (_currentHealth > 0)
            {
                hasShield = true;
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Constants.enemyTag))
            {
                _currentHealth--;
                other.GetComponent<BasicEnemy>().Attack();
                Debug.Log(_currentHealth);
            }
        }

       
        
        
        
    }
}
