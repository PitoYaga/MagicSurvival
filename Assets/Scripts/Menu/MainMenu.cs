using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelScene()
    {
        SceneManager.LoadScene("GameLevels");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

 
    
}
