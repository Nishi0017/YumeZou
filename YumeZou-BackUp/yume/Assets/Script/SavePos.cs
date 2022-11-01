using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
    private Vector3 savePos;
    
    void Start()
    {

        savePos = this.transform.position;

    }

    public void ReturnPos()
    {
        this.transform.position = savePos;        
    }
}
