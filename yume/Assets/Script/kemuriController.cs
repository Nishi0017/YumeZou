using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kemuriController : MonoBehaviour
{
    [Header("ジェネレータの数")]private int N = 2;
    
    public void StopKemuri()
    {
        N--;
        if(N == 0)
            this.gameObject.SetActive(false);
    }
    
}
