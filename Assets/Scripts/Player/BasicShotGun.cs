using Game;
using Unity.Mathematics;
using UnityEngine;

namespace Player
{
    public class BasicShotGun : MonoBehaviour
    {
        [SerializeField] private GameObject bullet;
        [SerializeField] private float shootInterval = 1;
        [SerializeField] private float shootIntervalMultiply = 15;
        [SerializeField] private float damageMultiply = 15;
        [SerializeField] private float shootOffset = 2;
        [SerializeField] private float shootRange = 10;
        
        GameObject _barrelPos;
        
        private float _timer;
        private int _basicShootLevel;


        void Start()
        {
            _barrelPos = GameObject.FindWithTag(Constants.barrelTag);
            ValueBank.basicShootLevel = _basicShootLevel;
        }

        void Update()
        {
            BasicShoot();
            BasicShootUpgrade();
        }

        void BasicShoot()
        {
            _timer += Time.deltaTime;

            if (_timer >= shootInterval)
            {
                GameObject bulletCopy = Instantiate(bullet, _barrelPos.transform.position, transform.rotation);
                _timer = 0;
            }
        }

        void BasicShootUpgrade()
        {
            if (ValueBank.basicShootLevel != _basicShootLevel)
            {
                ValueBank.basicShootLevel = _basicShootLevel;
                shootInterval = shootInterval - ((shootInterval * shootIntervalMultiply) / 100);
                ValueBank.bulletDamage = ValueBank.bulletDamage + ((ValueBank.bulletDamage * damageMultiply) / 100);
            }
        }
       
        
        
    }
}
        
