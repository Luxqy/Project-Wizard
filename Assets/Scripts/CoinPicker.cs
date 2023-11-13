using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPicker : MonoBehaviour
{
    public Text text;
    [SerializeField]
    int counter = 0;
    int timer = 20;
    int delay = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "X" + Convert.ToString(counter);
        if (Input.GetKey(KeyCode.H)) {
            if (delay == timer)
            {
                counter++;
                delay = 0;
            } delay += 1;
            
        }
    }
}
