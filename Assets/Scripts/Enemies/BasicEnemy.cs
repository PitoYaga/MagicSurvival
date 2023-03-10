using Game;
using UnityEngine;

namespace Enemies
{
    public class BasicEnemy : MonoBehaviour
    {
        [SerializeField] private float enemyHeath = 10;
        public float enemyDamage = 25;
        [SerializeField] private float speed = 20;
        [SerializeField] private int xpValue = 15;
        [SerializeField] private float suicideDistance = 1;
    
        private GameObject _player;

        void Start()
        {
            _player = GameObject.FindWithTag(Constants.playerTag);
        }

        void Update()
        {
            MoveToPlayer();
        }

        void MoveToPlayer()
        {
            transform.LookAt(_player.transform.position);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            
            Attack();
        }

        public void Attack()
        {
            if (Vector2.Distance(transform.position,_player.transform.position) <= suicideDistance)
            {
                //explode anim
                //give damage to player
            
                //Destroy(gameObject);
            }
        }

        void GetDamage(float damage)
        {
            enemyHeath -= damage;
        
            if (enemyHeath <= 0)
            {
                ValueBank.CurrentXp += xpValue;
                //death anim
                
                SaveSystem.KillCount++;
                SaveSystem.SaveSystemSave();
                
                Debug.Log("KillCount" + SaveSystem.KillCount);
                Destroy(gameObject); 
            }
            
            //Debug.Log(enemyHeath);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(Constants.bulletTag))
            {
                GetDamage(ValueBank.bulletDamage);
            }
            if (other.gameObject.CompareTag(Constants.fireBallTag))
            {
                GetDamage(ValueBank.FireBallDamage);
            }
            if (other.gameObject.CompareTag(Constants.thunderTag))
            {
                GetDamage(ValueBank.ThunderDamage);
            }
        }
        
        
    }
}
