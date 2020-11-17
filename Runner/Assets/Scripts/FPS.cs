using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public static float fps;
    
    Text txt;
    


    void Start()
    {
        txt = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        fps = 1.0f / Time.deltaTime;
        txt.text = "FPS:" + (int)fps;

       

    }
}