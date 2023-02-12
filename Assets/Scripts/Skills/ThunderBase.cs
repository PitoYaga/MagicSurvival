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
        
        private float _timer;
        private float _damage;
        private int _fireBallLevel;
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
                _timer = 0;
                x = Random.Range (-2.6f, 2.6f);
                y = Random.Range (-4.8f, 4.8f);
                GameObject thunderCopy = Instantiate(thunder, new Vector3(x, y, 0), Quaternion.identity);
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
            }
        }
    }
}
