using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class XPHandler : MonoBehaviour
    {
        [SerializeField] float maxXp = 100;
        [SerializeField] float xPMultiply = 15;
        [SerializeField] private int smallCyristal = 10;
        [SerializeField] private int midCyristal = 15;
        [SerializeField] private int bigCyristal = 20;
        [SerializeField] private Slider xPSlider;
        
        private int _level = 1;
        private float _currentXp;
        private bool _levelUp;
    
        void Start()
        {
            xPSlider.maxValue = maxXp;
        }

    
        void Update()
        {
            _currentXp = ValueBank.currentXp;
            LevelCalculator();
        }

        void LevelCalculator()
        {
            xPSlider.value = _currentXp;

            if (_currentXp >= maxXp)
            {
                _currentXp = 0;
                _level++;
                maxXp = ((maxXp / 100) * xPMultiply) + maxXp;
                xPSlider.maxValue = maxXp;
                _levelUp = true;
                _levelUp = false;
            }
            
        }

        void CollectPoints(int cyristalValue)
        {
            _currentXp += cyristalValue;
        }

        void EnemyKilled()
        {   
            //If an enemy dies, player will earn XP for enemy type.
        }
    

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Constants.smallCyristalTag))
            {
                CollectPoints(smallCyristal);
            }
            else if (other.CompareTag(Constants.midCyristalTag))
            {
                CollectPoints(midCyristal);
            }
            else if (other.CompareTag(Constants.bigCyristalTag))
            {
                CollectPoints(bigCyristal);
            }
        
            Destroy(other.gameObject);
        }
    }
}
