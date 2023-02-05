using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    [SerializeField] private float enemyHeath = 10;
    [SerializeField] private float speed = 20;
    [SerializeField] private int xpValue = 15;
    [SerializeField] private float suicideDistance = 1;

    private Rigidbody2D _rigidbody2D;
    private GameObject _player;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

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

        if (Vector2.Distance(transform.position,_player.transform.position) <= suicideDistance)
        {
            //explode anim
            //give damage to player
            
            Destroy(gameObject);
        }
    }

    void GetDamage()
    {
        enemyHeath -= ValueBank.bulletDamage;
        if (enemyHeath <= 0)
        {
            ValueBank.currentXp += xpValue;
            
            Debug.Log(ValueBank.currentXp);
            Destroy(gameObject); //death anim
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Constants.bulletTag))
        {
            Destroy(other.gameObject);
            GetDamage();
        }
    }
}
