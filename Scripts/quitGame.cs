using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitGame : MonoBehaviour
{
     public void doExitGame() {
        Application.Quit();
        Debug.Log("hello");
    }

     public void backToMenu()
     {
         SceneManager.LoadScene("MainMenu");
     }
}
