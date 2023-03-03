using System;
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
        }

       
        void Update()
        {
            ShieldRepair();
            ShieldCheck();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Constants.enemyTag))
            {
                _currentHealth--;
            }
        }

        void ShieldRepair()
        {
            if (_currentHealth < maxShieldHealth)
            {
                _timer += Time.deltaTime;
                if (_timer >= shieldCooldown)
                {
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
        
        
    }
}
