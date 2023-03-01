using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoldCoin : MonoBehaviour
{
    [SerializeField] public int Goldcoin = 0;

    

    void Start()
    {
        PlayerPrefs.SetFloat("GoldCoin",Goldcoin);
        PlayerPrefs.Save();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GoldCoin"))
        {
            Goldcoin++;
            Destroy(other.GameObject());
            Debug.Log(Goldcoin);
        }
    }

    void Update()
    {
        
    }
}
