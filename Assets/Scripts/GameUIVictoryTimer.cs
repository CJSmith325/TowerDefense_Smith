using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIVictoryTimer : MonoBehaviour
{
    Text timeDisplay;

    protected float Timer;

    public int DelayAmount = 1; // Second count
    // Start is called before the first frame update
    void Start()
    {
        timeDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= DelayAmount)
        {
            Timer = 0f;
            GameControl.winTime -= 1;
        }
        timeDisplay.text = GameControl.winTime.ToString();

        if (GameControl.winTime == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (GameControl.health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
