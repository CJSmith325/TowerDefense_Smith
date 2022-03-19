using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    Text currencyDisplay;

    void Start()
    {
        currencyDisplay = GetComponent<Text>();
    }

    void Update()
    {
        currencyDisplay.text = GameControl.currency.ToString();
    }
}
