using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollinder : MonoBehaviour
{
    //private ZibraLiquidCollider col = null;
    void Start()
    {
        //col = GetComponent<ZibraLiquidCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ぶつかった！");
    }
}

