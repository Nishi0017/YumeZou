using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMix : MonoBehaviour
{
    private Color mixColor;

    private void Start()
    {
        mixColor = Color.black;
        GetComponent<Renderer>().material.color = mixColor;

    }
    private void OnCollisionEnter(Collision collision)
    {

        Color colColor;
        GameObject colObj = collision.gameObject;
        
        if(colObj.tag == "Color")
        {
            colColor = colObj.GetComponent<Renderer>().material.color;
            mixColor += colColor;
            GetComponent<Renderer>().material.color = mixColor;
        }
    }
}
