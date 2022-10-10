using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    [SerializeField]
   private int sceneToLoad;


    public void QuitGame()
    {
        //indexed scene
        Application.Quit();
        Debug.Log("Quitting");
    }
    public void StartGame()
    {

        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New scene loaded");
    }
    public void TestButton()
    {
        Debug.Log("Pressed");
    }



}
