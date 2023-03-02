using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SaveSystem : MonoBehaviour
{
     public static int Goldcoin = 0;
     public static int KillCount = 0;
     private void Start()
     {
         Goldcoin = PlayerPrefs.GetInt(nameof(SaveSystem));
         KillCount = PlayerPrefs.GetInt(nameof(SaveSystem));
     }

     public  static void SaveSystemSave()
    {
        PlayerPrefs.SetInt(nameof(SaveSystem),Goldcoin);
        PlayerPrefs.SetInt(nameof(SaveSystem),KillCount);
        PlayerPrefs.Save();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(Constants.GoldCoinTag))
        {
            Goldcoin++;
            Destroy(other.gameObject);
            SaveSystemSave();
            Debug.Log(Goldcoin);
        }
        
    }

    void Update()
    {
        
    }
}
