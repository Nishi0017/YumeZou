using com.zibra.liquid.DataStructures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atari : MonoBehaviour
{
    //[HideInInspector]public bool isOn;
    //[HideInInspector]public bool isOn_color; 
    private Color objColor = Color.white;
    //public ColerController colorController;
    
    private GameObject waterObj;
    private saveColor saveColorScript;
    //private ZibraLiquidMaterialParameters ZibraLiquidMaterialParameters;
    
    private Transform[] awaGene;
    private int ChildNum= 0;

    // Start is called before the first frame update
    private void Start()
    {
        objColor = new Color(161.0f / 255, 161.0f / 255, 161.0f / 255, 1.0f);
        //isOn_color = false;
        //isOn = false ;
        
        waterObj = transform.parent.gameObject;
        ChildNum = waterObj.transform.childCount;
        Debug.Log(ChildNum);
        saveColorScript = waterObj.GetComponent<saveColor>();

        //ZibraLiquidMaterialParameters = waterObj.GetComponent<ZibraLiquidMaterialParameters>();
        
        awaGene = new Transform[ChildNum];
        
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Color")
        {
            //isOn_color = true;
            GameObject obj = other.gameObject;
            objColor = obj.GetComponent<Renderer>().material.color;
            //ZibraLiquidMaterialParameters.Color = objColor; 
            GetComponent<Renderer>().material.color = objColor;
            saveColorScript.SaveColor(objColor);
            Destroy(obj);
        }
        else if (other.gameObject.tag == "KL")
        {
            Destroy(other.gameObject);
            //isOn = true;


            for (int i = 0; i < ChildNum; i++)
            {
                int I = i + 1;
                awaGene[i] = waterObj.transform.Find("AwaGene" + I);
                Debug.Log(awaGene[i]);
                Debug.Log("AwaGene" + I);
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
