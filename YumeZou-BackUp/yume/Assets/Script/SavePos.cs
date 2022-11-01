using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
    public Vector3 savaPos;

    void Start()
    {
        savePos = this.transform.position;
    }
}
