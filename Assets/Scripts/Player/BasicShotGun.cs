using Unity.Mathematics;
using UnityEngine;

namespace Player
{
    public class BasicShotGun : MonoBehaviour
    {
        [SerializeField] private GameObject bullet;
        [SerializeField] private float shootInterval = 1;
        [SerializeField] private float shootOffset = 2;
        [SerializeField] private float shootRange = 10;
        
        GameObject barrelPos;
        
        private float _timer;


        void Start()
        {
            barrelPos = GameObject.FindWithTag(Constants.barrelTag);
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
                GameObject bulletCopy = Instantiate(bullet, barrelPos.transform.position, transform.rotation);
                _timer = 0;
            }
        }

        
       
        
        
    }
}
        
