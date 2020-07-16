using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    String str = "You lose haha";
    // Start is called before the first frame update
    void Start()
    {
        //Console.WriteLine(score.ToString());
        GetComponent<Text>().text = "";
    }

    public void Over()
    {
        GetComponent<Text>().text = str;
    }
}