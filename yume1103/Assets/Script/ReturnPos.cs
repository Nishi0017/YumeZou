using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnPos : MonoBehaviour
{
    public AudioClip glassBreak;
    public AudioClip fallKL;
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
                PlaySound playSound = fallObj.GetComponent<PlaySound>();
                playSound.PlaySE(fallKL);
            }
            if (other.gameObject.tag == "Color")
            {
                fallObjChild = other.gameObject;
                fallObj = fallObjChild.transform.parent.gameObject;
                PlaySound playSound = fallObj.GetComponent<PlaySound>();
                playSound.PlaySE(glassBreak);
            }      
         savePosScript = fallObj.GetComponent<SavePos>();

         savePosScript.ReturnPos();
        }
    }
}
