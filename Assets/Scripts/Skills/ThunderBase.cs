using Game;
using UnityEngine;

namespace Skills
{
    public class ThunderBase : MonoBehaviour
    {
        [SerializeField] private GameObject thunder;
        [SerializeField] private float shootInterval = 2f;
        [SerializeField] private int damageMultiply = 15;
        [SerializeField] private int fireSpeedMultiply = 10;
        [SerializeField] private int minThunderCount = 1;
        [SerializeField] private int maxThunderCount = 3;
        
        private float _timer;
        private float _damage;
        private int _fireBallLevel;
        private int _thunderCount;
        float x;
        float y;
        private GameObject _player;
        
        void Start()
        {
            _player = GameObject.FindWithTag(Constants.playerGunTag);

            transform.SetParent(_player.transform); // delete this later, after the level up canvas
        }
        
        void Update()
        {
            ThunderRain();
            ThunderUpgrade();
        }

        void ThunderRain()
        {
            _timer += Time.deltaTime;

            if (_timer >= shootInterval)
            {
                _thunderCount = Random.Range(minThunderCount, maxThunderCount);
                
                for (int i = 0; i < _thunderCount; i++)
                {
                    x = Random.Range (-2.6f, 2.6f);
                    y = Random.Range (-4.8f, 4.8f);
                    GameObject thunderCopy = Instantiate(thunder, new Vector3(x, y, 0), Quaternion.identity);
                }
                _timer = 0;
            }
        }

        void ThunderUpgrade()
        {
            if (ValueBank.fireBallLevel != _fireBallLevel)
            {
                _fireBallLevel = ValueBank.fireBallLevel;
                _damage = _damage + ((_damage * damageMultiply) / 100);
                ValueBank.FireBallDamage = _damage;
                shootInterval = shootInterval + ((shootInterval * fireSpeedMultiply) / 100);
                minThunderCount++;
                maxThunderCount++;
            }
        }
        
        
    }
}
