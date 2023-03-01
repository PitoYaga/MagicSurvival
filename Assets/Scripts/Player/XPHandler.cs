using Game;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class XpHandler : MonoBehaviour
    {
        [SerializeField] float maxXp = 100;
        [SerializeField] float xPMultiply = 15;
        [SerializeField] private int smallCyristal = 10;
        [SerializeField] private int midCyristal = 15;
        [SerializeField] private int bigCyristal = 20;
        [SerializeField] private Slider xPSlider;
        [SerializeField] private GameObject levelUpCanvas;
        
        private int _level = 1;
        private int _currentXp;
    
        void Start()
        {
            //levelUpCanvas.SetActive(false);
            xPSlider.maxValue = maxXp;
        }

    
        void Update()
        {
            ValueBank.CurrentXp = _currentXp;
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
                
                LevelUp();
            }
        }

        void LevelUp()
        {
            ValueBank.levelUp = true;
            Instantiate(levelUpCanvas, transform.position, quaternion.identity);
            //levelUpCanvas.SetActive(true);
            ValueBank.levelUp = false;
            Time.timeScale = 0;
        }

        void CollectPoints(int cyristalValue)
        {
            _currentXp += cyristalValue;
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
