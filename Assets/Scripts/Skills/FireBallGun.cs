using Game;
using UnityEngine;

namespace Skills
{
    public class FireBallGun : MonoBehaviour
    {
        [SerializeField] private GameObject fireBallBullet;
        [SerializeField] private int damageMultiply = 15;
        [SerializeField] private int fireSpeedMultiply = 10;
        [SerializeField] private float shootInterval = 1.2f;
        [SerializeField] private float shootOffset = 0.6f;
        [SerializeField] private float shootRange = 10;

        GameObject _barrelPos;
        private float _timer;
        private float _damage;
        private int _fireBallLevel;
        private GameObject _player;


        void Start()
        {
            _player = GameObject.FindWithTag(Constants.playerGunTag);
            _barrelPos = GameObject.FindWithTag(Constants.barrelTag);
            
            transform.SetParent(_player.transform); // delete this later, after the level up canvas
        }
    
        void Update()
        {
            _damage = ValueBank.FireBallDamage;

            FireBallShoot();
            FireBallUpgrade(); 
        }

        void FireBallShoot()
        {
            _timer += Time.deltaTime;
        
            if (_timer >= shootInterval)
            {
                GameObject fireBallCopy = Instantiate(fireBallBullet, _barrelPos.transform.position, transform.parent.rotation);
                _timer = 0;
            }
        }

        //shoot nearest enemy

        void FireBallUpgrade()
        {
            if (ValueBank.fireBallLevel != _fireBallLevel)
            {
                _fireBallLevel = ValueBank.fireBallLevel;
                _damage = _damage + ((_damage * damageMultiply) / 100);
                ValueBank.FireBallDamage = _damage;
                shootInterval = shootInterval - ((shootInterval * fireSpeedMultiply) / 100);
            }
        }
        
        
    }
}
