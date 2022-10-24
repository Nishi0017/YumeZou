using com.zibra.liquid.DataStructures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atari : MonoBehaviour
{
    [HideInInspector]public bool isOn;
    [HideInInspector]public bool isOn_color; 
    public Color objColor;
    public ColerController colorController;
    
    private Transform waterObj;
    private ZibraLiquidMaterialParameters ZibraLiquidMaterialParameters;
    private Transform[] awaGene;
    private int ChildNum= 0;

    // Start is called before the first frame update
    private void Start()
    {
        objColor = new Color(161.0f / 255, 161.0f / 255, 161.0f / 255, 1.0f);
        isOn_color = false;
        isOn = false ;
        ChildNum = this.transform.childCount;
        waterObj = this.transform.Find("Zibra Liquid 2");
        ZibraLiquidMaterialParameters = waterObj.GetComponent<ZibraLiquidMaterialParameters>();
        Debug.Log(ChildNum);
        awaGene = new Transform[ChildNum];
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision Collision)
    {

        if (Collision.gameObject.tag == "Color")
        {
            isOn_color = true ;
            GameObject obj = Collision.gameObject;
            objColor = obj.GetComponent<Renderer>().material.color;
            ZibraLiquidMaterialParameters.Color = objColor; 
            Destroy(obj);
        }
        else if(Collision.gameObject.tag == "KL")
        {
            isOn = true;


            for (int i = 0; i < ChildNum; i++)
            {
                int I = i + 1;
                awaGene[i] = this.transform.Find("AwaGene" + I);
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
            Destroy(waterObj.gameObject);
        }

    }

    
}
