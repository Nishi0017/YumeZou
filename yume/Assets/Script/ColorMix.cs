using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMix : MonoBehaviour
{
    private Color myColor;
    private float R1;
    private float G1;
    private float B1;
    private float C1;
    private float M1;
    private float Y1;
    private float K1;
    private Color mixColor;
    private float R2;
    private float G2;
    private float B2;
    private float C2;
    private float M2;
    private float Y2;
    private float K2;

    private void Start()
    {
        mixColor = Color.white;
        GetComponent<Renderer>().material.color = mixColor;

    }
    private void OnCollisionEnter(Collision collision)
    {

        Color colColor;
        GameObject colObj = collision.gameObject;
        
        if(colObj.tag == "Color")
        {
            myColor = this.GetComponent<Renderer>().material.color;
            colColor = colObj.GetComponent<Renderer>().material.color;
            //mixColor += colColor;
            //GetComponent<Renderer>().material.color = mixColor;

            R1 = myColor.r / 255;
            G1 = myColor.g / 255;
            B1 = myColor.b / 255;

            R2 = colColor.r / 255;
            G2 = colColor.g / 255;
            B2 = colColor.b / 255;

            if (1 - R1 < 1 - G1)
            {
                if (1 - R1 < 1 - B1)
                {
                    K1 = 1 - R1;
                }
            }
            else if (1 - G1 < 1 - B1)
            {
                K1 = 1 - G1;
            }
            else
            {
                K1 = 1 - B1;
            }
            C1 = 1 - R1 - K1;
            M1 = 1 - G1 - K1;
            Y1 = 1 - B1 - K1;

            if(1-R2 < 1-G2)
            {
                if(1-R2 < 1-B2)
                {
                    K2 = 1-R2;
                }
            }else if(1-G2 < 1-B2)
            {
                K2 = 1-G2;
            }
            else
            {
                K2 = 1-B2;
            }
            C2 = 1 - R2 - K2;
            M2 = 1 - G2 - K2;
            Y2 = 1 - B2 - K2;

            C1 += C2;
            M1 += M2;
            Y1 += Y2;

            GetComponent<Renderer>().material.color = new (C1, M1, Y1);

        }
    }
}
