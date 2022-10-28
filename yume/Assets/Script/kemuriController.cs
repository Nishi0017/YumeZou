using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kemuriController : MonoBehaviour
{
    [Header("ジェネレータの数")]private int N = 2;
    
    public void StopKemuri()
    {
        N--;
        if (N == 0)
        {
            /*ParticleSystem.MainModule par = GetComponent<ParticleSystem>().main;
            while(par.startColor.a != 0)
            {
                if(Time.frameCount % 60 == 0)
                {
                    par.startColor = 
                }
            }*/
            this.gameObject.SetActive(false);
        }
    }
    
}
