using System;
using Game;
using Unity.Mathematics;
using UnityEngine;

namespace Skills
{
    public class SkillHandler : MonoBehaviour
    {
        [SerializeField] private Canvas levelUpCanvas;
        [SerializeField] private GameObject fireBallGun;
        [SerializeField] private GameObject thunder;
        [SerializeField] private GameObject shield;

        private GameObject _playerGun;


        void Start()
        {
            _playerGun = GameObject.FindWithTag(Constants.playerGunTag);
        }

        public void FireBallSkill()
        {
            if (ValueBank.fireBallBool)
            {
                GameObject fireBallGunClone = Instantiate(fireBallGun, transform.position, quaternion.identity);
                fireBallGunClone.transform.SetParent(_playerGun.transform);
                Time.timeScale = 1;
                Destroy(levelUpCanvas);
            }
        }

        public void ThunderSkill()
        {
            if (ValueBank.thunderBool)
            {
                GameObject thunderClone = Instantiate(thunder, transform.position, quaternion.identity);
                thunderClone.transform.SetParent(_playerGun.transform);
                Time.timeScale = 1;
                Destroy(levelUpCanvas);
            }
        }
        
        public void ShieldSkill()
        {
            if (ValueBank.thunderBool)
            {
                GameObject shieldClone = Instantiate(shield, transform.position, quaternion.identity);
                shieldClone.transform.SetParent(_playerGun.transform);
                Time.timeScale = 1;
                Destroy(levelUpCanvas);
            }
        }
        
        
    }
}
