using UnityEngine;

namespace Player
{
    public class DetectNearestEnemy : MonoBehaviour
    {
        void Start()
        {
        
        }
    
        void Update()
        {
            FindClosestEnemy();
        }
    
        void FindClosestEnemy() 
        {
            float distanceToClosestEnemy = Mathf.Infinity; GameObject closestEnemy = null;
            GameObject[] allEnemies = GameObject.FindGameObjectsWithTag(Constants.enemyTag);
                
            foreach (GameObject currentEnemy in allEnemies)
            {
                float distanceToEnemy = (currentEnemy.transform.position - transform.position).sqrMagnitude;
                if (distanceToEnemy < distanceToClosestEnemy)
                {
                    distanceToClosestEnemy = distanceToEnemy;
                    closestEnemy = currentEnemy;
                }
    
                if (closestEnemy is not null)
                {
                    transform.LookAt(closestEnemy.transform.position);
                    transform.Rotate(new Vector3(0, -90, -90), Space.Self); 
                }
            }
        }
    
    
    
    }
}
