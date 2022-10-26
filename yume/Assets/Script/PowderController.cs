using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowderController : MonoBehaviour
{

    public void Parent()
    {
        GameObject sikenkan = GameObject.Find("test tube.005");
        this.gameObject.transform.parent = sikenkan.gameObject.transform;
    }

    public void Childeren()
    {
        gameObject.transform.parent = null;

    }
}
