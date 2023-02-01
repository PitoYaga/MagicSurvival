using UnityEngine;

namespace Player
{
    public class XPHandler : MonoBehaviour
    {
        [SerializeField] float maxXp;
        [SerializeField] float xPMultiply = 15;
        [SerializeField] private int smallCyristal = 10;
        [SerializeField] private int midCyristal = 15;
        [SerializeField] private int bigCyristal = 20;
        private int _level = 1;
        private float _currentXp;
        private bool _levelUp;
    
        void Start()
        {
        
        }

    
        void Update()
        {
            LevelCalculator();
        }

        void LevelCalculator()
        {
            if (_currentXp >= maxXp)
            {
                _level++;
                maxXp = ((maxXp / 100) * xPMultiply) + maxXp;
                _levelUp = true;
            }
        }

        void CollectPoints(int cyristalValue)
        {
            _currentXp += cyristalValue;
        }

        void EnemyKilled()
        {
        
        }
    

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("SmallCyristal"))
            {
                CollectPoints(smallCyristal);
            }
            else if (other.CompareTag("MidCyristal"))
            {
                CollectPoints(midCyristal);
            }
            else if (other.CompareTag("BigCyristal"))
            {
                CollectPoints(bigCyristal);
            }
        
            Destroy(other.gameObject);
            Debug.Log(_currentXp);
        }
    }
}
