using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnPos : MonoBehaviour
{
    private GameObject fallObj;
    private GameObject fallObjChild;
    private SavePos savePosScript;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "KL" || other.gameObject.tag == "Color")
        {
        if (other.gameObject.tag == "KL")
        {
            fallObj = other.gameObject;
        }
        if (other.gameObject.tag == "Color")
        {
            fallObjChild = other.gameObject;
            fallObj = fallObjChild.transform.parent.gameObject;
        }   
         savePosScript = fallObj.GetComponent<SavePos>();

         savePosScript.ReturnPos();
        }
    }
}
