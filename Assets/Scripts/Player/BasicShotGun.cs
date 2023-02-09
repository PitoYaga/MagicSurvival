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

        }

        void Update()
        {
            _shootPos = new Vector2(transform.position.x, transform.position.y + shootOffset);
            BasicShoot();
            FindClosestEnemy();
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

        //shoot nearest enemy

        void FindClosestEnemy()
        {
            float distanceToClosestEnemy = Mathf.Infinity;
            GameObject closestEnemy = null;
            GameObject[] allEnemies = GameObject.FindGameObjectsWithTag(Constants.enemyTag);
            foreach (GameObject currentEnemy in allEnemies)
            {
                float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
                if (distanceToEnemy < distanceToClosestEnemy)
                {
                    distanceToClosestEnemy = distanceToEnemy;
                    closestEnemy = currentEnemy;
                
                }
                transform.LookAt(closestEnemy.transform.position);
            }

        }
    }
}
        
