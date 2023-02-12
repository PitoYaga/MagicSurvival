using System;
using Game;
using Unity.Mathematics;
using UnityEngine;

namespace Skills
{
    public class SkillHandler : MonoBehaviour
    {
        [SerializeField] private GameObject fireBallGun;
        [SerializeField] private GameObject thunder;

        private GameObject _player;


        void Start()
        {
            _player = GameObject.FindWithTag(Constants.playerGunTag);
        }

        public void FireBallSkill()
        {
            if (ValueBank.fireBallBool)
            {
                GameObject fireBallGunClone = Instantiate(fireBallGun, transform.position, quaternion.identity);
                fireBallGunClone.transform.SetParent(_player.transform);
            }
        }

        public void ThunderSkill()
        {
            if (ValueBank.thunderBool)
            {
                GameObject thunderClone = Instantiate(thunder, transform.position, quaternion.identity);
                thunderClone.transform.SetParent(_player.transform);
            }
        }
        
        
    }
}
