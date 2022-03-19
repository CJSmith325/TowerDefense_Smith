using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerTimer : MonoBehaviour
{
    Text timeDisplay;

    protected float Timer;

    private int time = 40;
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
            time -= 1;
        }

        timeDisplay.text = time.ToString();

        if (time == 0)
        {
            Destroy(transform.parent.parent.gameObject);
        }
    }
}
