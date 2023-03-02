using Game;
using UnityEngine;

namespace Skills
{
    public class SkillUpgrade : MonoBehaviour
    {
        [SerializeField] private GameObject levelUpCanvas;
        
        public void HealthUpgrade()
        {
            ValueBank.healthLevel++;
        }
        
        public void MovementUpgrade()
        {
            ValueBank.movementLevel++;
        }
        
        public void BasicShootUpgrade()
        {
            ValueBank.basicShootLevel++;
            Time.timeScale = 1;
            Destroy(levelUpCanvas);
            Debug.Log("upgrated");
        }
        
        public void FireBallUpgrade()
        {
            ValueBank.fireBallLevel++;
        }

        public void ThunderUpgrade()
        {
            ValueBank.thunderLevel++;
        }
    }
}
