using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void Leave()
    {
        Application.Quit();
    }


    public void LoadLevel(string name)
    {
        GameControl.health = 200;
        GameControl.currency = 0;
        GameControl.winTime = 180;
        SceneManager.LoadScene(name);
    }
}
