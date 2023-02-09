using Game;
using UnityEngine;

namespace Skills
{
    public class SkillUpgrade : MonoBehaviour
    {
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
        }
        
        public void FireBallUpgrade()
        {
            ValueBank.fireBallLevel++;
        }
    }
}
