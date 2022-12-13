using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{
    private int frameCounter = 0;
    // 0.01 = 1 sekunde
    

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
        if (frameCounter % 60 == 0) {
    // Call SetColor using the shader property name "_Color" and setting the color to red
        GetComponent<Renderer>().material.SetColor("_Color", Random.ColorHSV());
        frameCounter = 0;
     }
    }
}
