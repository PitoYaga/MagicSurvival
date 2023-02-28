using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLevels : MonoBehaviour
{

    [SerializeField] Image level2lock;
    [SerializeField] Image level3lock;
    [SerializeField] Image level4lock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LockImages()
    {
        if (Saves.level2 == true)
        {
            //close lock images
        }

    }
    public void Level1()
    {
        if (Saves.level1 ==true)
        {
            SceneManager.LoadScene("Level1");
        }
        
    }

   public void Level2()
    {
        if (Saves.level2 == true)
        {

            SceneManager.LoadScene("Level2");
        }
    }
    public void Level3()
    {
        if (Saves.level3 == true)
        { SceneManager.LoadScene("Level3"); }
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
