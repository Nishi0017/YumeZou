using com.zibra.liquid.DataStructures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atari : MonoBehaviour
{
    public GameObject kemuri;

    private Color objColor = Color.white;
    
    private GameObject waterObj;
    private saveColor saveColorScript;
    
    private Transform[] awaGene;
    private int ChildNum= 0;

    private bool colorChange = false;

    private void Start()
    {
        objColor = new Color(161.0f / 255, 161.0f / 255, 161.0f / 255, 1.0f);
        waterObj = transform.parent.gameObject;
        ChildNum = waterObj.transform.childCount;
        saveColorScript = waterObj.GetComponent<saveColor>();
        awaGene = new Transform[ChildNum];
        
    }


    private void OnTriggerStay(Collider other)
    {
        GameObject obj = other.gameObject;
        if (other.gameObject.tag == "Color")
        {
            objColor = obj.GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = objColor;
            colorChange = true;
            
        }
        if (other.gamObject.tag == "Bin" && !colorChange) //ƒrƒ“‚Ìparent‚Ìtag‚ð"Bin"‚É
        {
            Destroy(obj);
            colorChange = true;
        }
        else if (other.gameObject.tag == "KL")
        {
            Destroy(obj);
            kemuri.gameObject.SetActive(true);
            for (int i = 0; i < ChildNum; i++)
            {
                int I = i + 1;
                awaGene[i] = waterObj.transform.Find("AwaGene" + I);
                if (awaGene[i] != null)
                {
                    awaGene[i].gameObject.SetActive(true);
                }
                else
                {
                    break;
                }
            }
            Destroy(this.gameObject);
        }
    }    
}
