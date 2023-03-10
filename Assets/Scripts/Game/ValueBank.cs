using UnityEngine;

namespace Game
{
    public class ValueBank : MonoBehaviour
    {
        public static int CurrentXp = 0; //if enemy dies, this value will increase
        public static bool levelUp;
    
        public static float bulletDamage = 5; //if enemy dies, this value will increase
    
        public static int basicShootLevel = 1;
        public static int movementLevel = 1;
        public static int healthLevel = 1;

        public static bool laserBool;
        public static bool fireBallBool;
        public static bool shieldBool;
        public static bool thunderBool;
        
        public static int laserLevel = 1;
        public static int fireBallLevel = 1;
        public static int shieldLevel = 1;
        public static int thunderLevel = 1;
        
        public static float laserDamage = 10;
        public static float FireBallDamage = 10;
        public static float ThunderDamage = 15;
    }
}
