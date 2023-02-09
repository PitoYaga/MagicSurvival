using System;
using Game;
using Unity.Mathematics;
using UnityEngine;

namespace Skills
{
    public class SkillHandler : MonoBehaviour
    {
        [SerializeField] private GameObject fireBallGun;

        private GameObject _player;


        void Start()
        {
            _player = GameObject.FindWithTag(Constants.playerTag);
        }

        public void FireBallSkill()
        {
            if (ValueBank.fireBallBool == true)
            {
                GameObject fireBallGunClone = Instantiate(fireBallGun, transform.position, quaternion.identity);
                fireBallGunClone.transform.SetParent(_player.transform);
            }
        }
    }
}
