using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    int count = 0;
    [SerializeField]
   public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = Convert.ToString(count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pointer"))
        {

            
            Destroy(this.gameObject);
            count++;
            text.text = "X" + Convert.ToString(count);
        }
    }
}
