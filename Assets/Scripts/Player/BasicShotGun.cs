using UnityEngine;

namespace Player
{
    public class BasicShotGun : MonoBehaviour
    {
        [SerializeField] private GameObject bullet;
        [SerializeField] private float shootInterval = 1;
        [SerializeField] private float shootOffset = 2;
        [SerializeField] private float shootRange = 10;

        private Vector2 _shootPos;
        private float _timer;


        void Start()
        {
            _shootPos = new Vector2(transform.position.x, transform.position.y + shootOffset);
        }
    
        void Update()
        {
            BasicShoot();
        }

        void BasicShoot()
        {
            _timer += Time.deltaTime;
        
            if (_timer >= shootInterval)
            {
                GameObject bulletCopy = Instantiate(bullet, _shootPos, Quaternion.identity);
                _timer = 0;
            }
        }
    }
}
