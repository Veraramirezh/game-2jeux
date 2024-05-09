using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
    
        SceneManager.LoadSceneAsync(1);  
        
    }

    public void PlayLevel1()
    {
    
        SceneManager.LoadSceneAsync(2);  
        
    }
    
    public void PlayLevel2()
    {
    
        SceneManager.LoadSceneAsync(3);  
        
    }

    public void QuitGame()
    {
        Application.Quit();

    }

}
